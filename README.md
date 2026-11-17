# Pulumi TencentCloud Resource Provider

[![Apache 2.0 License](https://img.shields.io/github/license/tencentcloudstack/pulumi-tencentcloud.svg)](LICENSE)
[![NPM version](https://img.shields.io/npm/v/@tencentcloud-infra/pulumi.svg)](https://www.npmjs.com/package/@tencentcloud-infra/pulumi)
[![PyPI version](https://img.shields.io/pypi/v/tencentcloud-infra-pulumi.svg)](https://pypi.org/project/tencentcloud-infra-pulumi/)
[![Go Reference](https://pkg.go.dev/badge/github.com/tencentcloudstack/pulumi-tencentcloud/sdk.svg)](https://pkg.go.dev/github.com/tencentcloudstack/pulumi-tencentcloud/sdk)
[![NuGet version](https://img.shields.io/nuget/v/TencentCloudIAC.PulumiPackage.Tencentcloud.svg)](https://www.nuget.org/packages/TencentCloudIAC.PulumiPackage.Tencentcloud)

<div>
  <p>
    <a href="https://www.tencentcloud.com">
        <img src=".github/01_Tcloud_logo_Eng.png" alt="logo" title="Terraform" height="69">
    </a>
    <br>
    <i>Tencent Infrastructure Automation for Pulumi.</i>
    <br>
  </p>
</div>

The Pulumi TencentCloud Resource Provider lets you manage [TencentCloud](https://www.tencentcloud.com/) resources using Pulumi.

## Installing

This package is available for several languages/platforms.

> **Important: package names changed in v0.3.0**
>
> Starting with **v0.3.0**, the Node.js and Python SDKs are published under new
> package names. The package contents are functionally identical; only the
> distribution names (and, for Python, the import name) have changed.
>
> | Language | Up to and including v0.2.x (legacy) | v0.3.0 and later |
> |---|---|---|
> | Node.js | `@tencentcloud_iac/pulumi` | `@tencentcloud-infra/pulumi` |
> | Python | `tencentcloud-iac-pulumi` | `tencentcloud-infra-pulumi` |
> | Go | `github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/...` | unchanged |
> | .NET | `TencentCloudIAC.PulumiPackage.Tencentcloud` | to be announced |
>
> New releases are published under the new package names. We recommend
> migrating as described in [Migrating from v0.2.x](#migrating-from-v02x).

### Node.js (JavaScript/TypeScript)

Version **0.3.0 and later** ([npm](https://www.npmjs.com/package/@tencentcloud-infra/pulumi)):

```bash
npm install @tencentcloud-infra/pulumi   # or: yarn add @tencentcloud-infra/pulumi
```

Versions **earlier than 0.3.0** (legacy package):

```bash
npm install @tencentcloud_iac/pulumi@0.2   # or: yarn add @tencentcloud_iac/pulumi@0.2
```

### Python

Version **0.3.0 and later** ([PyPI](https://pypi.org/project/tencentcloud-infra-pulumi/)):

```bash
pip install tencentcloud-infra-pulumi
```

Versions **earlier than 0.3.0** (legacy package):

```bash
pip install "tencentcloud-iac-pulumi<0.3.0"
```

### Go

The Go module path is the same for all versions:

```bash
go get github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/...
```

### .NET

The package under the new naming scheme for **0.3.0 and later** is not available
yet. This section will be updated once it is published.

Versions **earlier than 0.3.0** (legacy package):

```bash
dotnet add package TencentCloudIAC.PulumiPackage.Tencentcloud --version 0.2.*
```

### Provider plugin

> **Note:** Package auto-download of the provider plugin is not yet
> supported. Install the provider plugin manually before running
> `pulumi up`:
>
> ```bash
> pulumi plugin install resource tencentcloud --server github://api.github.com/tencentcloudstack
> ```

### Migrating from v0.2.x

To move an existing project to v0.3.0 or later:

1. Remove the legacy package and install the new one.
   - Node.js:
     ```bash
     npm uninstall @tencentcloud_iac/pulumi
     npm install @tencentcloud-infra/pulumi
     ```
   - Python:
     ```bash
     pip uninstall tencentcloud-iac-pulumi
     pip install tencentcloud-infra-pulumi
     ```
2. Update the import statements in your program.
   - Node.js: `@tencentcloud_iac/pulumi` becomes `@tencentcloud-infra/pulumi`.
   - Python: `tencentcloud_iac_pulumi` becomes `tencentcloud_infra_pulumi`.
3. Go projects need no changes beyond upgrading the module version.

Only the SDK package names and import paths change. The resources and their
properties are the same as in v0.2.x, so no changes to your resource
definitions are expected.

## Configuration

The following configuration points are available for the `tencentcloud` provider:

| Key | Required | Description | Environment Variable |
|---|---|---|---|
| `secretId` | Yes | The API Secret ID | `TENCENTCLOUD_SECRET_ID` |
| `secretKey` | Yes | The API Secret Key | `TENCENTCLOUD_SECRET_KEY` |
| `region` | Yes | The region in which to deploy resources | `TENCENTCLOUD_REGION` |
| `securityToken` | No | The Security Token for temporary access | `TENCENTCLOUD_SECURITY_TOKEN` |

Set them via `pulumi config`:

```bash
pulumi config set tencentcloud:secretId <your-secret-id> --secret
pulumi config set tencentcloud:secretKey <your-secret-key> --secret
pulumi config set tencentcloud:region ap-singapore
```

## Example

```typescript
// v0.3.0 and later. For earlier versions, import from "@tencentcloud_iac/pulumi".
import * as tencentcloud from "@tencentcloud-infra/pulumi";

const vpc = new tencentcloud.vpc.Instance("my-vpc", {
    name: "pulumi-vpc",
    cidrBlock: "10.0.0.0/20",
});
```

See [examples/](./examples) for complete, runnable projects.

## Reference

For detailed reference documentation, see the [docs](./docs) directory or the
[Pulumi Registry](https://www.pulumi.com/registry/packages/tencentcloud/).

## Contributing

Please read [CONTRIBUTING.md](./CONTRIBUTING.md) for details on our code of
conduct and the process for submitting pull requests.

## License

This project is licensed under the Apache 2.0 License — see [LICENSE](./LICENSE).
