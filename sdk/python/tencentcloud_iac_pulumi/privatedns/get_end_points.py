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
from ._inputs import *

__all__ = [
    'GetEndPointsResult',
    'AwaitableGetEndPointsResult',
    'get_end_points',
    'get_end_points_output',
]

@pulumi.output_type
class GetEndPointsResult:
    """
    A collection of values returned by getEndPoints.
    """
    def __init__(__self__, end_point_sets=None, filters=None, id=None, result_output_file=None):
        if end_point_sets and not isinstance(end_point_sets, list):
            raise TypeError("Expected argument 'end_point_sets' to be a list")
        pulumi.set(__self__, "end_point_sets", end_point_sets)
        if filters and not isinstance(filters, list):
            raise TypeError("Expected argument 'filters' to be a list")
        pulumi.set(__self__, "filters", filters)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)

    @property
    @pulumi.getter(name="endPointSets")
    def end_point_sets(self) -> Sequence['outputs.GetEndPointsEndPointSetResult']:
        """
        Endpoint list.
        Note: This field may return null, indicating that no valid values can be obtained.
        """
        return pulumi.get(self, "end_point_sets")

    @property
    @pulumi.getter
    def filters(self) -> Optional[Sequence['outputs.GetEndPointsFilterResult']]:
        return pulumi.get(self, "filters")

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


class AwaitableGetEndPointsResult(GetEndPointsResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetEndPointsResult(
            end_point_sets=self.end_point_sets,
            filters=self.filters,
            id=self.id,
            result_output_file=self.result_output_file)


def get_end_points(filters: Optional[Sequence[pulumi.InputType['GetEndPointsFilterArgs']]] = None,
                   result_output_file: Optional[str] = None,
                   opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetEndPointsResult:
    """
    Use this data source to query detailed information of private dns dns end points

    ## Example Usage

    ### Query all private dns end points

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    example = tencentcloud.PrivateDns.get_end_points()
    ```
    <!--End PulumiCodeChooser -->

    ### Query all private dns end points by filters

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    example = tencentcloud.PrivateDns.get_end_points(filters=[
        tencentcloud.private_dns.GetEndPointsFilterArgs(
            name="EndPointName",
            values=["tf-example"],
        ),
        tencentcloud.private_dns.GetEndPointsFilterArgs(
            name="EndPointId",
            values=["eid-72dc11b8f3"],
        ),
        tencentcloud.private_dns.GetEndPointsFilterArgs(
            name="EndPointServiceId",
            values=["vpcsvc-61wcwmar"],
        ),
        tencentcloud.private_dns.GetEndPointsFilterArgs(
            name="EndPointVip",
            values=["172.10.10.1"],
        ),
    ])
    ```
    <!--End PulumiCodeChooser -->


    :param Sequence[pulumi.InputType['GetEndPointsFilterArgs']] filters: Filter parameters. Valid values: EndPointName, EndPointId, EndPointServiceId, and EndPointVip.
    :param str result_output_file: Used to save results.
    """
    __args__ = dict()
    __args__['filters'] = filters
    __args__['resultOutputFile'] = result_output_file
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:PrivateDns/getEndPoints:getEndPoints', __args__, opts=opts, typ=GetEndPointsResult).value

    return AwaitableGetEndPointsResult(
        end_point_sets=pulumi.get(__ret__, 'end_point_sets'),
        filters=pulumi.get(__ret__, 'filters'),
        id=pulumi.get(__ret__, 'id'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'))


@_utilities.lift_output_func(get_end_points)
def get_end_points_output(filters: Optional[pulumi.Input[Optional[Sequence[pulumi.InputType['GetEndPointsFilterArgs']]]]] = None,
                          result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                          opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetEndPointsResult]:
    """
    Use this data source to query detailed information of private dns dns end points

    ## Example Usage

    ### Query all private dns end points

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    example = tencentcloud.PrivateDns.get_end_points()
    ```
    <!--End PulumiCodeChooser -->

    ### Query all private dns end points by filters

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    example = tencentcloud.PrivateDns.get_end_points(filters=[
        tencentcloud.private_dns.GetEndPointsFilterArgs(
            name="EndPointName",
            values=["tf-example"],
        ),
        tencentcloud.private_dns.GetEndPointsFilterArgs(
            name="EndPointId",
            values=["eid-72dc11b8f3"],
        ),
        tencentcloud.private_dns.GetEndPointsFilterArgs(
            name="EndPointServiceId",
            values=["vpcsvc-61wcwmar"],
        ),
        tencentcloud.private_dns.GetEndPointsFilterArgs(
            name="EndPointVip",
            values=["172.10.10.1"],
        ),
    ])
    ```
    <!--End PulumiCodeChooser -->


    :param Sequence[pulumi.InputType['GetEndPointsFilterArgs']] filters: Filter parameters. Valid values: EndPointName, EndPointId, EndPointServiceId, and EndPointVip.
    :param str result_output_file: Used to save results.
    """
    ...