# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['CngwStrategyBindGroupArgs', 'CngwStrategyBindGroup']

@pulumi.input_type
class CngwStrategyBindGroupArgs:
    def __init__(__self__, *,
                 gateway_id: pulumi.Input[str],
                 group_id: pulumi.Input[str],
                 option: pulumi.Input[str],
                 strategy_id: pulumi.Input[str]):
        """
        The set of arguments for constructing a CngwStrategyBindGroup resource.
        :param pulumi.Input[str] gateway_id: gateway ID.
        :param pulumi.Input[str] group_id: group ID.
        :param pulumi.Input[str] option: `bind` or `unbind`.
        :param pulumi.Input[str] strategy_id: strategy ID.
        """
        pulumi.set(__self__, "gateway_id", gateway_id)
        pulumi.set(__self__, "group_id", group_id)
        pulumi.set(__self__, "option", option)
        pulumi.set(__self__, "strategy_id", strategy_id)

    @property
    @pulumi.getter(name="gatewayId")
    def gateway_id(self) -> pulumi.Input[str]:
        """
        gateway ID.
        """
        return pulumi.get(self, "gateway_id")

    @gateway_id.setter
    def gateway_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "gateway_id", value)

    @property
    @pulumi.getter(name="groupId")
    def group_id(self) -> pulumi.Input[str]:
        """
        group ID.
        """
        return pulumi.get(self, "group_id")

    @group_id.setter
    def group_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "group_id", value)

    @property
    @pulumi.getter
    def option(self) -> pulumi.Input[str]:
        """
        `bind` or `unbind`.
        """
        return pulumi.get(self, "option")

    @option.setter
    def option(self, value: pulumi.Input[str]):
        pulumi.set(self, "option", value)

    @property
    @pulumi.getter(name="strategyId")
    def strategy_id(self) -> pulumi.Input[str]:
        """
        strategy ID.
        """
        return pulumi.get(self, "strategy_id")

    @strategy_id.setter
    def strategy_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "strategy_id", value)


@pulumi.input_type
class _CngwStrategyBindGroupState:
    def __init__(__self__, *,
                 gateway_id: Optional[pulumi.Input[str]] = None,
                 group_id: Optional[pulumi.Input[str]] = None,
                 option: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 strategy_id: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering CngwStrategyBindGroup resources.
        :param pulumi.Input[str] gateway_id: gateway ID.
        :param pulumi.Input[str] group_id: group ID.
        :param pulumi.Input[str] option: `bind` or `unbind`.
        :param pulumi.Input[str] status: Binding status.
        :param pulumi.Input[str] strategy_id: strategy ID.
        """
        if gateway_id is not None:
            pulumi.set(__self__, "gateway_id", gateway_id)
        if group_id is not None:
            pulumi.set(__self__, "group_id", group_id)
        if option is not None:
            pulumi.set(__self__, "option", option)
        if status is not None:
            pulumi.set(__self__, "status", status)
        if strategy_id is not None:
            pulumi.set(__self__, "strategy_id", strategy_id)

    @property
    @pulumi.getter(name="gatewayId")
    def gateway_id(self) -> Optional[pulumi.Input[str]]:
        """
        gateway ID.
        """
        return pulumi.get(self, "gateway_id")

    @gateway_id.setter
    def gateway_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "gateway_id", value)

    @property
    @pulumi.getter(name="groupId")
    def group_id(self) -> Optional[pulumi.Input[str]]:
        """
        group ID.
        """
        return pulumi.get(self, "group_id")

    @group_id.setter
    def group_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "group_id", value)

    @property
    @pulumi.getter
    def option(self) -> Optional[pulumi.Input[str]]:
        """
        `bind` or `unbind`.
        """
        return pulumi.get(self, "option")

    @option.setter
    def option(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "option", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[str]]:
        """
        Binding status.
        """
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "status", value)

    @property
    @pulumi.getter(name="strategyId")
    def strategy_id(self) -> Optional[pulumi.Input[str]]:
        """
        strategy ID.
        """
        return pulumi.get(self, "strategy_id")

    @strategy_id.setter
    def strategy_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "strategy_id", value)


class CngwStrategyBindGroup(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 gateway_id: Optional[pulumi.Input[str]] = None,
                 group_id: Optional[pulumi.Input[str]] = None,
                 option: Optional[pulumi.Input[str]] = None,
                 strategy_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a resource to create a tse cngw_strategy_bind_group

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        cngw_strategy_bind_group = tencentcloud.tse.CngwStrategyBindGroup("cngwStrategyBindGroup",
            gateway_id="gateway-cf8c99c3",
            group_id="group-a160d123",
            option="bind",
            strategy_id="strategy-806ea0dd")
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        tse cngw_strategy_bind_group can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Tse/cngwStrategyBindGroup:CngwStrategyBindGroup cngw_strategy_bind_group cngw_strategy_bind_group_id
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] gateway_id: gateway ID.
        :param pulumi.Input[str] group_id: group ID.
        :param pulumi.Input[str] option: `bind` or `unbind`.
        :param pulumi.Input[str] strategy_id: strategy ID.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: CngwStrategyBindGroupArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a tse cngw_strategy_bind_group

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        cngw_strategy_bind_group = tencentcloud.tse.CngwStrategyBindGroup("cngwStrategyBindGroup",
            gateway_id="gateway-cf8c99c3",
            group_id="group-a160d123",
            option="bind",
            strategy_id="strategy-806ea0dd")
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        tse cngw_strategy_bind_group can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Tse/cngwStrategyBindGroup:CngwStrategyBindGroup cngw_strategy_bind_group cngw_strategy_bind_group_id
        ```

        :param str resource_name: The name of the resource.
        :param CngwStrategyBindGroupArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(CngwStrategyBindGroupArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 gateway_id: Optional[pulumi.Input[str]] = None,
                 group_id: Optional[pulumi.Input[str]] = None,
                 option: Optional[pulumi.Input[str]] = None,
                 strategy_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = CngwStrategyBindGroupArgs.__new__(CngwStrategyBindGroupArgs)

            if gateway_id is None and not opts.urn:
                raise TypeError("Missing required property 'gateway_id'")
            __props__.__dict__["gateway_id"] = gateway_id
            if group_id is None and not opts.urn:
                raise TypeError("Missing required property 'group_id'")
            __props__.__dict__["group_id"] = group_id
            if option is None and not opts.urn:
                raise TypeError("Missing required property 'option'")
            __props__.__dict__["option"] = option
            if strategy_id is None and not opts.urn:
                raise TypeError("Missing required property 'strategy_id'")
            __props__.__dict__["strategy_id"] = strategy_id
            __props__.__dict__["status"] = None
        super(CngwStrategyBindGroup, __self__).__init__(
            'tencentcloud:Tse/cngwStrategyBindGroup:CngwStrategyBindGroup',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            gateway_id: Optional[pulumi.Input[str]] = None,
            group_id: Optional[pulumi.Input[str]] = None,
            option: Optional[pulumi.Input[str]] = None,
            status: Optional[pulumi.Input[str]] = None,
            strategy_id: Optional[pulumi.Input[str]] = None) -> 'CngwStrategyBindGroup':
        """
        Get an existing CngwStrategyBindGroup resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] gateway_id: gateway ID.
        :param pulumi.Input[str] group_id: group ID.
        :param pulumi.Input[str] option: `bind` or `unbind`.
        :param pulumi.Input[str] status: Binding status.
        :param pulumi.Input[str] strategy_id: strategy ID.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _CngwStrategyBindGroupState.__new__(_CngwStrategyBindGroupState)

        __props__.__dict__["gateway_id"] = gateway_id
        __props__.__dict__["group_id"] = group_id
        __props__.__dict__["option"] = option
        __props__.__dict__["status"] = status
        __props__.__dict__["strategy_id"] = strategy_id
        return CngwStrategyBindGroup(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="gatewayId")
    def gateway_id(self) -> pulumi.Output[str]:
        """
        gateway ID.
        """
        return pulumi.get(self, "gateway_id")

    @property
    @pulumi.getter(name="groupId")
    def group_id(self) -> pulumi.Output[str]:
        """
        group ID.
        """
        return pulumi.get(self, "group_id")

    @property
    @pulumi.getter
    def option(self) -> pulumi.Output[str]:
        """
        `bind` or `unbind`.
        """
        return pulumi.get(self, "option")

    @property
    @pulumi.getter
    def status(self) -> pulumi.Output[str]:
        """
        Binding status.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter(name="strategyId")
    def strategy_id(self) -> pulumi.Output[str]:
        """
        strategy ID.
        """
        return pulumi.get(self, "strategy_id")
