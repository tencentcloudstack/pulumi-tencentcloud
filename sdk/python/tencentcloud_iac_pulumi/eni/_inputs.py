# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = [
    'InstanceIpv4Args',
    'InstanceIpv4InfoArgs',
    'Ipv4AddressPrivateIpAddressArgs',
    'Ipv6AddressIpv6AddressArgs',
]

@pulumi.input_type
class InstanceIpv4Args:
    def __init__(__self__, *,
                 ip: pulumi.Input[str],
                 primary: pulumi.Input[bool],
                 description: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input[str] ip: Intranet IP.
        :param pulumi.Input[bool] primary: Indicates whether the IP is primary.
        :param pulumi.Input[str] description: Description of the IP, maximum length 25.
        """
        pulumi.set(__self__, "ip", ip)
        pulumi.set(__self__, "primary", primary)
        if description is not None:
            pulumi.set(__self__, "description", description)

    @property
    @pulumi.getter
    def ip(self) -> pulumi.Input[str]:
        """
        Intranet IP.
        """
        return pulumi.get(self, "ip")

    @ip.setter
    def ip(self, value: pulumi.Input[str]):
        pulumi.set(self, "ip", value)

    @property
    @pulumi.getter
    def primary(self) -> pulumi.Input[bool]:
        """
        Indicates whether the IP is primary.
        """
        return pulumi.get(self, "primary")

    @primary.setter
    def primary(self, value: pulumi.Input[bool]):
        pulumi.set(self, "primary", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Description of the IP, maximum length 25.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)


@pulumi.input_type
class InstanceIpv4InfoArgs:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[str]] = None,
                 ip: Optional[pulumi.Input[str]] = None,
                 primary: Optional[pulumi.Input[bool]] = None):
        """
        :param pulumi.Input[str] description: Description of the IP, maximum length 25.
        :param pulumi.Input[str] ip: Intranet IP.
        :param pulumi.Input[bool] primary: Indicates whether the IP is primary.
        """
        if description is not None:
            pulumi.set(__self__, "description", description)
        if ip is not None:
            pulumi.set(__self__, "ip", ip)
        if primary is not None:
            pulumi.set(__self__, "primary", primary)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Description of the IP, maximum length 25.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def ip(self) -> Optional[pulumi.Input[str]]:
        """
        Intranet IP.
        """
        return pulumi.get(self, "ip")

    @ip.setter
    def ip(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "ip", value)

    @property
    @pulumi.getter
    def primary(self) -> Optional[pulumi.Input[bool]]:
        """
        Indicates whether the IP is primary.
        """
        return pulumi.get(self, "primary")

    @primary.setter
    def primary(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "primary", value)


@pulumi.input_type
class Ipv4AddressPrivateIpAddressArgs:
    def __init__(__self__, *,
                 private_ip_address: pulumi.Input[str],
                 address_id: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 is_wan_ip_blocked: Optional[pulumi.Input[bool]] = None,
                 primary: Optional[pulumi.Input[bool]] = None,
                 public_ip_address: Optional[pulumi.Input[str]] = None,
                 qos_level: Optional[pulumi.Input[str]] = None,
                 state: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input[str] private_ip_address: Private IP address.
        :param pulumi.Input[str] address_id: EIP instance ID, such as `eip-11112222`.
        :param pulumi.Input[str] description: Private IP description.
        :param pulumi.Input[bool] is_wan_ip_blocked: Whether the public IP is blocked.
        :param pulumi.Input[bool] primary: Whether it is a primary IP.
        :param pulumi.Input[str] public_ip_address: Public IP address.
        :param pulumi.Input[str] qos_level: IP service level. Values: PT` (Gold), `AU` (Silver), `AG `(Bronze) and DEFAULT` (Default).
        :param pulumi.Input[str] state: IP status: `PENDING`: Creating, `MIGRATING`: Migrating, `DELETING`: Deleting, `AVAILABLE`: Available.
        """
        pulumi.set(__self__, "private_ip_address", private_ip_address)
        if address_id is not None:
            pulumi.set(__self__, "address_id", address_id)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if is_wan_ip_blocked is not None:
            pulumi.set(__self__, "is_wan_ip_blocked", is_wan_ip_blocked)
        if primary is not None:
            pulumi.set(__self__, "primary", primary)
        if public_ip_address is not None:
            pulumi.set(__self__, "public_ip_address", public_ip_address)
        if qos_level is not None:
            pulumi.set(__self__, "qos_level", qos_level)
        if state is not None:
            pulumi.set(__self__, "state", state)

    @property
    @pulumi.getter(name="privateIpAddress")
    def private_ip_address(self) -> pulumi.Input[str]:
        """
        Private IP address.
        """
        return pulumi.get(self, "private_ip_address")

    @private_ip_address.setter
    def private_ip_address(self, value: pulumi.Input[str]):
        pulumi.set(self, "private_ip_address", value)

    @property
    @pulumi.getter(name="addressId")
    def address_id(self) -> Optional[pulumi.Input[str]]:
        """
        EIP instance ID, such as `eip-11112222`.
        """
        return pulumi.get(self, "address_id")

    @address_id.setter
    def address_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "address_id", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Private IP description.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="isWanIpBlocked")
    def is_wan_ip_blocked(self) -> Optional[pulumi.Input[bool]]:
        """
        Whether the public IP is blocked.
        """
        return pulumi.get(self, "is_wan_ip_blocked")

    @is_wan_ip_blocked.setter
    def is_wan_ip_blocked(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "is_wan_ip_blocked", value)

    @property
    @pulumi.getter
    def primary(self) -> Optional[pulumi.Input[bool]]:
        """
        Whether it is a primary IP.
        """
        return pulumi.get(self, "primary")

    @primary.setter
    def primary(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "primary", value)

    @property
    @pulumi.getter(name="publicIpAddress")
    def public_ip_address(self) -> Optional[pulumi.Input[str]]:
        """
        Public IP address.
        """
        return pulumi.get(self, "public_ip_address")

    @public_ip_address.setter
    def public_ip_address(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "public_ip_address", value)

    @property
    @pulumi.getter(name="qosLevel")
    def qos_level(self) -> Optional[pulumi.Input[str]]:
        """
        IP service level. Values: PT` (Gold), `AU` (Silver), `AG `(Bronze) and DEFAULT` (Default).
        """
        return pulumi.get(self, "qos_level")

    @qos_level.setter
    def qos_level(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "qos_level", value)

    @property
    @pulumi.getter
    def state(self) -> Optional[pulumi.Input[str]]:
        """
        IP status: `PENDING`: Creating, `MIGRATING`: Migrating, `DELETING`: Deleting, `AVAILABLE`: Available.
        """
        return pulumi.get(self, "state")

    @state.setter
    def state(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "state", value)


@pulumi.input_type
class Ipv6AddressIpv6AddressArgs:
    def __init__(__self__, *,
                 address: pulumi.Input[str],
                 address_id: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 is_wan_ip_blocked: Optional[pulumi.Input[bool]] = None,
                 primary: Optional[pulumi.Input[bool]] = None,
                 state: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input[str] address: `IPv6` address, in the form of: `3402:4e00:20:100:0:8cd9:2a67:71f3`.
        :param pulumi.Input[str] address_id: `EIP` instance `ID`, such as:`eip-hxlqja90`.
        :param pulumi.Input[str] description: Description.
        :param pulumi.Input[bool] is_wan_ip_blocked: Whether the public network IP is blocked.
        :param pulumi.Input[bool] primary: Whether to master `IP`.
        :param pulumi.Input[str] state: `IPv6` address status: `PENDING`: pending, `MIGRATING`: migrating, `DELETING`: deleting, `AVAILABLE`: available.
        """
        pulumi.set(__self__, "address", address)
        if address_id is not None:
            pulumi.set(__self__, "address_id", address_id)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if is_wan_ip_blocked is not None:
            pulumi.set(__self__, "is_wan_ip_blocked", is_wan_ip_blocked)
        if primary is not None:
            pulumi.set(__self__, "primary", primary)
        if state is not None:
            pulumi.set(__self__, "state", state)

    @property
    @pulumi.getter
    def address(self) -> pulumi.Input[str]:
        """
        `IPv6` address, in the form of: `3402:4e00:20:100:0:8cd9:2a67:71f3`.
        """
        return pulumi.get(self, "address")

    @address.setter
    def address(self, value: pulumi.Input[str]):
        pulumi.set(self, "address", value)

    @property
    @pulumi.getter(name="addressId")
    def address_id(self) -> Optional[pulumi.Input[str]]:
        """
        `EIP` instance `ID`, such as:`eip-hxlqja90`.
        """
        return pulumi.get(self, "address_id")

    @address_id.setter
    def address_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "address_id", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Description.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="isWanIpBlocked")
    def is_wan_ip_blocked(self) -> Optional[pulumi.Input[bool]]:
        """
        Whether the public network IP is blocked.
        """
        return pulumi.get(self, "is_wan_ip_blocked")

    @is_wan_ip_blocked.setter
    def is_wan_ip_blocked(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "is_wan_ip_blocked", value)

    @property
    @pulumi.getter
    def primary(self) -> Optional[pulumi.Input[bool]]:
        """
        Whether to master `IP`.
        """
        return pulumi.get(self, "primary")

    @primary.setter
    def primary(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "primary", value)

    @property
    @pulumi.getter
    def state(self) -> Optional[pulumi.Input[str]]:
        """
        `IPv6` address status: `PENDING`: pending, `MIGRATING`: migrating, `DELETING`: deleting, `AVAILABLE`: available.
        """
        return pulumi.get(self, "state")

    @state.setter
    def state(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "state", value)


