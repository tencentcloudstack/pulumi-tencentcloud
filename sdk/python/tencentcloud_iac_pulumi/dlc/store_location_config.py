# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['StoreLocationConfigArgs', 'StoreLocationConfig']

@pulumi.input_type
class StoreLocationConfigArgs:
    def __init__(__self__, *,
                 enable: pulumi.Input[int],
                 store_location: pulumi.Input[str]):
        """
        The set of arguments for constructing a StoreLocationConfig resource.
        :param pulumi.Input[int] enable: Whether to enable advanced settings: 0-no, 1-yes.
        :param pulumi.Input[str] store_location: The calculation results are stored in the cos path, such as: cosn://bucketname/.
        """
        pulumi.set(__self__, "enable", enable)
        pulumi.set(__self__, "store_location", store_location)

    @property
    @pulumi.getter
    def enable(self) -> pulumi.Input[int]:
        """
        Whether to enable advanced settings: 0-no, 1-yes.
        """
        return pulumi.get(self, "enable")

    @enable.setter
    def enable(self, value: pulumi.Input[int]):
        pulumi.set(self, "enable", value)

    @property
    @pulumi.getter(name="storeLocation")
    def store_location(self) -> pulumi.Input[str]:
        """
        The calculation results are stored in the cos path, such as: cosn://bucketname/.
        """
        return pulumi.get(self, "store_location")

    @store_location.setter
    def store_location(self, value: pulumi.Input[str]):
        pulumi.set(self, "store_location", value)


@pulumi.input_type
class _StoreLocationConfigState:
    def __init__(__self__, *,
                 enable: Optional[pulumi.Input[int]] = None,
                 store_location: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering StoreLocationConfig resources.
        :param pulumi.Input[int] enable: Whether to enable advanced settings: 0-no, 1-yes.
        :param pulumi.Input[str] store_location: The calculation results are stored in the cos path, such as: cosn://bucketname/.
        """
        if enable is not None:
            pulumi.set(__self__, "enable", enable)
        if store_location is not None:
            pulumi.set(__self__, "store_location", store_location)

    @property
    @pulumi.getter
    def enable(self) -> Optional[pulumi.Input[int]]:
        """
        Whether to enable advanced settings: 0-no, 1-yes.
        """
        return pulumi.get(self, "enable")

    @enable.setter
    def enable(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "enable", value)

    @property
    @pulumi.getter(name="storeLocation")
    def store_location(self) -> Optional[pulumi.Input[str]]:
        """
        The calculation results are stored in the cos path, such as: cosn://bucketname/.
        """
        return pulumi.get(self, "store_location")

    @store_location.setter
    def store_location(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "store_location", value)


class StoreLocationConfig(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 enable: Optional[pulumi.Input[int]] = None,
                 store_location: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a resource to create a dlc store_location_config

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        store_location_config = tencentcloud.dlc.StoreLocationConfig("storeLocationConfig",
            enable=1,
            store_location="cosn://bucketname/")
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        dlc store_location_config can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Dlc/storeLocationConfig:StoreLocationConfig store_location_config store_location_config_id
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[int] enable: Whether to enable advanced settings: 0-no, 1-yes.
        :param pulumi.Input[str] store_location: The calculation results are stored in the cos path, such as: cosn://bucketname/.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: StoreLocationConfigArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a dlc store_location_config

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        store_location_config = tencentcloud.dlc.StoreLocationConfig("storeLocationConfig",
            enable=1,
            store_location="cosn://bucketname/")
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        dlc store_location_config can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Dlc/storeLocationConfig:StoreLocationConfig store_location_config store_location_config_id
        ```

        :param str resource_name: The name of the resource.
        :param StoreLocationConfigArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(StoreLocationConfigArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 enable: Optional[pulumi.Input[int]] = None,
                 store_location: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = StoreLocationConfigArgs.__new__(StoreLocationConfigArgs)

            if enable is None and not opts.urn:
                raise TypeError("Missing required property 'enable'")
            __props__.__dict__["enable"] = enable
            if store_location is None and not opts.urn:
                raise TypeError("Missing required property 'store_location'")
            __props__.__dict__["store_location"] = store_location
        super(StoreLocationConfig, __self__).__init__(
            'tencentcloud:Dlc/storeLocationConfig:StoreLocationConfig',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            enable: Optional[pulumi.Input[int]] = None,
            store_location: Optional[pulumi.Input[str]] = None) -> 'StoreLocationConfig':
        """
        Get an existing StoreLocationConfig resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[int] enable: Whether to enable advanced settings: 0-no, 1-yes.
        :param pulumi.Input[str] store_location: The calculation results are stored in the cos path, such as: cosn://bucketname/.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _StoreLocationConfigState.__new__(_StoreLocationConfigState)

        __props__.__dict__["enable"] = enable
        __props__.__dict__["store_location"] = store_location
        return StoreLocationConfig(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def enable(self) -> pulumi.Output[int]:
        """
        Whether to enable advanced settings: 0-no, 1-yes.
        """
        return pulumi.get(self, "enable")

    @property
    @pulumi.getter(name="storeLocation")
    def store_location(self) -> pulumi.Output[str]:
        """
        The calculation results are stored in the cos path, such as: cosn://bucketname/.
        """
        return pulumi.get(self, "store_location")

