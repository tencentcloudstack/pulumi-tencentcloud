# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = [
    'GetInstanceSlowLogResult',
    'AwaitableGetInstanceSlowLogResult',
    'get_instance_slow_log',
    'get_instance_slow_log_output',
]

@pulumi.output_type
class GetInstanceSlowLogResult:
    """
    A collection of values returned by getInstanceSlowLog.
    """
    def __init__(__self__, end_time=None, format=None, id=None, instance_id=None, result_output_file=None, slow_logs=None, slow_ms=None, start_time=None):
        if end_time and not isinstance(end_time, str):
            raise TypeError("Expected argument 'end_time' to be a str")
        pulumi.set(__self__, "end_time", end_time)
        if format and not isinstance(format, str):
            raise TypeError("Expected argument 'format' to be a str")
        pulumi.set(__self__, "format", format)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if instance_id and not isinstance(instance_id, str):
            raise TypeError("Expected argument 'instance_id' to be a str")
        pulumi.set(__self__, "instance_id", instance_id)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)
        if slow_logs and not isinstance(slow_logs, list):
            raise TypeError("Expected argument 'slow_logs' to be a list")
        pulumi.set(__self__, "slow_logs", slow_logs)
        if slow_ms and not isinstance(slow_ms, int):
            raise TypeError("Expected argument 'slow_ms' to be a int")
        pulumi.set(__self__, "slow_ms", slow_ms)
        if start_time and not isinstance(start_time, str):
            raise TypeError("Expected argument 'start_time' to be a str")
        pulumi.set(__self__, "start_time", start_time)

    @property
    @pulumi.getter(name="endTime")
    def end_time(self) -> str:
        return pulumi.get(self, "end_time")

    @property
    @pulumi.getter
    def format(self) -> Optional[str]:
        return pulumi.get(self, "format")

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
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")

    @property
    @pulumi.getter(name="slowLogs")
    def slow_logs(self) -> Sequence[str]:
        """
        details of slow logs.
        """
        return pulumi.get(self, "slow_logs")

    @property
    @pulumi.getter(name="slowMs")
    def slow_ms(self) -> int:
        return pulumi.get(self, "slow_ms")

    @property
    @pulumi.getter(name="startTime")
    def start_time(self) -> str:
        return pulumi.get(self, "start_time")


class AwaitableGetInstanceSlowLogResult(GetInstanceSlowLogResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetInstanceSlowLogResult(
            end_time=self.end_time,
            format=self.format,
            id=self.id,
            instance_id=self.instance_id,
            result_output_file=self.result_output_file,
            slow_logs=self.slow_logs,
            slow_ms=self.slow_ms,
            start_time=self.start_time)


def get_instance_slow_log(end_time: Optional[str] = None,
                          format: Optional[str] = None,
                          instance_id: Optional[str] = None,
                          result_output_file: Optional[str] = None,
                          slow_ms: Optional[int] = None,
                          start_time: Optional[str] = None,
                          opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetInstanceSlowLogResult:
    """
    Use this data source to query detailed information of mongodb instance_slow_log

    ## Example Usage

    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    instance_slow_log = tencentcloud.Mongodb.get_instance_slow_log(end_time="2019-06-02 12:00:00",
        format="json",
        instance_id="cmgo-9d0p6umb",
        slow_ms=100,
        start_time="2019-06-01 10:00:00")
    ```


    :param str end_time: Slow log termination time, format: yyyy-mm-dd hh:mm:ss, such as: 2019-06-02 12:00:00.The time interval between the start and end of the query cannot exceed 24 hours,and only slow logs within the last 7 days are allowed to be queried.
    :param str format: Slow log return format. By default, the original slow log format is returned,and versions 4.4 and above can be set to json.
    :param str instance_id: Instance ID, the format is: cmgo-9d0p6umb.Same as the instance ID displayed in the cloud database console page.
    :param str result_output_file: Used to save results.
    :param int slow_ms: Slow log execution time threshold, return slow logs whose execution time exceeds this threshold,the unit is milliseconds (ms), and the minimum is 100 milliseconds.
    :param str start_time: Slow log start time, format: yyyy-mm-dd hh:mm:ss, such as: 2019-06-01 10:00:00. The time intervalbetween the start and end of the query cannot exceed 24 hours,and only slow logs within the last 7 days are allowed to be queried.
    """
    __args__ = dict()
    __args__['endTime'] = end_time
    __args__['format'] = format
    __args__['instanceId'] = instance_id
    __args__['resultOutputFile'] = result_output_file
    __args__['slowMs'] = slow_ms
    __args__['startTime'] = start_time
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
        if opts.plugin_download_url is None:
            opts.plugin_download_url = _utilities.get_plugin_download_url()
    __ret__ = pulumi.runtime.invoke('tencentcloud:Mongodb/getInstanceSlowLog:getInstanceSlowLog', __args__, opts=opts, typ=GetInstanceSlowLogResult).value

    return AwaitableGetInstanceSlowLogResult(
        end_time=__ret__.end_time,
        format=__ret__.format,
        id=__ret__.id,
        instance_id=__ret__.instance_id,
        result_output_file=__ret__.result_output_file,
        slow_logs=__ret__.slow_logs,
        slow_ms=__ret__.slow_ms,
        start_time=__ret__.start_time)


@_utilities.lift_output_func(get_instance_slow_log)
def get_instance_slow_log_output(end_time: Optional[pulumi.Input[str]] = None,
                                 format: Optional[pulumi.Input[Optional[str]]] = None,
                                 instance_id: Optional[pulumi.Input[str]] = None,
                                 result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                                 slow_ms: Optional[pulumi.Input[int]] = None,
                                 start_time: Optional[pulumi.Input[str]] = None,
                                 opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetInstanceSlowLogResult]:
    """
    Use this data source to query detailed information of mongodb instance_slow_log

    ## Example Usage

    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    instance_slow_log = tencentcloud.Mongodb.get_instance_slow_log(end_time="2019-06-02 12:00:00",
        format="json",
        instance_id="cmgo-9d0p6umb",
        slow_ms=100,
        start_time="2019-06-01 10:00:00")
    ```


    :param str end_time: Slow log termination time, format: yyyy-mm-dd hh:mm:ss, such as: 2019-06-02 12:00:00.The time interval between the start and end of the query cannot exceed 24 hours,and only slow logs within the last 7 days are allowed to be queried.
    :param str format: Slow log return format. By default, the original slow log format is returned,and versions 4.4 and above can be set to json.
    :param str instance_id: Instance ID, the format is: cmgo-9d0p6umb.Same as the instance ID displayed in the cloud database console page.
    :param str result_output_file: Used to save results.
    :param int slow_ms: Slow log execution time threshold, return slow logs whose execution time exceeds this threshold,the unit is milliseconds (ms), and the minimum is 100 milliseconds.
    :param str start_time: Slow log start time, format: yyyy-mm-dd hh:mm:ss, such as: 2019-06-01 10:00:00. The time intervalbetween the start and end of the query cannot exceed 24 hours,and only slow logs within the last 7 days are allowed to be queried.
    """
    ...