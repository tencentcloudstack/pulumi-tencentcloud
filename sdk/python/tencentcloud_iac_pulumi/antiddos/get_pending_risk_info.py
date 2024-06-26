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
    'GetPendingRiskInfoResult',
    'AwaitableGetPendingRiskInfoResult',
    'get_pending_risk_info',
    'get_pending_risk_info_output',
]

@pulumi.output_type
class GetPendingRiskInfoResult:
    """
    A collection of values returned by getPendingRiskInfo.
    """
    def __init__(__self__, attacking_count=None, blocking_count=None, expired_count=None, id=None, is_paid_usr=None, result_output_file=None, total=None):
        if attacking_count and not isinstance(attacking_count, int):
            raise TypeError("Expected argument 'attacking_count' to be a int")
        pulumi.set(__self__, "attacking_count", attacking_count)
        if blocking_count and not isinstance(blocking_count, int):
            raise TypeError("Expected argument 'blocking_count' to be a int")
        pulumi.set(__self__, "blocking_count", blocking_count)
        if expired_count and not isinstance(expired_count, int):
            raise TypeError("Expected argument 'expired_count' to be a int")
        pulumi.set(__self__, "expired_count", expired_count)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if is_paid_usr and not isinstance(is_paid_usr, bool):
            raise TypeError("Expected argument 'is_paid_usr' to be a bool")
        pulumi.set(__self__, "is_paid_usr", is_paid_usr)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)
        if total and not isinstance(total, int):
            raise TypeError("Expected argument 'total' to be a int")
        pulumi.set(__self__, "total", total)

    @property
    @pulumi.getter(name="attackingCount")
    def attacking_count(self) -> int:
        """
        Number of resources in the attack.
        """
        return pulumi.get(self, "attacking_count")

    @property
    @pulumi.getter(name="blockingCount")
    def blocking_count(self) -> int:
        """
        Number of resources in blockage.
        """
        return pulumi.get(self, "blocking_count")

    @property
    @pulumi.getter(name="expiredCount")
    def expired_count(self) -> int:
        """
        Number of expired resources.
        """
        return pulumi.get(self, "expired_count")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="isPaidUsr")
    def is_paid_usr(self) -> bool:
        """
        Is it a paid user? True: paid user, false: regular user.
        """
        return pulumi.get(self, "is_paid_usr")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")

    @property
    @pulumi.getter
    def total(self) -> int:
        """
        Total number of all pending risk events.
        """
        return pulumi.get(self, "total")


class AwaitableGetPendingRiskInfoResult(GetPendingRiskInfoResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetPendingRiskInfoResult(
            attacking_count=self.attacking_count,
            blocking_count=self.blocking_count,
            expired_count=self.expired_count,
            id=self.id,
            is_paid_usr=self.is_paid_usr,
            result_output_file=self.result_output_file,
            total=self.total)


def get_pending_risk_info(result_output_file: Optional[str] = None,
                          opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetPendingRiskInfoResult:
    """
    Use this data source to query detailed information of antiddos pending risk info

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    pending_risk_info = tencentcloud.Antiddos.get_pending_risk_info()
    ```
    <!--End PulumiCodeChooser -->


    :param str result_output_file: Used to save results.
    """
    __args__ = dict()
    __args__['resultOutputFile'] = result_output_file
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Antiddos/getPendingRiskInfo:getPendingRiskInfo', __args__, opts=opts, typ=GetPendingRiskInfoResult).value

    return AwaitableGetPendingRiskInfoResult(
        attacking_count=pulumi.get(__ret__, 'attacking_count'),
        blocking_count=pulumi.get(__ret__, 'blocking_count'),
        expired_count=pulumi.get(__ret__, 'expired_count'),
        id=pulumi.get(__ret__, 'id'),
        is_paid_usr=pulumi.get(__ret__, 'is_paid_usr'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'),
        total=pulumi.get(__ret__, 'total'))


@_utilities.lift_output_func(get_pending_risk_info)
def get_pending_risk_info_output(result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                                 opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetPendingRiskInfoResult]:
    """
    Use this data source to query detailed information of antiddos pending risk info

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    pending_risk_info = tencentcloud.Antiddos.get_pending_risk_info()
    ```
    <!--End PulumiCodeChooser -->


    :param str result_output_file: Used to save results.
    """
    ...
