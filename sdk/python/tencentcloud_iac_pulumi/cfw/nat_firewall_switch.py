# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['NatFirewallSwitchArgs', 'NatFirewallSwitch']

@pulumi.input_type
class NatFirewallSwitchArgs:
    def __init__(__self__, *,
                 enable: pulumi.Input[int],
                 nat_ins_id: pulumi.Input[str],
                 subnet_id: pulumi.Input[str]):
        """
        The set of arguments for constructing a NatFirewallSwitch resource.
        :param pulumi.Input[int] enable: Switch, 0: off, 1: on.
        :param pulumi.Input[str] nat_ins_id: Firewall instance id.
        :param pulumi.Input[str] subnet_id: subnet id.
        """
        pulumi.set(__self__, "enable", enable)
        pulumi.set(__self__, "nat_ins_id", nat_ins_id)
        pulumi.set(__self__, "subnet_id", subnet_id)

    @property
    @pulumi.getter
    def enable(self) -> pulumi.Input[int]:
        """
        Switch, 0: off, 1: on.
        """
        return pulumi.get(self, "enable")

    @enable.setter
    def enable(self, value: pulumi.Input[int]):
        pulumi.set(self, "enable", value)

    @property
    @pulumi.getter(name="natInsId")
    def nat_ins_id(self) -> pulumi.Input[str]:
        """
        Firewall instance id.
        """
        return pulumi.get(self, "nat_ins_id")

    @nat_ins_id.setter
    def nat_ins_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "nat_ins_id", value)

    @property
    @pulumi.getter(name="subnetId")
    def subnet_id(self) -> pulumi.Input[str]:
        """
        subnet id.
        """
        return pulumi.get(self, "subnet_id")

    @subnet_id.setter
    def subnet_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "subnet_id", value)


@pulumi.input_type
class _NatFirewallSwitchState:
    def __init__(__self__, *,
                 enable: Optional[pulumi.Input[int]] = None,
                 nat_ins_id: Optional[pulumi.Input[str]] = None,
                 subnet_id: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering NatFirewallSwitch resources.
        :param pulumi.Input[int] enable: Switch, 0: off, 1: on.
        :param pulumi.Input[str] nat_ins_id: Firewall instance id.
        :param pulumi.Input[str] subnet_id: subnet id.
        """
        if enable is not None:
            pulumi.set(__self__, "enable", enable)
        if nat_ins_id is not None:
            pulumi.set(__self__, "nat_ins_id", nat_ins_id)
        if subnet_id is not None:
            pulumi.set(__self__, "subnet_id", subnet_id)

    @property
    @pulumi.getter
    def enable(self) -> Optional[pulumi.Input[int]]:
        """
        Switch, 0: off, 1: on.
        """
        return pulumi.get(self, "enable")

    @enable.setter
    def enable(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "enable", value)

    @property
    @pulumi.getter(name="natInsId")
    def nat_ins_id(self) -> Optional[pulumi.Input[str]]:
        """
        Firewall instance id.
        """
        return pulumi.get(self, "nat_ins_id")

    @nat_ins_id.setter
    def nat_ins_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "nat_ins_id", value)

    @property
    @pulumi.getter(name="subnetId")
    def subnet_id(self) -> Optional[pulumi.Input[str]]:
        """
        subnet id.
        """
        return pulumi.get(self, "subnet_id")

    @subnet_id.setter
    def subnet_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "subnet_id", value)


class NatFirewallSwitch(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 enable: Optional[pulumi.Input[int]] = None,
                 nat_ins_id: Optional[pulumi.Input[str]] = None,
                 subnet_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a resource to create a cfw nat_firewall_switch

        ## Example Usage

        ### Turn off switch

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pulumi_tencentcloud as tencentcloud
        import tencentcloud_iac_pulumi as tencentcloud

        example_nat_fw_switches = tencentcloud.Cfw.get_nat_fw_switches(nat_ins_id="cfwnat-18d2ba18")
        example_nat_firewall_switch = tencentcloud.cfw.NatFirewallSwitch("exampleNatFirewallSwitch",
            nat_ins_id=example_nat_fw_switches.id,
            subnet_id=example_nat_fw_switches.datas[0].subnet_id,
            enable=0)
        ```
        <!--End PulumiCodeChooser -->

        ### Or turn on switch

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pulumi_tencentcloud as tencentcloud
        import tencentcloud_iac_pulumi as tencentcloud

        example_nat_fw_switches = tencentcloud.Cfw.get_nat_fw_switches(nat_ins_id="cfwnat-18d2ba18")
        example_nat_firewall_switch = tencentcloud.cfw.NatFirewallSwitch("exampleNatFirewallSwitch",
            nat_ins_id=example_nat_fw_switches.id,
            subnet_id=example_nat_fw_switches.datas[0].subnet_id,
            enable=1)
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        cfw nat_firewall_switch can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Cfw/natFirewallSwitch:NatFirewallSwitch example cfwnat-18d2ba18#subnet-ef7wyymr
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[int] enable: Switch, 0: off, 1: on.
        :param pulumi.Input[str] nat_ins_id: Firewall instance id.
        :param pulumi.Input[str] subnet_id: subnet id.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: NatFirewallSwitchArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a cfw nat_firewall_switch

        ## Example Usage

        ### Turn off switch

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pulumi_tencentcloud as tencentcloud
        import tencentcloud_iac_pulumi as tencentcloud

        example_nat_fw_switches = tencentcloud.Cfw.get_nat_fw_switches(nat_ins_id="cfwnat-18d2ba18")
        example_nat_firewall_switch = tencentcloud.cfw.NatFirewallSwitch("exampleNatFirewallSwitch",
            nat_ins_id=example_nat_fw_switches.id,
            subnet_id=example_nat_fw_switches.datas[0].subnet_id,
            enable=0)
        ```
        <!--End PulumiCodeChooser -->

        ### Or turn on switch

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pulumi_tencentcloud as tencentcloud
        import tencentcloud_iac_pulumi as tencentcloud

        example_nat_fw_switches = tencentcloud.Cfw.get_nat_fw_switches(nat_ins_id="cfwnat-18d2ba18")
        example_nat_firewall_switch = tencentcloud.cfw.NatFirewallSwitch("exampleNatFirewallSwitch",
            nat_ins_id=example_nat_fw_switches.id,
            subnet_id=example_nat_fw_switches.datas[0].subnet_id,
            enable=1)
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        cfw nat_firewall_switch can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Cfw/natFirewallSwitch:NatFirewallSwitch example cfwnat-18d2ba18#subnet-ef7wyymr
        ```

        :param str resource_name: The name of the resource.
        :param NatFirewallSwitchArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(NatFirewallSwitchArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 enable: Optional[pulumi.Input[int]] = None,
                 nat_ins_id: Optional[pulumi.Input[str]] = None,
                 subnet_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = NatFirewallSwitchArgs.__new__(NatFirewallSwitchArgs)

            if enable is None and not opts.urn:
                raise TypeError("Missing required property 'enable'")
            __props__.__dict__["enable"] = enable
            if nat_ins_id is None and not opts.urn:
                raise TypeError("Missing required property 'nat_ins_id'")
            __props__.__dict__["nat_ins_id"] = nat_ins_id
            if subnet_id is None and not opts.urn:
                raise TypeError("Missing required property 'subnet_id'")
            __props__.__dict__["subnet_id"] = subnet_id
        super(NatFirewallSwitch, __self__).__init__(
            'tencentcloud:Cfw/natFirewallSwitch:NatFirewallSwitch',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            enable: Optional[pulumi.Input[int]] = None,
            nat_ins_id: Optional[pulumi.Input[str]] = None,
            subnet_id: Optional[pulumi.Input[str]] = None) -> 'NatFirewallSwitch':
        """
        Get an existing NatFirewallSwitch resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[int] enable: Switch, 0: off, 1: on.
        :param pulumi.Input[str] nat_ins_id: Firewall instance id.
        :param pulumi.Input[str] subnet_id: subnet id.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _NatFirewallSwitchState.__new__(_NatFirewallSwitchState)

        __props__.__dict__["enable"] = enable
        __props__.__dict__["nat_ins_id"] = nat_ins_id
        __props__.__dict__["subnet_id"] = subnet_id
        return NatFirewallSwitch(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def enable(self) -> pulumi.Output[int]:
        """
        Switch, 0: off, 1: on.
        """
        return pulumi.get(self, "enable")

    @property
    @pulumi.getter(name="natInsId")
    def nat_ins_id(self) -> pulumi.Output[str]:
        """
        Firewall instance id.
        """
        return pulumi.get(self, "nat_ins_id")

    @property
    @pulumi.getter(name="subnetId")
    def subnet_id(self) -> pulumi.Output[str]:
        """
        subnet id.
        """
        return pulumi.get(self, "subnet_id")

