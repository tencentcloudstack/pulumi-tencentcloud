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
    'GetInstanceEniResult',
    'GetInstanceEniIpv4Result',
    'GetInstanceEniIpv6Result',
]

@pulumi.output_type
class GetInstanceEniResult(dict):
    def __init__(__self__, *,
                 cdc_id: str,
                 create_time: str,
                 description: str,
                 id: str,
                 instance_id: str,
                 ipv4s: Sequence['outputs.GetInstanceEniIpv4Result'],
                 ipv6s: Sequence['outputs.GetInstanceEniIpv6Result'],
                 mac: str,
                 name: str,
                 primary: bool,
                 security_groups: Sequence[str],
                 state: str,
                 subnet_id: str,
                 tags: Mapping[str, Any],
                 vpc_id: str):
        """
        :param str cdc_id: CDC instance ID.
        :param str create_time: Creation time of the ENI.
        :param str description: Description of the ENI. Conflict with `ids`.
        :param str id: ID of the ENI.
        :param str instance_id: ID of the instance which bind the ENI. Conflict with `ids`.
        :param Sequence['GetInstanceEniIpv4Args'] ipv4s: A set of intranet IPv4s.
        :param Sequence['GetInstanceEniIpv6Args'] ipv6s: A set of intranet IPv6s.
        :param str mac: MAC address.
        :param str name: Name of the ENI to be queried. Conflict with `ids`.
        :param bool primary: Indicates whether the IP is primary.
        :param Sequence[str] security_groups: A set of security group IDs which bind the ENI.
        :param str state: States of the ENI.
        :param str subnet_id: ID of the subnet within this vpc to be queried. Conflict with `ids`.
        :param Mapping[str, Any] tags: Tags of the ENI. Conflict with `ids`.
        :param str vpc_id: ID of the vpc to be queried. Conflict with `ids`.
        """
        pulumi.set(__self__, "cdc_id", cdc_id)
        pulumi.set(__self__, "create_time", create_time)
        pulumi.set(__self__, "description", description)
        pulumi.set(__self__, "id", id)
        pulumi.set(__self__, "instance_id", instance_id)
        pulumi.set(__self__, "ipv4s", ipv4s)
        pulumi.set(__self__, "ipv6s", ipv6s)
        pulumi.set(__self__, "mac", mac)
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "primary", primary)
        pulumi.set(__self__, "security_groups", security_groups)
        pulumi.set(__self__, "state", state)
        pulumi.set(__self__, "subnet_id", subnet_id)
        pulumi.set(__self__, "tags", tags)
        pulumi.set(__self__, "vpc_id", vpc_id)

    @property
    @pulumi.getter(name="cdcId")
    def cdc_id(self) -> str:
        """
        CDC instance ID.
        """
        return pulumi.get(self, "cdc_id")

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> str:
        """
        Creation time of the ENI.
        """
        return pulumi.get(self, "create_time")

    @property
    @pulumi.getter
    def description(self) -> str:
        """
        Description of the ENI. Conflict with `ids`.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        ID of the ENI.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> str:
        """
        ID of the instance which bind the ENI. Conflict with `ids`.
        """
        return pulumi.get(self, "instance_id")

    @property
    @pulumi.getter
    def ipv4s(self) -> Sequence['outputs.GetInstanceEniIpv4Result']:
        """
        A set of intranet IPv4s.
        """
        return pulumi.get(self, "ipv4s")

    @property
    @pulumi.getter
    def ipv6s(self) -> Sequence['outputs.GetInstanceEniIpv6Result']:
        """
        A set of intranet IPv6s.
        """
        return pulumi.get(self, "ipv6s")

    @property
    @pulumi.getter
    def mac(self) -> str:
        """
        MAC address.
        """
        return pulumi.get(self, "mac")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Name of the ENI to be queried. Conflict with `ids`.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def primary(self) -> bool:
        """
        Indicates whether the IP is primary.
        """
        return pulumi.get(self, "primary")

    @property
    @pulumi.getter(name="securityGroups")
    def security_groups(self) -> Sequence[str]:
        """
        A set of security group IDs which bind the ENI.
        """
        return pulumi.get(self, "security_groups")

    @property
    @pulumi.getter
    def state(self) -> str:
        """
        States of the ENI.
        """
        return pulumi.get(self, "state")

    @property
    @pulumi.getter(name="subnetId")
    def subnet_id(self) -> str:
        """
        ID of the subnet within this vpc to be queried. Conflict with `ids`.
        """
        return pulumi.get(self, "subnet_id")

    @property
    @pulumi.getter
    def tags(self) -> Mapping[str, Any]:
        """
        Tags of the ENI. Conflict with `ids`.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="vpcId")
    def vpc_id(self) -> str:
        """
        ID of the vpc to be queried. Conflict with `ids`.
        """
        return pulumi.get(self, "vpc_id")


@pulumi.output_type
class GetInstanceEniIpv4Result(dict):
    def __init__(__self__, *,
                 description: str,
                 ip: str,
                 primary: bool):
        """
        :param str description: Description of the ENI. Conflict with `ids`.
        :param str ip: Intranet IP.
        :param bool primary: Indicates whether the IP is primary.
        """
        pulumi.set(__self__, "description", description)
        pulumi.set(__self__, "ip", ip)
        pulumi.set(__self__, "primary", primary)

    @property
    @pulumi.getter
    def description(self) -> str:
        """
        Description of the ENI. Conflict with `ids`.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def ip(self) -> str:
        """
        Intranet IP.
        """
        return pulumi.get(self, "ip")

    @property
    @pulumi.getter
    def primary(self) -> bool:
        """
        Indicates whether the IP is primary.
        """
        return pulumi.get(self, "primary")


@pulumi.output_type
class GetInstanceEniIpv6Result(dict):
    def __init__(__self__, *,
                 address: str,
                 address_id: str,
                 description: str,
                 is_wan_ip_blocked: bool,
                 primary: bool):
        """
        :param str address: `IPv6` address, such as `3402:4e00:20:100:0:8cd9:2a67:71f3`.
        :param str address_id: The `ID` of the `EIP` instance, such as `eip-hxlqja90`.
        :param str description: Description of the ENI. Conflict with `ids`.
        :param bool is_wan_ip_blocked: Whether the public IP is blocked.
        :param bool primary: Indicates whether the IP is primary.
        """
        pulumi.set(__self__, "address", address)
        pulumi.set(__self__, "address_id", address_id)
        pulumi.set(__self__, "description", description)
        pulumi.set(__self__, "is_wan_ip_blocked", is_wan_ip_blocked)
        pulumi.set(__self__, "primary", primary)

    @property
    @pulumi.getter
    def address(self) -> str:
        """
        `IPv6` address, such as `3402:4e00:20:100:0:8cd9:2a67:71f3`.
        """
        return pulumi.get(self, "address")

    @property
    @pulumi.getter(name="addressId")
    def address_id(self) -> str:
        """
        The `ID` of the `EIP` instance, such as `eip-hxlqja90`.
        """
        return pulumi.get(self, "address_id")

    @property
    @pulumi.getter
    def description(self) -> str:
        """
        Description of the ENI. Conflict with `ids`.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="isWanIpBlocked")
    def is_wan_ip_blocked(self) -> bool:
        """
        Whether the public IP is blocked.
        """
        return pulumi.get(self, "is_wan_ip_blocked")

    @property
    @pulumi.getter
    def primary(self) -> bool:
        """
        Indicates whether the IP is primary.
        """
        return pulumi.get(self, "primary")


