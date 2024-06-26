# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = [
    'GetMachinesSimpleFilterArgs',
]

@pulumi.input_type
class GetMachinesSimpleFilterArgs:
    def __init__(__self__, *,
                 name: str,
                 values: Sequence[str],
                 exact_match: Optional[bool] = None):
        """
        :param str name: Only supported Keywords, Version and TagId.
        :param Sequence[str] values: If `name` is `Keywords`: enter keyword query; If `name` is `Version`: enter PRO_VERSION: Professional Edition | BASIC_VERSION: Basic | Flagship: Flagship | ProtectedMachines: Professional+Flagship | UnFlagship: Non Flagship | PRO_POST_PAY: Professional Edition Pay by Volume | PRO_PRE_PAY: Professional Edition Monthly Package query; If `name` is `TagId`: enter tag ID query.
        :param bool exact_match: exact match. true or false.
        """
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "values", values)
        if exact_match is not None:
            pulumi.set(__self__, "exact_match", exact_match)

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Only supported Keywords, Version and TagId.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: str):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def values(self) -> Sequence[str]:
        """
        If `name` is `Keywords`: enter keyword query; If `name` is `Version`: enter PRO_VERSION: Professional Edition | BASIC_VERSION: Basic | Flagship: Flagship | ProtectedMachines: Professional+Flagship | UnFlagship: Non Flagship | PRO_POST_PAY: Professional Edition Pay by Volume | PRO_PRE_PAY: Professional Edition Monthly Package query; If `name` is `TagId`: enter tag ID query.
        """
        return pulumi.get(self, "values")

    @values.setter
    def values(self, value: Sequence[str]):
        pulumi.set(self, "values", value)

    @property
    @pulumi.getter(name="exactMatch")
    def exact_match(self) -> Optional[bool]:
        """
        exact match. true or false.
        """
        return pulumi.get(self, "exact_match")

    @exact_match.setter
    def exact_match(self, value: Optional[bool]):
        pulumi.set(self, "exact_match", value)


