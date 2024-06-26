# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs

__all__ = [
    'GetTmpRegionsResult',
    'AwaitableGetTmpRegionsResult',
    'get_tmp_regions',
    'get_tmp_regions_output',
]

@pulumi.output_type
class GetTmpRegionsResult:
    """
    A collection of values returned by getTmpRegions.
    """
    def __init__(__self__, id=None, pay_mode=None, region_sets=None, result_output_file=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if pay_mode and not isinstance(pay_mode, int):
            raise TypeError("Expected argument 'pay_mode' to be a int")
        pulumi.set(__self__, "pay_mode", pay_mode)
        if region_sets and not isinstance(region_sets, list):
            raise TypeError("Expected argument 'region_sets' to be a list")
        pulumi.set(__self__, "region_sets", region_sets)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="payMode")
    def pay_mode(self) -> Optional[int]:
        return pulumi.get(self, "pay_mode")

    @property
    @pulumi.getter(name="regionSets")
    def region_sets(self) -> Sequence['outputs.GetTmpRegionsRegionSetResult']:
        """
        Region set.
        """
        return pulumi.get(self, "region_sets")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")


class AwaitableGetTmpRegionsResult(GetTmpRegionsResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetTmpRegionsResult(
            id=self.id,
            pay_mode=self.pay_mode,
            region_sets=self.region_sets,
            result_output_file=self.result_output_file)


def get_tmp_regions(pay_mode: Optional[int] = None,
                    result_output_file: Optional[str] = None,
                    opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetTmpRegionsResult:
    """
    Use this data source to query detailed information of monitor tmp_regions

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    tmp_regions = tencentcloud.Monitor.get_tmp_regions(pay_mode=1)
    ```
    <!--End PulumiCodeChooser -->


    :param int pay_mode: Pay mode. `1`-Prepaid, `2`-Postpaid, `3`-All regions (default is all regions if not filled in).
    :param str result_output_file: Used to save results.
    """
    __args__ = dict()
    __args__['payMode'] = pay_mode
    __args__['resultOutputFile'] = result_output_file
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Monitor/getTmpRegions:getTmpRegions', __args__, opts=opts, typ=GetTmpRegionsResult).value

    return AwaitableGetTmpRegionsResult(
        id=pulumi.get(__ret__, 'id'),
        pay_mode=pulumi.get(__ret__, 'pay_mode'),
        region_sets=pulumi.get(__ret__, 'region_sets'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'))


@_utilities.lift_output_func(get_tmp_regions)
def get_tmp_regions_output(pay_mode: Optional[pulumi.Input[Optional[int]]] = None,
                           result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                           opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetTmpRegionsResult]:
    """
    Use this data source to query detailed information of monitor tmp_regions

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    tmp_regions = tencentcloud.Monitor.get_tmp_regions(pay_mode=1)
    ```
    <!--End PulumiCodeChooser -->


    :param int pay_mode: Pay mode. `1`-Prepaid, `2`-Postpaid, `3`-All regions (default is all regions if not filled in).
    :param str result_output_file: Used to save results.
    """
    ...
