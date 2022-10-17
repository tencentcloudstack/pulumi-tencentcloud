# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['InstanceArgs', 'Instance']

@pulumi.input_type
class InstanceArgs:
    def __init__(__self__, *,
                 cidr_block: pulumi.Input[str],
                 assistant_cidrs: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 dns_servers: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 is_multicast: Optional[pulumi.Input[bool]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, Any]]] = None):
        """
        The set of arguments for constructing a Instance resource.
        :param pulumi.Input[str] cidr_block: A network address block which should be a subnet of the three internal network segments (10.0.0.0/16, 172.16.0.0/12 and 192.168.0.0/16).
        :param pulumi.Input[Sequence[pulumi.Input[str]]] assistant_cidrs: List of Assistant CIDR.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] dns_servers: The DNS server list of the VPC. And you can specify 0 to 5 servers to this list.
        :param pulumi.Input[bool] is_multicast: Indicates whether VPC multicast is enabled. The default value is 'true'.
        :param pulumi.Input[str] name: The name of the VPC.
        :param pulumi.Input[Mapping[str, Any]] tags: Tags of the VPC.
        """
        pulumi.set(__self__, "cidr_block", cidr_block)
        if assistant_cidrs is not None:
            pulumi.set(__self__, "assistant_cidrs", assistant_cidrs)
        if dns_servers is not None:
            pulumi.set(__self__, "dns_servers", dns_servers)
        if is_multicast is not None:
            pulumi.set(__self__, "is_multicast", is_multicast)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter(name="cidrBlock")
    def cidr_block(self) -> pulumi.Input[str]:
        """
        A network address block which should be a subnet of the three internal network segments (10.0.0.0/16, 172.16.0.0/12 and 192.168.0.0/16).
        """
        return pulumi.get(self, "cidr_block")

    @cidr_block.setter
    def cidr_block(self, value: pulumi.Input[str]):
        pulumi.set(self, "cidr_block", value)

    @property
    @pulumi.getter(name="assistantCidrs")
    def assistant_cidrs(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        List of Assistant CIDR.
        """
        return pulumi.get(self, "assistant_cidrs")

    @assistant_cidrs.setter
    def assistant_cidrs(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "assistant_cidrs", value)

    @property
    @pulumi.getter(name="dnsServers")
    def dns_servers(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        The DNS server list of the VPC. And you can specify 0 to 5 servers to this list.
        """
        return pulumi.get(self, "dns_servers")

    @dns_servers.setter
    def dns_servers(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "dns_servers", value)

    @property
    @pulumi.getter(name="isMulticast")
    def is_multicast(self) -> Optional[pulumi.Input[bool]]:
        """
        Indicates whether VPC multicast is enabled. The default value is 'true'.
        """
        return pulumi.get(self, "is_multicast")

    @is_multicast.setter
    def is_multicast(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "is_multicast", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the VPC.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Mapping[str, Any]]]:
        """
        Tags of the VPC.
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Mapping[str, Any]]]):
        pulumi.set(self, "tags", value)


@pulumi.input_type
class _InstanceState:
    def __init__(__self__, *,
                 assistant_cidrs: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 cidr_block: Optional[pulumi.Input[str]] = None,
                 create_time: Optional[pulumi.Input[str]] = None,
                 default_route_table_id: Optional[pulumi.Input[str]] = None,
                 dns_servers: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 is_default: Optional[pulumi.Input[bool]] = None,
                 is_multicast: Optional[pulumi.Input[bool]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, Any]]] = None):
        """
        Input properties used for looking up and filtering Instance resources.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] assistant_cidrs: List of Assistant CIDR.
        :param pulumi.Input[str] cidr_block: A network address block which should be a subnet of the three internal network segments (10.0.0.0/16, 172.16.0.0/12 and 192.168.0.0/16).
        :param pulumi.Input[str] create_time: Creation time of VPC.
        :param pulumi.Input[str] default_route_table_id: Default route table id, which created automatically after VPC create.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] dns_servers: The DNS server list of the VPC. And you can specify 0 to 5 servers to this list.
        :param pulumi.Input[bool] is_default: Indicates whether it is the default VPC for this region.
        :param pulumi.Input[bool] is_multicast: Indicates whether VPC multicast is enabled. The default value is 'true'.
        :param pulumi.Input[str] name: The name of the VPC.
        :param pulumi.Input[Mapping[str, Any]] tags: Tags of the VPC.
        """
        if assistant_cidrs is not None:
            pulumi.set(__self__, "assistant_cidrs", assistant_cidrs)
        if cidr_block is not None:
            pulumi.set(__self__, "cidr_block", cidr_block)
        if create_time is not None:
            pulumi.set(__self__, "create_time", create_time)
        if default_route_table_id is not None:
            pulumi.set(__self__, "default_route_table_id", default_route_table_id)
        if dns_servers is not None:
            pulumi.set(__self__, "dns_servers", dns_servers)
        if is_default is not None:
            pulumi.set(__self__, "is_default", is_default)
        if is_multicast is not None:
            pulumi.set(__self__, "is_multicast", is_multicast)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter(name="assistantCidrs")
    def assistant_cidrs(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        List of Assistant CIDR.
        """
        return pulumi.get(self, "assistant_cidrs")

    @assistant_cidrs.setter
    def assistant_cidrs(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "assistant_cidrs", value)

    @property
    @pulumi.getter(name="cidrBlock")
    def cidr_block(self) -> Optional[pulumi.Input[str]]:
        """
        A network address block which should be a subnet of the three internal network segments (10.0.0.0/16, 172.16.0.0/12 and 192.168.0.0/16).
        """
        return pulumi.get(self, "cidr_block")

    @cidr_block.setter
    def cidr_block(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cidr_block", value)

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> Optional[pulumi.Input[str]]:
        """
        Creation time of VPC.
        """
        return pulumi.get(self, "create_time")

    @create_time.setter
    def create_time(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "create_time", value)

    @property
    @pulumi.getter(name="defaultRouteTableId")
    def default_route_table_id(self) -> Optional[pulumi.Input[str]]:
        """
        Default route table id, which created automatically after VPC create.
        """
        return pulumi.get(self, "default_route_table_id")

    @default_route_table_id.setter
    def default_route_table_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "default_route_table_id", value)

    @property
    @pulumi.getter(name="dnsServers")
    def dns_servers(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        The DNS server list of the VPC. And you can specify 0 to 5 servers to this list.
        """
        return pulumi.get(self, "dns_servers")

    @dns_servers.setter
    def dns_servers(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "dns_servers", value)

    @property
    @pulumi.getter(name="isDefault")
    def is_default(self) -> Optional[pulumi.Input[bool]]:
        """
        Indicates whether it is the default VPC for this region.
        """
        return pulumi.get(self, "is_default")

    @is_default.setter
    def is_default(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "is_default", value)

    @property
    @pulumi.getter(name="isMulticast")
    def is_multicast(self) -> Optional[pulumi.Input[bool]]:
        """
        Indicates whether VPC multicast is enabled. The default value is 'true'.
        """
        return pulumi.get(self, "is_multicast")

    @is_multicast.setter
    def is_multicast(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "is_multicast", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the VPC.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Mapping[str, Any]]]:
        """
        Tags of the VPC.
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Mapping[str, Any]]]):
        pulumi.set(self, "tags", value)


class Instance(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 assistant_cidrs: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 cidr_block: Optional[pulumi.Input[str]] = None,
                 dns_servers: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 is_multicast: Optional[pulumi.Input[bool]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 __props__=None):
        """
        Provide a resource to create a VPC.

        ## Import

        Vpc instance can be imported, e.g.

        ```sh
         $ pulumi import tencentcloud:Vpc/instance:Instance test vpc-id
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] assistant_cidrs: List of Assistant CIDR.
        :param pulumi.Input[str] cidr_block: A network address block which should be a subnet of the three internal network segments (10.0.0.0/16, 172.16.0.0/12 and 192.168.0.0/16).
        :param pulumi.Input[Sequence[pulumi.Input[str]]] dns_servers: The DNS server list of the VPC. And you can specify 0 to 5 servers to this list.
        :param pulumi.Input[bool] is_multicast: Indicates whether VPC multicast is enabled. The default value is 'true'.
        :param pulumi.Input[str] name: The name of the VPC.
        :param pulumi.Input[Mapping[str, Any]] tags: Tags of the VPC.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: InstanceArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provide a resource to create a VPC.

        ## Import

        Vpc instance can be imported, e.g.

        ```sh
         $ pulumi import tencentcloud:Vpc/instance:Instance test vpc-id
        ```

        :param str resource_name: The name of the resource.
        :param InstanceArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(InstanceArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 assistant_cidrs: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 cidr_block: Optional[pulumi.Input[str]] = None,
                 dns_servers: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 is_multicast: Optional[pulumi.Input[bool]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 __props__=None):
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = InstanceArgs.__new__(InstanceArgs)

            __props__.__dict__["assistant_cidrs"] = assistant_cidrs
            if cidr_block is None and not opts.urn:
                raise TypeError("Missing required property 'cidr_block'")
            __props__.__dict__["cidr_block"] = cidr_block
            __props__.__dict__["dns_servers"] = dns_servers
            __props__.__dict__["is_multicast"] = is_multicast
            __props__.__dict__["name"] = name
            __props__.__dict__["tags"] = tags
            __props__.__dict__["create_time"] = None
            __props__.__dict__["default_route_table_id"] = None
            __props__.__dict__["is_default"] = None
        super(Instance, __self__).__init__(
            'tencentcloud:Vpc/instance:Instance',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            assistant_cidrs: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            cidr_block: Optional[pulumi.Input[str]] = None,
            create_time: Optional[pulumi.Input[str]] = None,
            default_route_table_id: Optional[pulumi.Input[str]] = None,
            dns_servers: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            is_default: Optional[pulumi.Input[bool]] = None,
            is_multicast: Optional[pulumi.Input[bool]] = None,
            name: Optional[pulumi.Input[str]] = None,
            tags: Optional[pulumi.Input[Mapping[str, Any]]] = None) -> 'Instance':
        """
        Get an existing Instance resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] assistant_cidrs: List of Assistant CIDR.
        :param pulumi.Input[str] cidr_block: A network address block which should be a subnet of the three internal network segments (10.0.0.0/16, 172.16.0.0/12 and 192.168.0.0/16).
        :param pulumi.Input[str] create_time: Creation time of VPC.
        :param pulumi.Input[str] default_route_table_id: Default route table id, which created automatically after VPC create.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] dns_servers: The DNS server list of the VPC. And you can specify 0 to 5 servers to this list.
        :param pulumi.Input[bool] is_default: Indicates whether it is the default VPC for this region.
        :param pulumi.Input[bool] is_multicast: Indicates whether VPC multicast is enabled. The default value is 'true'.
        :param pulumi.Input[str] name: The name of the VPC.
        :param pulumi.Input[Mapping[str, Any]] tags: Tags of the VPC.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _InstanceState.__new__(_InstanceState)

        __props__.__dict__["assistant_cidrs"] = assistant_cidrs
        __props__.__dict__["cidr_block"] = cidr_block
        __props__.__dict__["create_time"] = create_time
        __props__.__dict__["default_route_table_id"] = default_route_table_id
        __props__.__dict__["dns_servers"] = dns_servers
        __props__.__dict__["is_default"] = is_default
        __props__.__dict__["is_multicast"] = is_multicast
        __props__.__dict__["name"] = name
        __props__.__dict__["tags"] = tags
        return Instance(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="assistantCidrs")
    def assistant_cidrs(self) -> pulumi.Output[Sequence[str]]:
        """
        List of Assistant CIDR.
        """
        return pulumi.get(self, "assistant_cidrs")

    @property
    @pulumi.getter(name="cidrBlock")
    def cidr_block(self) -> pulumi.Output[str]:
        """
        A network address block which should be a subnet of the three internal network segments (10.0.0.0/16, 172.16.0.0/12 and 192.168.0.0/16).
        """
        return pulumi.get(self, "cidr_block")

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> pulumi.Output[str]:
        """
        Creation time of VPC.
        """
        return pulumi.get(self, "create_time")

    @property
    @pulumi.getter(name="defaultRouteTableId")
    def default_route_table_id(self) -> pulumi.Output[str]:
        """
        Default route table id, which created automatically after VPC create.
        """
        return pulumi.get(self, "default_route_table_id")

    @property
    @pulumi.getter(name="dnsServers")
    def dns_servers(self) -> pulumi.Output[Sequence[str]]:
        """
        The DNS server list of the VPC. And you can specify 0 to 5 servers to this list.
        """
        return pulumi.get(self, "dns_servers")

    @property
    @pulumi.getter(name="isDefault")
    def is_default(self) -> pulumi.Output[bool]:
        """
        Indicates whether it is the default VPC for this region.
        """
        return pulumi.get(self, "is_default")

    @property
    @pulumi.getter(name="isMulticast")
    def is_multicast(self) -> pulumi.Output[Optional[bool]]:
        """
        Indicates whether VPC multicast is enabled. The default value is 'true'.
        """
        return pulumi.get(self, "is_multicast")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name of the VPC.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, Any]]]:
        """
        Tags of the VPC.
        """
        return pulumi.get(self, "tags")
