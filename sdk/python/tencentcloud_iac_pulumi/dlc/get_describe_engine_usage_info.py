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
    'GetDescribeEngineUsageInfoResult',
    'AwaitableGetDescribeEngineUsageInfoResult',
    'get_describe_engine_usage_info',
    'get_describe_engine_usage_info_output',
]

@pulumi.output_type
class GetDescribeEngineUsageInfoResult:
    """
    A collection of values returned by getDescribeEngineUsageInfo.
    """
    def __init__(__self__, available=None, data_engine_id=None, id=None, result_output_file=None, used=None):
        if available and not isinstance(available, int):
            raise TypeError("Expected argument 'available' to be a int")
        pulumi.set(__self__, "available", available)
        if data_engine_id and not isinstance(data_engine_id, str):
            raise TypeError("Expected argument 'data_engine_id' to be a str")
        pulumi.set(__self__, "data_engine_id", data_engine_id)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)
        if used and not isinstance(used, int):
            raise TypeError("Expected argument 'used' to be a int")
        pulumi.set(__self__, "used", used)

    @property
    @pulumi.getter
    def available(self) -> int:
        """
        Remaining cluster specifications.
        """
        return pulumi.get(self, "available")

    @property
    @pulumi.getter(name="dataEngineId")
    def data_engine_id(self) -> str:
        return pulumi.get(self, "data_engine_id")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")

    @property
    @pulumi.getter
    def used(self) -> int:
        """
        Engine specifications occupied.
        """
        return pulumi.get(self, "used")


class AwaitableGetDescribeEngineUsageInfoResult(GetDescribeEngineUsageInfoResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetDescribeEngineUsageInfoResult(
            available=self.available,
            data_engine_id=self.data_engine_id,
            id=self.id,
            result_output_file=self.result_output_file,
            used=self.used)


def get_describe_engine_usage_info(data_engine_id: Optional[str] = None,
                                   result_output_file: Optional[str] = None,
                                   opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetDescribeEngineUsageInfoResult:
    """
    Use this data source to query detailed information of dlc describe_engine_usage_info

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    describe_engine_usage_info = tencentcloud.Dlc.get_describe_engine_usage_info(data_engine_id="DataEngine-g5ds87d8")
    ```
    <!--End PulumiCodeChooser -->


    :param str data_engine_id: Engine unique id.
    :param str result_output_file: Used to save results.
    """
    __args__ = dict()
    __args__['dataEngineId'] = data_engine_id
    __args__['resultOutputFile'] = result_output_file
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Dlc/getDescribeEngineUsageInfo:getDescribeEngineUsageInfo', __args__, opts=opts, typ=GetDescribeEngineUsageInfoResult).value

    return AwaitableGetDescribeEngineUsageInfoResult(
        available=pulumi.get(__ret__, 'available'),
        data_engine_id=pulumi.get(__ret__, 'data_engine_id'),
        id=pulumi.get(__ret__, 'id'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'),
        used=pulumi.get(__ret__, 'used'))


@_utilities.lift_output_func(get_describe_engine_usage_info)
def get_describe_engine_usage_info_output(data_engine_id: Optional[pulumi.Input[str]] = None,
                                          result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                                          opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetDescribeEngineUsageInfoResult]:
    """
    Use this data source to query detailed information of dlc describe_engine_usage_info

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    describe_engine_usage_info = tencentcloud.Dlc.get_describe_engine_usage_info(data_engine_id="DataEngine-g5ds87d8")
    ```
    <!--End PulumiCodeChooser -->


    :param str data_engine_id: Engine unique id.
    :param str result_output_file: Used to save results.
    """
    ...
