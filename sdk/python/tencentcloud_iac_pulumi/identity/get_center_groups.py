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
    'GetCenterGroupsResult',
    'AwaitableGetCenterGroupsResult',
    'get_center_groups',
    'get_center_groups_output',
]

@pulumi.output_type
class GetCenterGroupsResult:
    """
    A collection of values returned by getCenterGroups.
    """
    def __init__(__self__, filter=None, filter_users=None, group_type=None, groups=None, id=None, result_output_file=None, sort_field=None, sort_type=None, zone_id=None):
        if filter and not isinstance(filter, str):
            raise TypeError("Expected argument 'filter' to be a str")
        pulumi.set(__self__, "filter", filter)
        if filter_users and not isinstance(filter_users, list):
            raise TypeError("Expected argument 'filter_users' to be a list")
        pulumi.set(__self__, "filter_users", filter_users)
        if group_type and not isinstance(group_type, str):
            raise TypeError("Expected argument 'group_type' to be a str")
        pulumi.set(__self__, "group_type", group_type)
        if groups and not isinstance(groups, list):
            raise TypeError("Expected argument 'groups' to be a list")
        pulumi.set(__self__, "groups", groups)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)
        if sort_field and not isinstance(sort_field, str):
            raise TypeError("Expected argument 'sort_field' to be a str")
        pulumi.set(__self__, "sort_field", sort_field)
        if sort_type and not isinstance(sort_type, str):
            raise TypeError("Expected argument 'sort_type' to be a str")
        pulumi.set(__self__, "sort_type", sort_type)
        if zone_id and not isinstance(zone_id, str):
            raise TypeError("Expected argument 'zone_id' to be a str")
        pulumi.set(__self__, "zone_id", zone_id)

    @property
    @pulumi.getter
    def filter(self) -> Optional[str]:
        return pulumi.get(self, "filter")

    @property
    @pulumi.getter(name="filterUsers")
    def filter_users(self) -> Optional[Sequence[str]]:
        return pulumi.get(self, "filter_users")

    @property
    @pulumi.getter(name="groupType")
    def group_type(self) -> Optional[str]:
        return pulumi.get(self, "group_type")

    @property
    @pulumi.getter
    def groups(self) -> Sequence['outputs.GetCenterGroupsGroupResult']:
        """
        User group list.
        """
        return pulumi.get(self, "groups")

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
    @pulumi.getter(name="sortField")
    def sort_field(self) -> Optional[str]:
        return pulumi.get(self, "sort_field")

    @property
    @pulumi.getter(name="sortType")
    def sort_type(self) -> Optional[str]:
        return pulumi.get(self, "sort_type")

    @property
    @pulumi.getter(name="zoneId")
    def zone_id(self) -> str:
        return pulumi.get(self, "zone_id")


class AwaitableGetCenterGroupsResult(GetCenterGroupsResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetCenterGroupsResult(
            filter=self.filter,
            filter_users=self.filter_users,
            group_type=self.group_type,
            groups=self.groups,
            id=self.id,
            result_output_file=self.result_output_file,
            sort_field=self.sort_field,
            sort_type=self.sort_type,
            zone_id=self.zone_id)


def get_center_groups(filter: Optional[str] = None,
                      filter_users: Optional[Sequence[str]] = None,
                      group_type: Optional[str] = None,
                      result_output_file: Optional[str] = None,
                      sort_field: Optional[str] = None,
                      sort_type: Optional[str] = None,
                      zone_id: Optional[str] = None,
                      opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetCenterGroupsResult:
    """
    Use this data source to query detailed information of identity center groups

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    identity_center_groups = tencentcloud.Identity.get_center_groups(zone_id="z-xxxxxx")
    ```
    <!--End PulumiCodeChooser -->


    :param str filter: Filter criterion. Format: <Attribute> <Operator> <Value>, case-insensitive. Currently, <Attribute> supports only GroupName, and <Operator> supports only eq (Equals) and sw (Start With). For example, Filter = "GroupName sw test" indicates querying all user groups with names starting with test; Filter = "GroupName eq testgroup" indicates querying the user group with the name testgroup.
    :param Sequence[str] filter_users: Filtered user. IsSelected=1 will be returned for the user group associated with this user.
    :param str group_type: User group type. Manual: manually created; Synchronized: externally imported.
    :param str result_output_file: Used to save results.
    :param str sort_field: Sorting field, which currently only supports CreateTime. The default is the CreateTime field.
    :param str sort_type: Sorting type. Desc: descending order; Asc: ascending order. It should be set along with SortField.
    :param str zone_id: Space ID.
    """
    __args__ = dict()
    __args__['filter'] = filter
    __args__['filterUsers'] = filter_users
    __args__['groupType'] = group_type
    __args__['resultOutputFile'] = result_output_file
    __args__['sortField'] = sort_field
    __args__['sortType'] = sort_type
    __args__['zoneId'] = zone_id
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Identity/getCenterGroups:getCenterGroups', __args__, opts=opts, typ=GetCenterGroupsResult).value

    return AwaitableGetCenterGroupsResult(
        filter=pulumi.get(__ret__, 'filter'),
        filter_users=pulumi.get(__ret__, 'filter_users'),
        group_type=pulumi.get(__ret__, 'group_type'),
        groups=pulumi.get(__ret__, 'groups'),
        id=pulumi.get(__ret__, 'id'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'),
        sort_field=pulumi.get(__ret__, 'sort_field'),
        sort_type=pulumi.get(__ret__, 'sort_type'),
        zone_id=pulumi.get(__ret__, 'zone_id'))


@_utilities.lift_output_func(get_center_groups)
def get_center_groups_output(filter: Optional[pulumi.Input[Optional[str]]] = None,
                             filter_users: Optional[pulumi.Input[Optional[Sequence[str]]]] = None,
                             group_type: Optional[pulumi.Input[Optional[str]]] = None,
                             result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                             sort_field: Optional[pulumi.Input[Optional[str]]] = None,
                             sort_type: Optional[pulumi.Input[Optional[str]]] = None,
                             zone_id: Optional[pulumi.Input[str]] = None,
                             opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetCenterGroupsResult]:
    """
    Use this data source to query detailed information of identity center groups

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    identity_center_groups = tencentcloud.Identity.get_center_groups(zone_id="z-xxxxxx")
    ```
    <!--End PulumiCodeChooser -->


    :param str filter: Filter criterion. Format: <Attribute> <Operator> <Value>, case-insensitive. Currently, <Attribute> supports only GroupName, and <Operator> supports only eq (Equals) and sw (Start With). For example, Filter = "GroupName sw test" indicates querying all user groups with names starting with test; Filter = "GroupName eq testgroup" indicates querying the user group with the name testgroup.
    :param Sequence[str] filter_users: Filtered user. IsSelected=1 will be returned for the user group associated with this user.
    :param str group_type: User group type. Manual: manually created; Synchronized: externally imported.
    :param str result_output_file: Used to save results.
    :param str sort_field: Sorting field, which currently only supports CreateTime. The default is the CreateTime field.
    :param str sort_type: Sorting type. Desc: descending order; Asc: ascending order. It should be set along with SortField.
    :param str zone_id: Space ID.
    """
    ...