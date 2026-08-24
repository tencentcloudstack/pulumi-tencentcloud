#!/usr/bin/env python3
"""Post-process the pulumi-language-python generated SDK to satisfy lint rules
that the upstream Pulumi codegen (pulumi/pulumi pkg/codegen/python) does not
respect out of the box: F401, C408, E722, TRY002, RUF059, PLW0406.

This script is idempotent and is meant to be run automatically right after
`pulumi-tfgen-tencentcloud python ...` regenerates `sdk/python/`, so the fixes
never get lost the next time the SDK is regenerated (see Makefile:build_python).

Usage:
    python3 scripts/fix_python_sdk_lint.py <path-to-generated-package-dir>

Example:
    python3 scripts/fix_python_sdk_lint.py sdk/python/tencentcloud_iac_pulumi
"""
from __future__ import annotations

import re
import shutil
import subprocess
import sys
from pathlib import Path

SELF_IMPORT_RE = re.compile(r"^from \. import outputs\n", re.MULTILINE)
OUTPUTS_PREFIX_RE = re.compile(r'"outputs\.(\w+)"')

BARE_EXCEPT_RE = re.compile(r"except:\n")

RAISE_PROVIDER_RE = re.compile(r'raise Exception\(f"unknown provider type \{typ\}"\)')
RAISE_RESOURCE_RE = re.compile(r'raise Exception\(f"unknown resource type \{typ\}"\)')

UNPACK_RE = re.compile(r'root_package, \*rest = __name__\.split\("\."\)')

EXCEPTION_CLASSES = '''class UnknownProviderTypeError(Exception):
    """Raised when constructing a provider of a type unknown to this package."""


class UnknownResourceTypeError(Exception):
    """Raised when constructing a resource of a type unknown to this module."""


'''

# Boilerplate scaffolding imports that pulumi-language-python emits at the top
# of every generated `__init__.py`. Ruff intentionally never auto-fixes F401
# inside `__init__.py` files (it only prints "consider removing / add to
# __all__ / use a redundant alias" as advisory help, with no machine-
# applicable edit, regardless of --fix/--unsafe-fixes), because such imports
# are often deliberate re-exports. So we do our own conservative check here:
# only drop a line if its bound name is never referenced anywhere else in
# the same file.
INIT_PY_IMPORT_LINES = [
    (re.compile(r"^import builtins as _builtins\n", re.MULTILINE), "_builtins"),
    (re.compile(r"^import typing\n", re.MULTILINE), "typing"),
    (re.compile(r"^from \.\. import _utilities\n", re.MULTILINE), "_utilities"),
    (re.compile(r"^from \. import outputs\n", re.MULTILINE), "outputs"),
]


def fix_init_py(path: Path) -> bool:
    text = path.read_text()
    original = text
    for line_re, bound_name in INIT_PY_IMPORT_LINES:
        match = line_re.search(text)
        if not match:
            continue
        remainder = text[: match.start()] + text[match.end() :]
        if re.search(r"\b" + re.escape(bound_name) + r"\b", remainder):
            continue  # referenced elsewhere in the file; keep the import
        text = remainder
    if text != original:
        path.write_text(text)
        return True
    return False


def fix_outputs_py(path: Path) -> bool:
    text = path.read_text()
    original = text
    text = SELF_IMPORT_RE.sub("", text)
    text = OUTPUTS_PREFIX_RE.sub(r'"\1"', text)
    if text != original:
        path.write_text(text)
        return True
    return False


def fix_utilities_py(path: Path) -> bool:
    if not path.exists():
        return False
    text = path.read_text()
    original = text

    text = BARE_EXCEPT_RE.sub("except Exception:\n", text)
    text = UNPACK_RE.sub('root_package = __name__.split(".")[0]', text)
    text = RAISE_PROVIDER_RE.sub(
        'raise UnknownProviderTypeError(f"unknown provider type {typ}")', text
    )
    text = RAISE_RESOURCE_RE.sub(
        'raise UnknownResourceTypeError(f"unknown resource type {typ}")', text
    )

    if "class UnknownProviderTypeError" not in text and (
        "UnknownProviderTypeError(" in text or "UnknownResourceTypeError(" in text
    ):
        marker = "class Package(pulumi.runtime.ResourcePackage):"
        if marker in text:
            text = text.replace(marker, EXCEPTION_CLASSES + marker, 1)

    if text != original:
        path.write_text(text)
        return True
    return False


def run_ruff_autofix(pkg_dir: Path) -> None:
    ruff = shutil.which("ruff")
    if ruff is None:
        try:
            subprocess.run(
                [sys.executable, "-m", "pip", "install", "--quiet", "ruff"],
                check=True,
            )
            ruff = shutil.which("ruff") or "ruff"
        except Exception as exc:  # pragma: no cover - best effort only
            print(
                f"[fix_python_sdk_lint] WARNING: ruff unavailable and could not "
                f"be installed ({exc}); skipping F401/C408 autofix.",
                file=sys.stderr,
            )
            return

    # F401 in `__init__.py` re-export hubs is only "safely" fixable by ruff via
    # an explicit `as` alias; the generated imports here (builtins/typing/
    # _utilities/outputs) are pure scaffolding never referenced in the file
    # itself, so outright removal (an "unsafe" fix in ruff's eyes) is what we
    # want, matching upstream pulumi-language-python's own style.
    subprocess.run(
        [
            ruff,
            "check",
            "--fix",
            "--unsafe-fixes",
            "--select",
            "F401,C408",
            "--no-cache",
            str(pkg_dir),
        ],
        check=False,
    )


def main() -> int:
    if len(sys.argv) != 2:
        print(f"usage: {sys.argv[0]} <package-dir>", file=sys.stderr)
        return 1

    pkg_dir = Path(sys.argv[1]).resolve()
    if not pkg_dir.is_dir():
        print(f"error: {pkg_dir} is not a directory", file=sys.stderr)
        return 1

    changed = 0
    for init_py in pkg_dir.rglob("__init__.py"):
        if fix_init_py(init_py):
            changed += 1

    for outputs_py in pkg_dir.rglob("outputs.py"):
        if fix_outputs_py(outputs_py):
            changed += 1

    if fix_utilities_py(pkg_dir / "_utilities.py"):
        changed += 1

    run_ruff_autofix(pkg_dir)

    print(
        f"[fix_python_sdk_lint] regex-based fixes applied to {changed} file(s); "
        f"ruff --fix applied for F401/C408 across {pkg_dir}"
    )
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
