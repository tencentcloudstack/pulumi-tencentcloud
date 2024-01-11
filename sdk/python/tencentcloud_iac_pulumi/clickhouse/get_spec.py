# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs

__all__ = [
    'GetSpecResult',
    'AwaitableGetSpecResult',
    'get_spec',
    'get_spec_output',
]

@pulumi.output_type
class GetSpecResult:
    """
    A collection of values returned by getSpec.
    """
    def __init__(__self__, attach_cbs_specs=None, common_specs=None, data_specs=None, id=None, is_elastic=None, pay_mode=None, result_output_file=None, zone=None):
        if attach_cbs_specs and not isinstance(attach_cbs_specs, list):
            raise TypeError("Expected argument 'attach_cbs_specs' to be a list")
        pulumi.set(__self__, "attach_cbs_specs", attach_cbs_specs)
        if common_specs and not isinstance(common_specs, list):
            raise TypeError("Expected argument 'common_specs' to be a list")
        pulumi.set(__self__, "common_specs", common_specs)
        if data_specs and not isinstance(data_specs, list):
            raise TypeError("Expected argument 'data_specs' to be a list")
        pulumi.set(__self__, "data_specs", data_specs)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if is_elastic and not isinstance(is_elastic, bool):
            raise TypeError("Expected argument 'is_elastic' to be a bool")
        pulumi.set(__self__, "is_elastic", is_elastic)
        if pay_mode and not isinstance(pay_mode, str):
            raise TypeError("Expected argument 'pay_mode' to be a str")
        pulumi.set(__self__, "pay_mode", pay_mode)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)
        if zone and not isinstance(zone, str):
            raise TypeError("Expected argument 'zone' to be a str")
        pulumi.set(__self__, "zone", zone)

    @property
    @pulumi.getter(name="attachCbsSpecs")
    def attach_cbs_specs(self) -> Sequence['outputs.GetSpecAttachCbsSpecResult']:
        """
        Cloud disk list.
        """
        return pulumi.get(self, "attach_cbs_specs")

    @property
    @pulumi.getter(name="commonSpecs")
    def common_specs(self) -> Sequence['outputs.GetSpecCommonSpecResult']:
        """
        Zookeeper node specification description.
        """
        return pulumi.get(self, "common_specs")

    @property
    @pulumi.getter(name="dataSpecs")
    def data_specs(self) -> Sequence['outputs.GetSpecDataSpecResult']:
        """
        Data node specification description.
        """
        return pulumi.get(self, "data_specs")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="isElastic")
    def is_elastic(self) -> Optional[bool]:
        return pulumi.get(self, "is_elastic")

    @property
    @pulumi.getter(name="payMode")
    def pay_mode(self) -> Optional[str]:
        return pulumi.get(self, "pay_mode")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")

    @property
    @pulumi.getter
    def zone(self) -> str:
        return pulumi.get(self, "zone")


class AwaitableGetSpecResult(GetSpecResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetSpecResult(
            attach_cbs_specs=self.attach_cbs_specs,
            common_specs=self.common_specs,
            data_specs=self.data_specs,
            id=self.id,
            is_elastic=self.is_elastic,
            pay_mode=self.pay_mode,
            result_output_file=self.result_output_file,
            zone=self.zone)


def get_spec(is_elastic: Optional[bool] = None,
             pay_mode: Optional[str] = None,
             result_output_file: Optional[str] = None,
             zone: Optional[str] = None,
             opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetSpecResult:
    """
    Use this data source to query detailed information of clickhouse spec

    ## Example Usage

    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    spec = tencentcloud.Clickhouse.get_spec(is_elastic=False,
        pay_mode="PREPAID",
        zone="ap-guangzhou-7")
    ```


    :param bool is_elastic: Is it elastic.
    :param str pay_mode: Billing type, PREPAID means annual and monthly subscription, POSTPAID_BY_HOUR means pay-as-you-go billing.
    :param str result_output_file: Used to save results.
    :param str zone: Regional information.
    """
    __args__ = dict()
    __args__['isElastic'] = is_elastic
    __args__['payMode'] = pay_mode
    __args__['resultOutputFile'] = result_output_file
    __args__['zone'] = zone
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
        if opts.plugin_download_url is None:
            opts.plugin_download_url = _utilities.get_plugin_download_url()
    __ret__ = pulumi.runtime.invoke('tencentcloud:Clickhouse/getSpec:getSpec', __args__, opts=opts, typ=GetSpecResult).value

    return AwaitableGetSpecResult(
        attach_cbs_specs=__ret__.attach_cbs_specs,
        common_specs=__ret__.common_specs,
        data_specs=__ret__.data_specs,
        id=__ret__.id,
        is_elastic=__ret__.is_elastic,
        pay_mode=__ret__.pay_mode,
        result_output_file=__ret__.result_output_file,
        zone=__ret__.zone)


@_utilities.lift_output_func(get_spec)
def get_spec_output(is_elastic: Optional[pulumi.Input[Optional[bool]]] = None,
                    pay_mode: Optional[pulumi.Input[Optional[str]]] = None,
                    result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                    zone: Optional[pulumi.Input[str]] = None,
                    opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetSpecResult]:
    """
    Use this data source to query detailed information of clickhouse spec

    ## Example Usage

    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    spec = tencentcloud.Clickhouse.get_spec(is_elastic=False,
        pay_mode="PREPAID",
        zone="ap-guangzhou-7")
    ```


    :param bool is_elastic: Is it elastic.
    :param str pay_mode: Billing type, PREPAID means annual and monthly subscription, POSTPAID_BY_HOUR means pay-as-you-go billing.
    :param str result_output_file: Used to save results.
    :param str zone: Regional information.
    """
    ...