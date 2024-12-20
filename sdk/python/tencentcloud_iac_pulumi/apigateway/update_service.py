# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['UpdateServiceArgs', 'UpdateService']

@pulumi.input_type
class UpdateServiceArgs:
    def __init__(__self__, *,
                 environment_name: pulumi.Input[str],
                 service_id: pulumi.Input[str],
                 version_name: pulumi.Input[str]):
        """
        The set of arguments for constructing a UpdateService resource.
        :param pulumi.Input[str] environment_name: The name of the environment to be switched, currently supporting three environments: test (test environment), prepub (pre release environment), and release (release environment).
        :param pulumi.Input[str] service_id: Service ID.
        :param pulumi.Input[str] version_name: The version number of the switch.
        """
        pulumi.set(__self__, "environment_name", environment_name)
        pulumi.set(__self__, "service_id", service_id)
        pulumi.set(__self__, "version_name", version_name)

    @property
    @pulumi.getter(name="environmentName")
    def environment_name(self) -> pulumi.Input[str]:
        """
        The name of the environment to be switched, currently supporting three environments: test (test environment), prepub (pre release environment), and release (release environment).
        """
        return pulumi.get(self, "environment_name")

    @environment_name.setter
    def environment_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "environment_name", value)

    @property
    @pulumi.getter(name="serviceId")
    def service_id(self) -> pulumi.Input[str]:
        """
        Service ID.
        """
        return pulumi.get(self, "service_id")

    @service_id.setter
    def service_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "service_id", value)

    @property
    @pulumi.getter(name="versionName")
    def version_name(self) -> pulumi.Input[str]:
        """
        The version number of the switch.
        """
        return pulumi.get(self, "version_name")

    @version_name.setter
    def version_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "version_name", value)


@pulumi.input_type
class _UpdateServiceState:
    def __init__(__self__, *,
                 environment_name: Optional[pulumi.Input[str]] = None,
                 service_id: Optional[pulumi.Input[str]] = None,
                 version_name: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering UpdateService resources.
        :param pulumi.Input[str] environment_name: The name of the environment to be switched, currently supporting three environments: test (test environment), prepub (pre release environment), and release (release environment).
        :param pulumi.Input[str] service_id: Service ID.
        :param pulumi.Input[str] version_name: The version number of the switch.
        """
        if environment_name is not None:
            pulumi.set(__self__, "environment_name", environment_name)
        if service_id is not None:
            pulumi.set(__self__, "service_id", service_id)
        if version_name is not None:
            pulumi.set(__self__, "version_name", version_name)

    @property
    @pulumi.getter(name="environmentName")
    def environment_name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the environment to be switched, currently supporting three environments: test (test environment), prepub (pre release environment), and release (release environment).
        """
        return pulumi.get(self, "environment_name")

    @environment_name.setter
    def environment_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "environment_name", value)

    @property
    @pulumi.getter(name="serviceId")
    def service_id(self) -> Optional[pulumi.Input[str]]:
        """
        Service ID.
        """
        return pulumi.get(self, "service_id")

    @service_id.setter
    def service_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "service_id", value)

    @property
    @pulumi.getter(name="versionName")
    def version_name(self) -> Optional[pulumi.Input[str]]:
        """
        The version number of the switch.
        """
        return pulumi.get(self, "version_name")

    @version_name.setter
    def version_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "version_name", value)


class UpdateService(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 environment_name: Optional[pulumi.Input[str]] = None,
                 service_id: Optional[pulumi.Input[str]] = None,
                 version_name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a resource to create a apigateway update_service

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        example = tencentcloud.api_gateway.UpdateService("example",
            environment_name="test",
            service_id="service-oczq2nyk",
            version_name="20240204142759-b5a4f741-adc0-4964-b01b-2a4a04ff6964")
        ```
        <!--End PulumiCodeChooser -->

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] environment_name: The name of the environment to be switched, currently supporting three environments: test (test environment), prepub (pre release environment), and release (release environment).
        :param pulumi.Input[str] service_id: Service ID.
        :param pulumi.Input[str] version_name: The version number of the switch.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: UpdateServiceArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a apigateway update_service

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        example = tencentcloud.api_gateway.UpdateService("example",
            environment_name="test",
            service_id="service-oczq2nyk",
            version_name="20240204142759-b5a4f741-adc0-4964-b01b-2a4a04ff6964")
        ```
        <!--End PulumiCodeChooser -->

        :param str resource_name: The name of the resource.
        :param UpdateServiceArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(UpdateServiceArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 environment_name: Optional[pulumi.Input[str]] = None,
                 service_id: Optional[pulumi.Input[str]] = None,
                 version_name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = UpdateServiceArgs.__new__(UpdateServiceArgs)

            if environment_name is None and not opts.urn:
                raise TypeError("Missing required property 'environment_name'")
            __props__.__dict__["environment_name"] = environment_name
            if service_id is None and not opts.urn:
                raise TypeError("Missing required property 'service_id'")
            __props__.__dict__["service_id"] = service_id
            if version_name is None and not opts.urn:
                raise TypeError("Missing required property 'version_name'")
            __props__.__dict__["version_name"] = version_name
        super(UpdateService, __self__).__init__(
            'tencentcloud:ApiGateway/updateService:UpdateService',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            environment_name: Optional[pulumi.Input[str]] = None,
            service_id: Optional[pulumi.Input[str]] = None,
            version_name: Optional[pulumi.Input[str]] = None) -> 'UpdateService':
        """
        Get an existing UpdateService resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] environment_name: The name of the environment to be switched, currently supporting three environments: test (test environment), prepub (pre release environment), and release (release environment).
        :param pulumi.Input[str] service_id: Service ID.
        :param pulumi.Input[str] version_name: The version number of the switch.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _UpdateServiceState.__new__(_UpdateServiceState)

        __props__.__dict__["environment_name"] = environment_name
        __props__.__dict__["service_id"] = service_id
        __props__.__dict__["version_name"] = version_name
        return UpdateService(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="environmentName")
    def environment_name(self) -> pulumi.Output[str]:
        """
        The name of the environment to be switched, currently supporting three environments: test (test environment), prepub (pre release environment), and release (release environment).
        """
        return pulumi.get(self, "environment_name")

    @property
    @pulumi.getter(name="serviceId")
    def service_id(self) -> pulumi.Output[str]:
        """
        Service ID.
        """
        return pulumi.get(self, "service_id")

    @property
    @pulumi.getter(name="versionName")
    def version_name(self) -> pulumi.Output[str]:
        """
        The version number of the switch.
        """
        return pulumi.get(self, "version_name")

