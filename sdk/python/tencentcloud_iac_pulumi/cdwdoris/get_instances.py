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
    'GetInstancesResult',
    'AwaitableGetInstancesResult',
    'get_instances',
    'get_instances_output',
]

@pulumi.output_type
class GetInstancesResult:
    """
    A collection of values returned by getInstances.
    """
    def __init__(__self__, id=None, instances_lists=None, result_output_file=None, search_instance_id=None, search_instance_name=None, search_tags=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if instances_lists and not isinstance(instances_lists, list):
            raise TypeError("Expected argument 'instances_lists' to be a list")
        pulumi.set(__self__, "instances_lists", instances_lists)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)
        if search_instance_id and not isinstance(search_instance_id, str):
            raise TypeError("Expected argument 'search_instance_id' to be a str")
        pulumi.set(__self__, "search_instance_id", search_instance_id)
        if search_instance_name and not isinstance(search_instance_name, str):
            raise TypeError("Expected argument 'search_instance_name' to be a str")
        pulumi.set(__self__, "search_instance_name", search_instance_name)
        if search_tags and not isinstance(search_tags, list):
            raise TypeError("Expected argument 'search_tags' to be a list")
        pulumi.set(__self__, "search_tags", search_tags)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="instancesLists")
    def instances_lists(self) -> Sequence['outputs.GetInstancesInstancesListResult']:
        """
        Quantities of instances array.
        """
        return pulumi.get(self, "instances_lists")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")

    @property
    @pulumi.getter(name="searchInstanceId")
    def search_instance_id(self) -> Optional[str]:
        return pulumi.get(self, "search_instance_id")

    @property
    @pulumi.getter(name="searchInstanceName")
    def search_instance_name(self) -> Optional[str]:
        return pulumi.get(self, "search_instance_name")

    @property
    @pulumi.getter(name="searchTags")
    def search_tags(self) -> Optional[Sequence['outputs.GetInstancesSearchTagResult']]:
        return pulumi.get(self, "search_tags")


class AwaitableGetInstancesResult(GetInstancesResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetInstancesResult(
            id=self.id,
            instances_lists=self.instances_lists,
            result_output_file=self.result_output_file,
            search_instance_id=self.search_instance_id,
            search_instance_name=self.search_instance_name,
            search_tags=self.search_tags)


def get_instances(result_output_file: Optional[str] = None,
                  search_instance_id: Optional[str] = None,
                  search_instance_name: Optional[str] = None,
                  search_tags: Optional[Sequence[pulumi.InputType['GetInstancesSearchTagArgs']]] = None,
                  opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetInstancesResult:
    """
    Use this data source to query detailed information of cdwdoris instances

    ## Example Usage

    ### Query all cdwdoris instances

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    example = tencentcloud.Cdwdoris.get_instances()
    ```
    <!--End PulumiCodeChooser -->

    ### Query cdwdoris instances by filter

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    example = tencentcloud.Cdwdoris.get_instances(search_tags=[tencentcloud.cdwdoris.GetInstancesSearchTagArgs(
        all_value=0,
        tag_key="createBy",
        tag_value="Terraform",
    )])
    ```
    <!--End PulumiCodeChooser -->


    :param str result_output_file: Used to save results.
    :param str search_instance_id: The name of the cluster ID for the search.
    :param str search_instance_name: The cluster name for the search.
    :param Sequence[pulumi.InputType['GetInstancesSearchTagArgs']] search_tags: Search tag list.
    """
    __args__ = dict()
    __args__['resultOutputFile'] = result_output_file
    __args__['searchInstanceId'] = search_instance_id
    __args__['searchInstanceName'] = search_instance_name
    __args__['searchTags'] = search_tags
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Cdwdoris/getInstances:getInstances', __args__, opts=opts, typ=GetInstancesResult).value

    return AwaitableGetInstancesResult(
        id=pulumi.get(__ret__, 'id'),
        instances_lists=pulumi.get(__ret__, 'instances_lists'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'),
        search_instance_id=pulumi.get(__ret__, 'search_instance_id'),
        search_instance_name=pulumi.get(__ret__, 'search_instance_name'),
        search_tags=pulumi.get(__ret__, 'search_tags'))


@_utilities.lift_output_func(get_instances)
def get_instances_output(result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                         search_instance_id: Optional[pulumi.Input[Optional[str]]] = None,
                         search_instance_name: Optional[pulumi.Input[Optional[str]]] = None,
                         search_tags: Optional[pulumi.Input[Optional[Sequence[pulumi.InputType['GetInstancesSearchTagArgs']]]]] = None,
                         opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetInstancesResult]:
    """
    Use this data source to query detailed information of cdwdoris instances

    ## Example Usage

    ### Query all cdwdoris instances

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    example = tencentcloud.Cdwdoris.get_instances()
    ```
    <!--End PulumiCodeChooser -->

    ### Query cdwdoris instances by filter

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    example = tencentcloud.Cdwdoris.get_instances(search_tags=[tencentcloud.cdwdoris.GetInstancesSearchTagArgs(
        all_value=0,
        tag_key="createBy",
        tag_value="Terraform",
    )])
    ```
    <!--End PulumiCodeChooser -->


    :param str result_output_file: Used to save results.
    :param str search_instance_id: The name of the cluster ID for the search.
    :param str search_instance_name: The cluster name for the search.
    :param Sequence[pulumi.InputType['GetInstancesSearchTagArgs']] search_tags: Search tag list.
    """
    ...