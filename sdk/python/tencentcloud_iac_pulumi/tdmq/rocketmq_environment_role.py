# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['RocketmqEnvironmentRoleArgs', 'RocketmqEnvironmentRole']

@pulumi.input_type
class RocketmqEnvironmentRoleArgs:
    def __init__(__self__, *,
                 cluster_id: pulumi.Input[str],
                 environment_name: pulumi.Input[str],
                 permissions: pulumi.Input[Sequence[pulumi.Input[str]]],
                 role_name: pulumi.Input[str]):
        """
        The set of arguments for constructing a RocketmqEnvironmentRole resource.
        :param pulumi.Input[str] cluster_id: Cluster ID (required).
        :param pulumi.Input[str] environment_name: Environment (namespace) name.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] permissions: Permissions, which is a non-empty string array of `produce` and `consume` at the most.
        :param pulumi.Input[str] role_name: Role Name.
        """
        pulumi.set(__self__, "cluster_id", cluster_id)
        pulumi.set(__self__, "environment_name", environment_name)
        pulumi.set(__self__, "permissions", permissions)
        pulumi.set(__self__, "role_name", role_name)

    @property
    @pulumi.getter(name="clusterId")
    def cluster_id(self) -> pulumi.Input[str]:
        """
        Cluster ID (required).
        """
        return pulumi.get(self, "cluster_id")

    @cluster_id.setter
    def cluster_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "cluster_id", value)

    @property
    @pulumi.getter(name="environmentName")
    def environment_name(self) -> pulumi.Input[str]:
        """
        Environment (namespace) name.
        """
        return pulumi.get(self, "environment_name")

    @environment_name.setter
    def environment_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "environment_name", value)

    @property
    @pulumi.getter
    def permissions(self) -> pulumi.Input[Sequence[pulumi.Input[str]]]:
        """
        Permissions, which is a non-empty string array of `produce` and `consume` at the most.
        """
        return pulumi.get(self, "permissions")

    @permissions.setter
    def permissions(self, value: pulumi.Input[Sequence[pulumi.Input[str]]]):
        pulumi.set(self, "permissions", value)

    @property
    @pulumi.getter(name="roleName")
    def role_name(self) -> pulumi.Input[str]:
        """
        Role Name.
        """
        return pulumi.get(self, "role_name")

    @role_name.setter
    def role_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "role_name", value)


@pulumi.input_type
class _RocketmqEnvironmentRoleState:
    def __init__(__self__, *,
                 cluster_id: Optional[pulumi.Input[str]] = None,
                 environment_name: Optional[pulumi.Input[str]] = None,
                 permissions: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 role_name: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering RocketmqEnvironmentRole resources.
        :param pulumi.Input[str] cluster_id: Cluster ID (required).
        :param pulumi.Input[str] environment_name: Environment (namespace) name.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] permissions: Permissions, which is a non-empty string array of `produce` and `consume` at the most.
        :param pulumi.Input[str] role_name: Role Name.
        """
        if cluster_id is not None:
            pulumi.set(__self__, "cluster_id", cluster_id)
        if environment_name is not None:
            pulumi.set(__self__, "environment_name", environment_name)
        if permissions is not None:
            pulumi.set(__self__, "permissions", permissions)
        if role_name is not None:
            pulumi.set(__self__, "role_name", role_name)

    @property
    @pulumi.getter(name="clusterId")
    def cluster_id(self) -> Optional[pulumi.Input[str]]:
        """
        Cluster ID (required).
        """
        return pulumi.get(self, "cluster_id")

    @cluster_id.setter
    def cluster_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cluster_id", value)

    @property
    @pulumi.getter(name="environmentName")
    def environment_name(self) -> Optional[pulumi.Input[str]]:
        """
        Environment (namespace) name.
        """
        return pulumi.get(self, "environment_name")

    @environment_name.setter
    def environment_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "environment_name", value)

    @property
    @pulumi.getter
    def permissions(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Permissions, which is a non-empty string array of `produce` and `consume` at the most.
        """
        return pulumi.get(self, "permissions")

    @permissions.setter
    def permissions(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "permissions", value)

    @property
    @pulumi.getter(name="roleName")
    def role_name(self) -> Optional[pulumi.Input[str]]:
        """
        Role Name.
        """
        return pulumi.get(self, "role_name")

    @role_name.setter
    def role_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "role_name", value)


class RocketmqEnvironmentRole(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cluster_id: Optional[pulumi.Input[str]] = None,
                 environment_name: Optional[pulumi.Input[str]] = None,
                 permissions: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 role_name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a resource to create a tdmqRocketmq environment_role

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        example_rocketmq_cluster = tencentcloud.tdmq.RocketmqCluster("exampleRocketmqCluster",
            cluster_name="tf_example",
            remark="remark.")
        example_rocketmq_role = tencentcloud.tdmq.RocketmqRole("exampleRocketmqRole",
            role_name="tf_example_role",
            remark="remark.",
            cluster_id=example_rocketmq_cluster.cluster_id)
        example_rocketmq_namespace = tencentcloud.tdmq.RocketmqNamespace("exampleRocketmqNamespace",
            cluster_id=example_rocketmq_cluster.cluster_id,
            namespace_name="tf_example_namespace",
            remark="remark.")
        example_rocketmq_environment_role = tencentcloud.tdmq.RocketmqEnvironmentRole("exampleRocketmqEnvironmentRole",
            environment_name=example_rocketmq_namespace.namespace_name,
            role_name=example_rocketmq_role.role_name,
            permissions=[
                "produce",
                "consume",
            ],
            cluster_id=example_rocketmq_cluster.cluster_id)
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        tdmqRocketmq environment_role can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Tdmq/rocketmqEnvironmentRole:RocketmqEnvironmentRole environment_role environmentRole_id
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] cluster_id: Cluster ID (required).
        :param pulumi.Input[str] environment_name: Environment (namespace) name.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] permissions: Permissions, which is a non-empty string array of `produce` and `consume` at the most.
        :param pulumi.Input[str] role_name: Role Name.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: RocketmqEnvironmentRoleArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a tdmqRocketmq environment_role

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        example_rocketmq_cluster = tencentcloud.tdmq.RocketmqCluster("exampleRocketmqCluster",
            cluster_name="tf_example",
            remark="remark.")
        example_rocketmq_role = tencentcloud.tdmq.RocketmqRole("exampleRocketmqRole",
            role_name="tf_example_role",
            remark="remark.",
            cluster_id=example_rocketmq_cluster.cluster_id)
        example_rocketmq_namespace = tencentcloud.tdmq.RocketmqNamespace("exampleRocketmqNamespace",
            cluster_id=example_rocketmq_cluster.cluster_id,
            namespace_name="tf_example_namespace",
            remark="remark.")
        example_rocketmq_environment_role = tencentcloud.tdmq.RocketmqEnvironmentRole("exampleRocketmqEnvironmentRole",
            environment_name=example_rocketmq_namespace.namespace_name,
            role_name=example_rocketmq_role.role_name,
            permissions=[
                "produce",
                "consume",
            ],
            cluster_id=example_rocketmq_cluster.cluster_id)
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        tdmqRocketmq environment_role can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Tdmq/rocketmqEnvironmentRole:RocketmqEnvironmentRole environment_role environmentRole_id
        ```

        :param str resource_name: The name of the resource.
        :param RocketmqEnvironmentRoleArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(RocketmqEnvironmentRoleArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cluster_id: Optional[pulumi.Input[str]] = None,
                 environment_name: Optional[pulumi.Input[str]] = None,
                 permissions: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 role_name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = RocketmqEnvironmentRoleArgs.__new__(RocketmqEnvironmentRoleArgs)

            if cluster_id is None and not opts.urn:
                raise TypeError("Missing required property 'cluster_id'")
            __props__.__dict__["cluster_id"] = cluster_id
            if environment_name is None and not opts.urn:
                raise TypeError("Missing required property 'environment_name'")
            __props__.__dict__["environment_name"] = environment_name
            if permissions is None and not opts.urn:
                raise TypeError("Missing required property 'permissions'")
            __props__.__dict__["permissions"] = permissions
            if role_name is None and not opts.urn:
                raise TypeError("Missing required property 'role_name'")
            __props__.__dict__["role_name"] = role_name
        super(RocketmqEnvironmentRole, __self__).__init__(
            'tencentcloud:Tdmq/rocketmqEnvironmentRole:RocketmqEnvironmentRole',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            cluster_id: Optional[pulumi.Input[str]] = None,
            environment_name: Optional[pulumi.Input[str]] = None,
            permissions: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            role_name: Optional[pulumi.Input[str]] = None) -> 'RocketmqEnvironmentRole':
        """
        Get an existing RocketmqEnvironmentRole resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] cluster_id: Cluster ID (required).
        :param pulumi.Input[str] environment_name: Environment (namespace) name.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] permissions: Permissions, which is a non-empty string array of `produce` and `consume` at the most.
        :param pulumi.Input[str] role_name: Role Name.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _RocketmqEnvironmentRoleState.__new__(_RocketmqEnvironmentRoleState)

        __props__.__dict__["cluster_id"] = cluster_id
        __props__.__dict__["environment_name"] = environment_name
        __props__.__dict__["permissions"] = permissions
        __props__.__dict__["role_name"] = role_name
        return RocketmqEnvironmentRole(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="clusterId")
    def cluster_id(self) -> pulumi.Output[str]:
        """
        Cluster ID (required).
        """
        return pulumi.get(self, "cluster_id")

    @property
    @pulumi.getter(name="environmentName")
    def environment_name(self) -> pulumi.Output[str]:
        """
        Environment (namespace) name.
        """
        return pulumi.get(self, "environment_name")

    @property
    @pulumi.getter
    def permissions(self) -> pulumi.Output[Sequence[str]]:
        """
        Permissions, which is a non-empty string array of `produce` and `consume` at the most.
        """
        return pulumi.get(self, "permissions")

    @property
    @pulumi.getter(name="roleName")
    def role_name(self) -> pulumi.Output[str]:
        """
        Role Name.
        """
        return pulumi.get(self, "role_name")

