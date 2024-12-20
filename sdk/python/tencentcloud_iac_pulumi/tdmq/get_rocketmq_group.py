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
    'GetRocketmqGroupResult',
    'AwaitableGetRocketmqGroupResult',
    'get_rocketmq_group',
    'get_rocketmq_group_output',
]

@pulumi.output_type
class GetRocketmqGroupResult:
    """
    A collection of values returned by getRocketmqGroup.
    """
    def __init__(__self__, cluster_id=None, filter_group=None, filter_one_group=None, filter_topic=None, groups=None, id=None, namespace_id=None, result_output_file=None):
        if cluster_id and not isinstance(cluster_id, str):
            raise TypeError("Expected argument 'cluster_id' to be a str")
        pulumi.set(__self__, "cluster_id", cluster_id)
        if filter_group and not isinstance(filter_group, str):
            raise TypeError("Expected argument 'filter_group' to be a str")
        pulumi.set(__self__, "filter_group", filter_group)
        if filter_one_group and not isinstance(filter_one_group, str):
            raise TypeError("Expected argument 'filter_one_group' to be a str")
        pulumi.set(__self__, "filter_one_group", filter_one_group)
        if filter_topic and not isinstance(filter_topic, str):
            raise TypeError("Expected argument 'filter_topic' to be a str")
        pulumi.set(__self__, "filter_topic", filter_topic)
        if groups and not isinstance(groups, list):
            raise TypeError("Expected argument 'groups' to be a list")
        pulumi.set(__self__, "groups", groups)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if namespace_id and not isinstance(namespace_id, str):
            raise TypeError("Expected argument 'namespace_id' to be a str")
        pulumi.set(__self__, "namespace_id", namespace_id)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)

    @property
    @pulumi.getter(name="clusterId")
    def cluster_id(self) -> str:
        return pulumi.get(self, "cluster_id")

    @property
    @pulumi.getter(name="filterGroup")
    def filter_group(self) -> Optional[str]:
        return pulumi.get(self, "filter_group")

    @property
    @pulumi.getter(name="filterOneGroup")
    def filter_one_group(self) -> Optional[str]:
        return pulumi.get(self, "filter_one_group")

    @property
    @pulumi.getter(name="filterTopic")
    def filter_topic(self) -> Optional[str]:
        return pulumi.get(self, "filter_topic")

    @property
    @pulumi.getter
    def groups(self) -> Sequence['outputs.GetRocketmqGroupGroupResult']:
        """
        List of subscription groups.
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
    @pulumi.getter(name="namespaceId")
    def namespace_id(self) -> str:
        return pulumi.get(self, "namespace_id")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")


class AwaitableGetRocketmqGroupResult(GetRocketmqGroupResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetRocketmqGroupResult(
            cluster_id=self.cluster_id,
            filter_group=self.filter_group,
            filter_one_group=self.filter_one_group,
            filter_topic=self.filter_topic,
            groups=self.groups,
            id=self.id,
            namespace_id=self.namespace_id,
            result_output_file=self.result_output_file)


def get_rocketmq_group(cluster_id: Optional[str] = None,
                       filter_group: Optional[str] = None,
                       filter_one_group: Optional[str] = None,
                       filter_topic: Optional[str] = None,
                       namespace_id: Optional[str] = None,
                       result_output_file: Optional[str] = None,
                       opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetRocketmqGroupResult:
    """
    Use this data source to query detailed information of tdmqRocketmq group

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud
    import tencentcloud_iac_pulumi as tencentcloud

    example_rocketmq_cluster = tencentcloud.tdmq.RocketmqCluster("exampleRocketmqCluster",
        cluster_name="tf_example",
        remark="remark.")
    example_rocketmq_namespace = tencentcloud.tdmq.RocketmqNamespace("exampleRocketmqNamespace",
        cluster_id=example_rocketmq_cluster.cluster_id,
        namespace_name="tf_example",
        remark="remark.")
    example_rocketmq_group = tencentcloud.Tdmq.get_rocketmq_group_output(cluster_id=example_rocketmq_cluster.cluster_id,
        namespace_id=example_rocketmq_namespace.namespace_name,
        filter_group=example_tdmq / rocketmq_group_rocketmq_group["groupName"])
    example_tdmq_rocketmq_group_rocketmq_group = tencentcloud.tdmq.RocketmqGroup("exampleTdmq/rocketmqGroupRocketmqGroup",
        group_name="tf_example",
        namespace=example_rocketmq_namespace.namespace_name,
        read_enable=True,
        broadcast_enable=True,
        cluster_id=example_rocketmq_cluster.cluster_id,
        remark="remark.")
    ```
    <!--End PulumiCodeChooser -->


    :param str cluster_id: Cluster ID.
    :param str filter_group: Consumer group query by consumer group name. Fuzzy query is supported.
    :param str filter_one_group: Subscription group name. After it is specified, the information of only this subscription group will be returned.
    :param str filter_topic: Topic name, which can be used to query all subscription groups under the topic.
    :param str namespace_id: Namespace.
    :param str result_output_file: Used to save results.
    """
    __args__ = dict()
    __args__['clusterId'] = cluster_id
    __args__['filterGroup'] = filter_group
    __args__['filterOneGroup'] = filter_one_group
    __args__['filterTopic'] = filter_topic
    __args__['namespaceId'] = namespace_id
    __args__['resultOutputFile'] = result_output_file
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Tdmq/getRocketmqGroup:getRocketmqGroup', __args__, opts=opts, typ=GetRocketmqGroupResult).value

    return AwaitableGetRocketmqGroupResult(
        cluster_id=pulumi.get(__ret__, 'cluster_id'),
        filter_group=pulumi.get(__ret__, 'filter_group'),
        filter_one_group=pulumi.get(__ret__, 'filter_one_group'),
        filter_topic=pulumi.get(__ret__, 'filter_topic'),
        groups=pulumi.get(__ret__, 'groups'),
        id=pulumi.get(__ret__, 'id'),
        namespace_id=pulumi.get(__ret__, 'namespace_id'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'))


@_utilities.lift_output_func(get_rocketmq_group)
def get_rocketmq_group_output(cluster_id: Optional[pulumi.Input[str]] = None,
                              filter_group: Optional[pulumi.Input[Optional[str]]] = None,
                              filter_one_group: Optional[pulumi.Input[Optional[str]]] = None,
                              filter_topic: Optional[pulumi.Input[Optional[str]]] = None,
                              namespace_id: Optional[pulumi.Input[str]] = None,
                              result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                              opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetRocketmqGroupResult]:
    """
    Use this data source to query detailed information of tdmqRocketmq group

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud
    import tencentcloud_iac_pulumi as tencentcloud

    example_rocketmq_cluster = tencentcloud.tdmq.RocketmqCluster("exampleRocketmqCluster",
        cluster_name="tf_example",
        remark="remark.")
    example_rocketmq_namespace = tencentcloud.tdmq.RocketmqNamespace("exampleRocketmqNamespace",
        cluster_id=example_rocketmq_cluster.cluster_id,
        namespace_name="tf_example",
        remark="remark.")
    example_rocketmq_group = tencentcloud.Tdmq.get_rocketmq_group_output(cluster_id=example_rocketmq_cluster.cluster_id,
        namespace_id=example_rocketmq_namespace.namespace_name,
        filter_group=example_tdmq / rocketmq_group_rocketmq_group["groupName"])
    example_tdmq_rocketmq_group_rocketmq_group = tencentcloud.tdmq.RocketmqGroup("exampleTdmq/rocketmqGroupRocketmqGroup",
        group_name="tf_example",
        namespace=example_rocketmq_namespace.namespace_name,
        read_enable=True,
        broadcast_enable=True,
        cluster_id=example_rocketmq_cluster.cluster_id,
        remark="remark.")
    ```
    <!--End PulumiCodeChooser -->


    :param str cluster_id: Cluster ID.
    :param str filter_group: Consumer group query by consumer group name. Fuzzy query is supported.
    :param str filter_one_group: Subscription group name. After it is specified, the information of only this subscription group will be returned.
    :param str filter_topic: Topic name, which can be used to query all subscription groups under the topic.
    :param str namespace_id: Namespace.
    :param str result_output_file: Used to save results.
    """
    ...
