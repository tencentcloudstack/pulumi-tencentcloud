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
    'GetRecoveryTimeResult',
    'AwaitableGetRecoveryTimeResult',
    'get_recovery_time',
    'get_recovery_time_output',
]

@pulumi.output_type
class GetRecoveryTimeResult:
    """
    A collection of values returned by getRecoveryTime.
    """
    def __init__(__self__, db_instance_id=None, id=None, recovery_begin_time=None, recovery_end_time=None, result_output_file=None):
        if db_instance_id and not isinstance(db_instance_id, str):
            raise TypeError("Expected argument 'db_instance_id' to be a str")
        pulumi.set(__self__, "db_instance_id", db_instance_id)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if recovery_begin_time and not isinstance(recovery_begin_time, str):
            raise TypeError("Expected argument 'recovery_begin_time' to be a str")
        pulumi.set(__self__, "recovery_begin_time", recovery_begin_time)
        if recovery_end_time and not isinstance(recovery_end_time, str):
            raise TypeError("Expected argument 'recovery_end_time' to be a str")
        pulumi.set(__self__, "recovery_end_time", recovery_end_time)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)

    @property
    @pulumi.getter(name="dbInstanceId")
    def db_instance_id(self) -> str:
        return pulumi.get(self, "db_instance_id")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="recoveryBeginTime")
    def recovery_begin_time(self) -> str:
        """
        The earliest restoration time (UTC+8).
        """
        return pulumi.get(self, "recovery_begin_time")

    @property
    @pulumi.getter(name="recoveryEndTime")
    def recovery_end_time(self) -> str:
        """
        The latest restoration time (UTC+8).
        """
        return pulumi.get(self, "recovery_end_time")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")


class AwaitableGetRecoveryTimeResult(GetRecoveryTimeResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetRecoveryTimeResult(
            db_instance_id=self.db_instance_id,
            id=self.id,
            recovery_begin_time=self.recovery_begin_time,
            recovery_end_time=self.recovery_end_time,
            result_output_file=self.result_output_file)


def get_recovery_time(db_instance_id: Optional[str] = None,
                      result_output_file: Optional[str] = None,
                      opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetRecoveryTimeResult:
    """
    Use this data source to query detailed information of postgresql recovery_time

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    recovery_time = tencentcloud.Postgresql.get_recovery_time(db_instance_id=local["pgsql_id"])
    ```
    <!--End PulumiCodeChooser -->


    :param str db_instance_id: Instance ID.
    :param str result_output_file: Used to save results.
    """
    __args__ = dict()
    __args__['dbInstanceId'] = db_instance_id
    __args__['resultOutputFile'] = result_output_file
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Postgresql/getRecoveryTime:getRecoveryTime', __args__, opts=opts, typ=GetRecoveryTimeResult).value

    return AwaitableGetRecoveryTimeResult(
        db_instance_id=pulumi.get(__ret__, 'db_instance_id'),
        id=pulumi.get(__ret__, 'id'),
        recovery_begin_time=pulumi.get(__ret__, 'recovery_begin_time'),
        recovery_end_time=pulumi.get(__ret__, 'recovery_end_time'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'))


@_utilities.lift_output_func(get_recovery_time)
def get_recovery_time_output(db_instance_id: Optional[pulumi.Input[str]] = None,
                             result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                             opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetRecoveryTimeResult]:
    """
    Use this data source to query detailed information of postgresql recovery_time

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    recovery_time = tencentcloud.Postgresql.get_recovery_time(db_instance_id=local["pgsql_id"])
    ```
    <!--End PulumiCodeChooser -->


    :param str db_instance_id: Instance ID.
    :param str result_output_file: Used to save results.
    """
    ...
