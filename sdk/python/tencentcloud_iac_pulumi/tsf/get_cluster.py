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
    'GetClusterResult',
    'AwaitableGetClusterResult',
    'get_cluster',
    'get_cluster_output',
]

@pulumi.output_type
class GetClusterResult:
    """
    A collection of values returned by getCluster.
    """
    def __init__(__self__, cluster_id_lists=None, cluster_type=None, disable_program_auth_check=None, id=None, result_output_file=None, results=None, search_word=None):
        if cluster_id_lists and not isinstance(cluster_id_lists, list):
            raise TypeError("Expected argument 'cluster_id_lists' to be a list")
        pulumi.set(__self__, "cluster_id_lists", cluster_id_lists)
        if cluster_type and not isinstance(cluster_type, str):
            raise TypeError("Expected argument 'cluster_type' to be a str")
        pulumi.set(__self__, "cluster_type", cluster_type)
        if disable_program_auth_check and not isinstance(disable_program_auth_check, bool):
            raise TypeError("Expected argument 'disable_program_auth_check' to be a bool")
        pulumi.set(__self__, "disable_program_auth_check", disable_program_auth_check)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)
        if results and not isinstance(results, list):
            raise TypeError("Expected argument 'results' to be a list")
        pulumi.set(__self__, "results", results)
        if search_word and not isinstance(search_word, str):
            raise TypeError("Expected argument 'search_word' to be a str")
        pulumi.set(__self__, "search_word", search_word)

    @property
    @pulumi.getter(name="clusterIdLists")
    def cluster_id_lists(self) -> Optional[Sequence[str]]:
        return pulumi.get(self, "cluster_id_lists")

    @property
    @pulumi.getter(name="clusterType")
    def cluster_type(self) -> Optional[str]:
        """
        Cluster type. Note: This field may return null, indicating no valid value.
        """
        return pulumi.get(self, "cluster_type")

    @property
    @pulumi.getter(name="disableProgramAuthCheck")
    def disable_program_auth_check(self) -> Optional[bool]:
        return pulumi.get(self, "disable_program_auth_check")

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
    def results(self) -> Sequence['outputs.GetClusterResultResult']:
        """
        TSF cluster pagination object. Note: This field may return null, indicating no valid value.
        """
        return pulumi.get(self, "results")

    @property
    @pulumi.getter(name="searchWord")
    def search_word(self) -> Optional[str]:
        return pulumi.get(self, "search_word")


class AwaitableGetClusterResult(GetClusterResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetClusterResult(
            cluster_id_lists=self.cluster_id_lists,
            cluster_type=self.cluster_type,
            disable_program_auth_check=self.disable_program_auth_check,
            id=self.id,
            result_output_file=self.result_output_file,
            results=self.results,
            search_word=self.search_word)


def get_cluster(cluster_id_lists: Optional[Sequence[str]] = None,
                cluster_type: Optional[str] = None,
                disable_program_auth_check: Optional[bool] = None,
                result_output_file: Optional[str] = None,
                search_word: Optional[str] = None,
                opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetClusterResult:
    """
    Use this data source to query detailed information of tsf cluster

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    cluster = tencentcloud.Tsf.get_cluster(cluster_id_lists=["cluster-vwgj5e6y"],
        cluster_type="V",
        disable_program_auth_check=True)
    ```
    <!--End PulumiCodeChooser -->


    :param Sequence[str] cluster_id_lists: Cluster ID list to be queried, if not filled in or passed, all content will be queried.
    :param str cluster_type: The type of cluster to be queried, if left blank or not passed, all content will be queried. C: container, V: virtual machine.
    :param bool disable_program_auth_check: Whether to disable dataset authentication.
    :param str result_output_file: Used to save results.
    :param str search_word: Filter by keywords for Cluster Id or name.
    """
    __args__ = dict()
    __args__['clusterIdLists'] = cluster_id_lists
    __args__['clusterType'] = cluster_type
    __args__['disableProgramAuthCheck'] = disable_program_auth_check
    __args__['resultOutputFile'] = result_output_file
    __args__['searchWord'] = search_word
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Tsf/getCluster:getCluster', __args__, opts=opts, typ=GetClusterResult).value

    return AwaitableGetClusterResult(
        cluster_id_lists=pulumi.get(__ret__, 'cluster_id_lists'),
        cluster_type=pulumi.get(__ret__, 'cluster_type'),
        disable_program_auth_check=pulumi.get(__ret__, 'disable_program_auth_check'),
        id=pulumi.get(__ret__, 'id'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'),
        results=pulumi.get(__ret__, 'results'),
        search_word=pulumi.get(__ret__, 'search_word'))


@_utilities.lift_output_func(get_cluster)
def get_cluster_output(cluster_id_lists: Optional[pulumi.Input[Optional[Sequence[str]]]] = None,
                       cluster_type: Optional[pulumi.Input[Optional[str]]] = None,
                       disable_program_auth_check: Optional[pulumi.Input[Optional[bool]]] = None,
                       result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                       search_word: Optional[pulumi.Input[Optional[str]]] = None,
                       opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetClusterResult]:
    """
    Use this data source to query detailed information of tsf cluster

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    cluster = tencentcloud.Tsf.get_cluster(cluster_id_lists=["cluster-vwgj5e6y"],
        cluster_type="V",
        disable_program_auth_check=True)
    ```
    <!--End PulumiCodeChooser -->


    :param Sequence[str] cluster_id_lists: Cluster ID list to be queried, if not filled in or passed, all content will be queried.
    :param str cluster_type: The type of cluster to be queried, if left blank or not passed, all content will be queried. C: container, V: virtual machine.
    :param bool disable_program_auth_check: Whether to disable dataset authentication.
    :param str result_output_file: Used to save results.
    :param str search_word: Filter by keywords for Cluster Id or name.
    """
    ...
