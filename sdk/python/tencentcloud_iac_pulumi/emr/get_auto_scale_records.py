# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs
from ._inputs import *

__all__ = [
    'GetAutoScaleRecordsResult',
    'AwaitableGetAutoScaleRecordsResult',
    'get_auto_scale_records',
    'get_auto_scale_records_output',
]

@pulumi.output_type
class GetAutoScaleRecordsResult:
    """
    A collection of values returned by getAutoScaleRecords.
    """
    def __init__(__self__, filters=None, id=None, instance_id=None, record_lists=None, result_output_file=None):
        if filters and not isinstance(filters, list):
            raise TypeError("Expected argument 'filters' to be a list")
        pulumi.set(__self__, "filters", filters)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if instance_id and not isinstance(instance_id, str):
            raise TypeError("Expected argument 'instance_id' to be a str")
        pulumi.set(__self__, "instance_id", instance_id)
        if record_lists and not isinstance(record_lists, list):
            raise TypeError("Expected argument 'record_lists' to be a list")
        pulumi.set(__self__, "record_lists", record_lists)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)

    @property
    @pulumi.getter
    def filters(self) -> Optional[Sequence['outputs.GetAutoScaleRecordsFilterResult']]:
        return pulumi.get(self, "filters")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> str:
        return pulumi.get(self, "instance_id")

    @property
    @pulumi.getter(name="recordLists")
    def record_lists(self) -> Sequence['outputs.GetAutoScaleRecordsRecordListResult']:
        """
        Record list.
        """
        return pulumi.get(self, "record_lists")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")


class AwaitableGetAutoScaleRecordsResult(GetAutoScaleRecordsResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetAutoScaleRecordsResult(
            filters=self.filters,
            id=self.id,
            instance_id=self.instance_id,
            record_lists=self.record_lists,
            result_output_file=self.result_output_file)


def get_auto_scale_records(filters: Optional[Sequence[pulumi.InputType['GetAutoScaleRecordsFilterArgs']]] = None,
                           instance_id: Optional[str] = None,
                           result_output_file: Optional[str] = None,
                           opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetAutoScaleRecordsResult:
    """
    Use this data source to query detailed information of emr auto_scale_records

    ## Example Usage

    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    auto_scale_records = tencentcloud.Emr.get_auto_scale_records(filters=[tencentcloud.emr.GetAutoScaleRecordsFilterArgs(
            key="StartTime",
            value="2006-01-02 15:04:05",
        )],
        instance_id="emr-bpum4pad")
    ```


    :param Sequence[pulumi.InputType['GetAutoScaleRecordsFilterArgs']] filters: Record filtering parameters, currently only `StartTime`, `EndTime` and `StrategyName` are supported. `StartTime` and `EndTime` support the time format of 2006-01-02 15:04:05 or 2006/01/02 15:04:05.
    :param str instance_id: EMR cluster ID.
    :param str result_output_file: Used to save results.
    """
    __args__ = dict()
    __args__['filters'] = filters
    __args__['instanceId'] = instance_id
    __args__['resultOutputFile'] = result_output_file
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
        if opts.plugin_download_url is None:
            opts.plugin_download_url = _utilities.get_plugin_download_url()
    __ret__ = pulumi.runtime.invoke('tencentcloud:Emr/getAutoScaleRecords:getAutoScaleRecords', __args__, opts=opts, typ=GetAutoScaleRecordsResult).value

    return AwaitableGetAutoScaleRecordsResult(
        filters=__ret__.filters,
        id=__ret__.id,
        instance_id=__ret__.instance_id,
        record_lists=__ret__.record_lists,
        result_output_file=__ret__.result_output_file)


@_utilities.lift_output_func(get_auto_scale_records)
def get_auto_scale_records_output(filters: Optional[pulumi.Input[Optional[Sequence[pulumi.InputType['GetAutoScaleRecordsFilterArgs']]]]] = None,
                                  instance_id: Optional[pulumi.Input[str]] = None,
                                  result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                                  opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetAutoScaleRecordsResult]:
    """
    Use this data source to query detailed information of emr auto_scale_records

    ## Example Usage

    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    auto_scale_records = tencentcloud.Emr.get_auto_scale_records(filters=[tencentcloud.emr.GetAutoScaleRecordsFilterArgs(
            key="StartTime",
            value="2006-01-02 15:04:05",
        )],
        instance_id="emr-bpum4pad")
    ```


    :param Sequence[pulumi.InputType['GetAutoScaleRecordsFilterArgs']] filters: Record filtering parameters, currently only `StartTime`, `EndTime` and `StrategyName` are supported. `StartTime` and `EndTime` support the time format of 2006-01-02 15:04:05 or 2006/01/02 15:04:05.
    :param str instance_id: EMR cluster ID.
    :param str result_output_file: Used to save results.
    """
    ...