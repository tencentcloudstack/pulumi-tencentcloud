# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['InternetAddressArgs', 'InternetAddress']

@pulumi.input_type
class InternetAddressArgs:
    def __init__(__self__, *,
                 addr_proto: pulumi.Input[int],
                 addr_type: pulumi.Input[int],
                 mask_len: pulumi.Input[int]):
        """
        The set of arguments for constructing a InternetAddress resource.
        :param pulumi.Input[int] addr_proto: 0: IPv4, 1: IPv6.
        :param pulumi.Input[int] addr_type: 0: BGP, 1: china telecom, 2: china mobile, 3: china unicom.
        :param pulumi.Input[int] mask_len: CIDR address mask.
        """
        pulumi.set(__self__, "addr_proto", addr_proto)
        pulumi.set(__self__, "addr_type", addr_type)
        pulumi.set(__self__, "mask_len", mask_len)

    @property
    @pulumi.getter(name="addrProto")
    def addr_proto(self) -> pulumi.Input[int]:
        """
        0: IPv4, 1: IPv6.
        """
        return pulumi.get(self, "addr_proto")

    @addr_proto.setter
    def addr_proto(self, value: pulumi.Input[int]):
        pulumi.set(self, "addr_proto", value)

    @property
    @pulumi.getter(name="addrType")
    def addr_type(self) -> pulumi.Input[int]:
        """
        0: BGP, 1: china telecom, 2: china mobile, 3: china unicom.
        """
        return pulumi.get(self, "addr_type")

    @addr_type.setter
    def addr_type(self, value: pulumi.Input[int]):
        pulumi.set(self, "addr_type", value)

    @property
    @pulumi.getter(name="maskLen")
    def mask_len(self) -> pulumi.Input[int]:
        """
        CIDR address mask.
        """
        return pulumi.get(self, "mask_len")

    @mask_len.setter
    def mask_len(self, value: pulumi.Input[int]):
        pulumi.set(self, "mask_len", value)


@pulumi.input_type
class _InternetAddressState:
    def __init__(__self__, *,
                 addr_proto: Optional[pulumi.Input[int]] = None,
                 addr_type: Optional[pulumi.Input[int]] = None,
                 mask_len: Optional[pulumi.Input[int]] = None):
        """
        Input properties used for looking up and filtering InternetAddress resources.
        :param pulumi.Input[int] addr_proto: 0: IPv4, 1: IPv6.
        :param pulumi.Input[int] addr_type: 0: BGP, 1: china telecom, 2: china mobile, 3: china unicom.
        :param pulumi.Input[int] mask_len: CIDR address mask.
        """
        if addr_proto is not None:
            pulumi.set(__self__, "addr_proto", addr_proto)
        if addr_type is not None:
            pulumi.set(__self__, "addr_type", addr_type)
        if mask_len is not None:
            pulumi.set(__self__, "mask_len", mask_len)

    @property
    @pulumi.getter(name="addrProto")
    def addr_proto(self) -> Optional[pulumi.Input[int]]:
        """
        0: IPv4, 1: IPv6.
        """
        return pulumi.get(self, "addr_proto")

    @addr_proto.setter
    def addr_proto(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "addr_proto", value)

    @property
    @pulumi.getter(name="addrType")
    def addr_type(self) -> Optional[pulumi.Input[int]]:
        """
        0: BGP, 1: china telecom, 2: china mobile, 3: china unicom.
        """
        return pulumi.get(self, "addr_type")

    @addr_type.setter
    def addr_type(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "addr_type", value)

    @property
    @pulumi.getter(name="maskLen")
    def mask_len(self) -> Optional[pulumi.Input[int]]:
        """
        CIDR address mask.
        """
        return pulumi.get(self, "mask_len")

    @mask_len.setter
    def mask_len(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "mask_len", value)


class InternetAddress(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 addr_proto: Optional[pulumi.Input[int]] = None,
                 addr_type: Optional[pulumi.Input[int]] = None,
                 mask_len: Optional[pulumi.Input[int]] = None,
                 __props__=None):
        """
        Provides a resource to create a dc internet_address

        ## Example Usage

        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        internet_address = tencentcloud.dc.InternetAddress("internetAddress",
            addr_proto=0,
            addr_type=2,
            mask_len=30)
        ```

        ## Import

        dc internet_address can be imported using the id, e.g.

        ```sh
         $ pulumi import tencentcloud:Dc/internetAddress:InternetAddress internet_address internet_address_id
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[int] addr_proto: 0: IPv4, 1: IPv6.
        :param pulumi.Input[int] addr_type: 0: BGP, 1: china telecom, 2: china mobile, 3: china unicom.
        :param pulumi.Input[int] mask_len: CIDR address mask.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: InternetAddressArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a dc internet_address

        ## Example Usage

        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        internet_address = tencentcloud.dc.InternetAddress("internetAddress",
            addr_proto=0,
            addr_type=2,
            mask_len=30)
        ```

        ## Import

        dc internet_address can be imported using the id, e.g.

        ```sh
         $ pulumi import tencentcloud:Dc/internetAddress:InternetAddress internet_address internet_address_id
        ```

        :param str resource_name: The name of the resource.
        :param InternetAddressArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(InternetAddressArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 addr_proto: Optional[pulumi.Input[int]] = None,
                 addr_type: Optional[pulumi.Input[int]] = None,
                 mask_len: Optional[pulumi.Input[int]] = None,
                 __props__=None):
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.plugin_download_url is None:
            opts.plugin_download_url = _utilities.get_plugin_download_url()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = InternetAddressArgs.__new__(InternetAddressArgs)

            if addr_proto is None and not opts.urn:
                raise TypeError("Missing required property 'addr_proto'")
            __props__.__dict__["addr_proto"] = addr_proto
            if addr_type is None and not opts.urn:
                raise TypeError("Missing required property 'addr_type'")
            __props__.__dict__["addr_type"] = addr_type
            if mask_len is None and not opts.urn:
                raise TypeError("Missing required property 'mask_len'")
            __props__.__dict__["mask_len"] = mask_len
        super(InternetAddress, __self__).__init__(
            'tencentcloud:Dc/internetAddress:InternetAddress',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            addr_proto: Optional[pulumi.Input[int]] = None,
            addr_type: Optional[pulumi.Input[int]] = None,
            mask_len: Optional[pulumi.Input[int]] = None) -> 'InternetAddress':
        """
        Get an existing InternetAddress resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[int] addr_proto: 0: IPv4, 1: IPv6.
        :param pulumi.Input[int] addr_type: 0: BGP, 1: china telecom, 2: china mobile, 3: china unicom.
        :param pulumi.Input[int] mask_len: CIDR address mask.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _InternetAddressState.__new__(_InternetAddressState)

        __props__.__dict__["addr_proto"] = addr_proto
        __props__.__dict__["addr_type"] = addr_type
        __props__.__dict__["mask_len"] = mask_len
        return InternetAddress(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="addrProto")
    def addr_proto(self) -> pulumi.Output[int]:
        """
        0: IPv4, 1: IPv6.
        """
        return pulumi.get(self, "addr_proto")

    @property
    @pulumi.getter(name="addrType")
    def addr_type(self) -> pulumi.Output[int]:
        """
        0: BGP, 1: china telecom, 2: china mobile, 3: china unicom.
        """
        return pulumi.get(self, "addr_type")

    @property
    @pulumi.getter(name="maskLen")
    def mask_len(self) -> pulumi.Output[int]:
        """
        CIDR address mask.
        """
        return pulumi.get(self, "mask_len")
