# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = [
    'GetDomainListTagArgs',
]

@pulumi.input_type
class GetDomainListTagArgs:
    def __init__(__self__, *,
                 tag_key: str,
                 tag_values: Sequence[str]):
        """
        :param str tag_key: Field to be filtered.
        :param Sequence[str] tag_values: Filter value of the field.
        """
        pulumi.set(__self__, "tag_key", tag_key)
        pulumi.set(__self__, "tag_values", tag_values)

    @property
    @pulumi.getter(name="tagKey")
    def tag_key(self) -> str:
        """
        Field to be filtered.
        """
        return pulumi.get(self, "tag_key")

    @tag_key.setter
    def tag_key(self, value: str):
        pulumi.set(self, "tag_key", value)

    @property
    @pulumi.getter(name="tagValues")
    def tag_values(self) -> Sequence[str]:
        """
        Filter value of the field.
        """
        return pulumi.get(self, "tag_values")

    @tag_values.setter
    def tag_values(self, value: Sequence[str]):
        pulumi.set(self, "tag_values", value)

