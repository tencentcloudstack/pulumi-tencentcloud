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
    'GetRouteConflictsResult',
    'AwaitableGetRouteConflictsResult',
    'get_route_conflicts',
    'get_route_conflicts_output',
]

@pulumi.output_type
class GetRouteConflictsResult:
    """
    A collection of values returned by getRouteConflicts.
    """
    def __init__(__self__, destination_cidr_blocks=None, id=None, result_output_file=None, route_conflict_sets=None, route_table_id=None):
        if destination_cidr_blocks and not isinstance(destination_cidr_blocks, list):
            raise TypeError("Expected argument 'destination_cidr_blocks' to be a list")
        pulumi.set(__self__, "destination_cidr_blocks", destination_cidr_blocks)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)
        if route_conflict_sets and not isinstance(route_conflict_sets, list):
            raise TypeError("Expected argument 'route_conflict_sets' to be a list")
        pulumi.set(__self__, "route_conflict_sets", route_conflict_sets)
        if route_table_id and not isinstance(route_table_id, str):
            raise TypeError("Expected argument 'route_table_id' to be a str")
        pulumi.set(__self__, "route_table_id", route_table_id)

    @property
    @pulumi.getter(name="destinationCidrBlocks")
    def destination_cidr_blocks(self) -> Sequence[str]:
        return pulumi.get(self, "destination_cidr_blocks")

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
    @pulumi.getter(name="routeConflictSets")
    def route_conflict_sets(self) -> Sequence['outputs.GetRouteConflictsRouteConflictSetResult']:
        """
        route conflict list.
        """
        return pulumi.get(self, "route_conflict_sets")

    @property
    @pulumi.getter(name="routeTableId")
    def route_table_id(self) -> str:
        """
        route table id.
        """
        return pulumi.get(self, "route_table_id")


class AwaitableGetRouteConflictsResult(GetRouteConflictsResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetRouteConflictsResult(
            destination_cidr_blocks=self.destination_cidr_blocks,
            id=self.id,
            result_output_file=self.result_output_file,
            route_conflict_sets=self.route_conflict_sets,
            route_table_id=self.route_table_id)


def get_route_conflicts(destination_cidr_blocks: Optional[Sequence[str]] = None,
                        result_output_file: Optional[str] = None,
                        route_table_id: Optional[str] = None,
                        opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetRouteConflictsResult:
    """
    Use this data source to query detailed information of vpc route_conflicts

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    route_conflicts = tencentcloud.Vpc.get_route_conflicts(destination_cidr_blocks=["172.18.111.0/24"],
        route_table_id="rtb-6xypllqe")
    ```
    <!--End PulumiCodeChooser -->


    :param Sequence[str] destination_cidr_blocks: List of conflicting destinations to check for.
    :param str result_output_file: Used to save results.
    :param str route_table_id: Routing table instance ID, for example:rtb-azd4dt1c.
    """
    __args__ = dict()
    __args__['destinationCidrBlocks'] = destination_cidr_blocks
    __args__['resultOutputFile'] = result_output_file
    __args__['routeTableId'] = route_table_id
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Vpc/getRouteConflicts:getRouteConflicts', __args__, opts=opts, typ=GetRouteConflictsResult).value

    return AwaitableGetRouteConflictsResult(
        destination_cidr_blocks=pulumi.get(__ret__, 'destination_cidr_blocks'),
        id=pulumi.get(__ret__, 'id'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'),
        route_conflict_sets=pulumi.get(__ret__, 'route_conflict_sets'),
        route_table_id=pulumi.get(__ret__, 'route_table_id'))


@_utilities.lift_output_func(get_route_conflicts)
def get_route_conflicts_output(destination_cidr_blocks: Optional[pulumi.Input[Sequence[str]]] = None,
                               result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                               route_table_id: Optional[pulumi.Input[str]] = None,
                               opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetRouteConflictsResult]:
    """
    Use this data source to query detailed information of vpc route_conflicts

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    route_conflicts = tencentcloud.Vpc.get_route_conflicts(destination_cidr_blocks=["172.18.111.0/24"],
        route_table_id="rtb-6xypllqe")
    ```
    <!--End PulumiCodeChooser -->


    :param Sequence[str] destination_cidr_blocks: List of conflicting destinations to check for.
    :param str result_output_file: Used to save results.
    :param str route_table_id: Routing table instance ID, for example:rtb-azd4dt1c.
    """
    ...
