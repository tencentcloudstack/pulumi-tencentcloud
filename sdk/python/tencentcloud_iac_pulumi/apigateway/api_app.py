# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['ApiAppArgs', 'ApiApp']

@pulumi.input_type
class ApiAppArgs:
    def __init__(__self__, *,
                 api_app_name: pulumi.Input[str],
                 api_app_desc: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, Any]]] = None):
        """
        The set of arguments for constructing a ApiApp resource.
        :param pulumi.Input[str] api_app_name: Api app name.
        :param pulumi.Input[str] api_app_desc: App description.
        :param pulumi.Input[Mapping[str, Any]] tags: Tag description list.
        """
        pulumi.set(__self__, "api_app_name", api_app_name)
        if api_app_desc is not None:
            pulumi.set(__self__, "api_app_desc", api_app_desc)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter(name="apiAppName")
    def api_app_name(self) -> pulumi.Input[str]:
        """
        Api app name.
        """
        return pulumi.get(self, "api_app_name")

    @api_app_name.setter
    def api_app_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "api_app_name", value)

    @property
    @pulumi.getter(name="apiAppDesc")
    def api_app_desc(self) -> Optional[pulumi.Input[str]]:
        """
        App description.
        """
        return pulumi.get(self, "api_app_desc")

    @api_app_desc.setter
    def api_app_desc(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "api_app_desc", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Mapping[str, Any]]]:
        """
        Tag description list.
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Mapping[str, Any]]]):
        pulumi.set(self, "tags", value)


@pulumi.input_type
class _ApiAppState:
    def __init__(__self__, *,
                 api_app_desc: Optional[pulumi.Input[str]] = None,
                 api_app_id: Optional[pulumi.Input[str]] = None,
                 api_app_key: Optional[pulumi.Input[str]] = None,
                 api_app_name: Optional[pulumi.Input[str]] = None,
                 api_app_secret: Optional[pulumi.Input[str]] = None,
                 created_time: Optional[pulumi.Input[str]] = None,
                 modified_time: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, Any]]] = None):
        """
        Input properties used for looking up and filtering ApiApp resources.
        :param pulumi.Input[str] api_app_desc: App description.
        :param pulumi.Input[str] api_app_id: Api app ID.
        :param pulumi.Input[str] api_app_key: Api app key.
        :param pulumi.Input[str] api_app_name: Api app name.
        :param pulumi.Input[str] api_app_secret: Api app secret.
        :param pulumi.Input[str] created_time: Api app created time.
        :param pulumi.Input[str] modified_time: Api app modified time.
        :param pulumi.Input[Mapping[str, Any]] tags: Tag description list.
        """
        if api_app_desc is not None:
            pulumi.set(__self__, "api_app_desc", api_app_desc)
        if api_app_id is not None:
            pulumi.set(__self__, "api_app_id", api_app_id)
        if api_app_key is not None:
            pulumi.set(__self__, "api_app_key", api_app_key)
        if api_app_name is not None:
            pulumi.set(__self__, "api_app_name", api_app_name)
        if api_app_secret is not None:
            pulumi.set(__self__, "api_app_secret", api_app_secret)
        if created_time is not None:
            pulumi.set(__self__, "created_time", created_time)
        if modified_time is not None:
            pulumi.set(__self__, "modified_time", modified_time)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter(name="apiAppDesc")
    def api_app_desc(self) -> Optional[pulumi.Input[str]]:
        """
        App description.
        """
        return pulumi.get(self, "api_app_desc")

    @api_app_desc.setter
    def api_app_desc(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "api_app_desc", value)

    @property
    @pulumi.getter(name="apiAppId")
    def api_app_id(self) -> Optional[pulumi.Input[str]]:
        """
        Api app ID.
        """
        return pulumi.get(self, "api_app_id")

    @api_app_id.setter
    def api_app_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "api_app_id", value)

    @property
    @pulumi.getter(name="apiAppKey")
    def api_app_key(self) -> Optional[pulumi.Input[str]]:
        """
        Api app key.
        """
        return pulumi.get(self, "api_app_key")

    @api_app_key.setter
    def api_app_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "api_app_key", value)

    @property
    @pulumi.getter(name="apiAppName")
    def api_app_name(self) -> Optional[pulumi.Input[str]]:
        """
        Api app name.
        """
        return pulumi.get(self, "api_app_name")

    @api_app_name.setter
    def api_app_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "api_app_name", value)

    @property
    @pulumi.getter(name="apiAppSecret")
    def api_app_secret(self) -> Optional[pulumi.Input[str]]:
        """
        Api app secret.
        """
        return pulumi.get(self, "api_app_secret")

    @api_app_secret.setter
    def api_app_secret(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "api_app_secret", value)

    @property
    @pulumi.getter(name="createdTime")
    def created_time(self) -> Optional[pulumi.Input[str]]:
        """
        Api app created time.
        """
        return pulumi.get(self, "created_time")

    @created_time.setter
    def created_time(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "created_time", value)

    @property
    @pulumi.getter(name="modifiedTime")
    def modified_time(self) -> Optional[pulumi.Input[str]]:
        """
        Api app modified time.
        """
        return pulumi.get(self, "modified_time")

    @modified_time.setter
    def modified_time(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "modified_time", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Mapping[str, Any]]]:
        """
        Tag description list.
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Mapping[str, Any]]]):
        pulumi.set(self, "tags", value)


class ApiApp(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 api_app_desc: Optional[pulumi.Input[str]] = None,
                 api_app_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 __props__=None):
        """
        Provides a resource to create a APIGateway ApiApp

        ## Example Usage

        ### Create a basic apigateway api_app

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        example = tencentcloud.api_gateway.ApiApp("example",
            api_app_desc="app desc.",
            api_app_name="tf_example")
        ```
        <!--End PulumiCodeChooser -->

        ### Bind Tag

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        example = tencentcloud.api_gateway.ApiApp("example",
            api_app_desc="app desc.",
            api_app_name="tf_example",
            tags={
                "createdBy": "terraform",
            })
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        apigateway api_app can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:ApiGateway/apiApp:ApiApp example app-poe0pyex
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] api_app_desc: App description.
        :param pulumi.Input[str] api_app_name: Api app name.
        :param pulumi.Input[Mapping[str, Any]] tags: Tag description list.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ApiAppArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a APIGateway ApiApp

        ## Example Usage

        ### Create a basic apigateway api_app

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        example = tencentcloud.api_gateway.ApiApp("example",
            api_app_desc="app desc.",
            api_app_name="tf_example")
        ```
        <!--End PulumiCodeChooser -->

        ### Bind Tag

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        example = tencentcloud.api_gateway.ApiApp("example",
            api_app_desc="app desc.",
            api_app_name="tf_example",
            tags={
                "createdBy": "terraform",
            })
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        apigateway api_app can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:ApiGateway/apiApp:ApiApp example app-poe0pyex
        ```

        :param str resource_name: The name of the resource.
        :param ApiAppArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ApiAppArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 api_app_desc: Optional[pulumi.Input[str]] = None,
                 api_app_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ApiAppArgs.__new__(ApiAppArgs)

            __props__.__dict__["api_app_desc"] = api_app_desc
            if api_app_name is None and not opts.urn:
                raise TypeError("Missing required property 'api_app_name'")
            __props__.__dict__["api_app_name"] = api_app_name
            __props__.__dict__["tags"] = tags
            __props__.__dict__["api_app_id"] = None
            __props__.__dict__["api_app_key"] = None
            __props__.__dict__["api_app_secret"] = None
            __props__.__dict__["created_time"] = None
            __props__.__dict__["modified_time"] = None
        super(ApiApp, __self__).__init__(
            'tencentcloud:ApiGateway/apiApp:ApiApp',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            api_app_desc: Optional[pulumi.Input[str]] = None,
            api_app_id: Optional[pulumi.Input[str]] = None,
            api_app_key: Optional[pulumi.Input[str]] = None,
            api_app_name: Optional[pulumi.Input[str]] = None,
            api_app_secret: Optional[pulumi.Input[str]] = None,
            created_time: Optional[pulumi.Input[str]] = None,
            modified_time: Optional[pulumi.Input[str]] = None,
            tags: Optional[pulumi.Input[Mapping[str, Any]]] = None) -> 'ApiApp':
        """
        Get an existing ApiApp resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] api_app_desc: App description.
        :param pulumi.Input[str] api_app_id: Api app ID.
        :param pulumi.Input[str] api_app_key: Api app key.
        :param pulumi.Input[str] api_app_name: Api app name.
        :param pulumi.Input[str] api_app_secret: Api app secret.
        :param pulumi.Input[str] created_time: Api app created time.
        :param pulumi.Input[str] modified_time: Api app modified time.
        :param pulumi.Input[Mapping[str, Any]] tags: Tag description list.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ApiAppState.__new__(_ApiAppState)

        __props__.__dict__["api_app_desc"] = api_app_desc
        __props__.__dict__["api_app_id"] = api_app_id
        __props__.__dict__["api_app_key"] = api_app_key
        __props__.__dict__["api_app_name"] = api_app_name
        __props__.__dict__["api_app_secret"] = api_app_secret
        __props__.__dict__["created_time"] = created_time
        __props__.__dict__["modified_time"] = modified_time
        __props__.__dict__["tags"] = tags
        return ApiApp(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="apiAppDesc")
    def api_app_desc(self) -> pulumi.Output[str]:
        """
        App description.
        """
        return pulumi.get(self, "api_app_desc")

    @property
    @pulumi.getter(name="apiAppId")
    def api_app_id(self) -> pulumi.Output[str]:
        """
        Api app ID.
        """
        return pulumi.get(self, "api_app_id")

    @property
    @pulumi.getter(name="apiAppKey")
    def api_app_key(self) -> pulumi.Output[str]:
        """
        Api app key.
        """
        return pulumi.get(self, "api_app_key")

    @property
    @pulumi.getter(name="apiAppName")
    def api_app_name(self) -> pulumi.Output[str]:
        """
        Api app name.
        """
        return pulumi.get(self, "api_app_name")

    @property
    @pulumi.getter(name="apiAppSecret")
    def api_app_secret(self) -> pulumi.Output[str]:
        """
        Api app secret.
        """
        return pulumi.get(self, "api_app_secret")

    @property
    @pulumi.getter(name="createdTime")
    def created_time(self) -> pulumi.Output[str]:
        """
        Api app created time.
        """
        return pulumi.get(self, "created_time")

    @property
    @pulumi.getter(name="modifiedTime")
    def modified_time(self) -> pulumi.Output[str]:
        """
        Api app modified time.
        """
        return pulumi.get(self, "modified_time")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, Any]]]:
        """
        Tag description list.
        """
        return pulumi.get(self, "tags")

