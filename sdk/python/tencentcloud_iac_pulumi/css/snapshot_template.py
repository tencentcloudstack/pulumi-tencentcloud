# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['SnapshotTemplateArgs', 'SnapshotTemplate']

@pulumi.input_type
class SnapshotTemplateArgs:
    def __init__(__self__, *,
                 cos_app_id: pulumi.Input[int],
                 cos_bucket: pulumi.Input[str],
                 cos_region: pulumi.Input[str],
                 template_name: pulumi.Input[str],
                 cos_file_name: Optional[pulumi.Input[str]] = None,
                 cos_prefix: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 height: Optional[pulumi.Input[int]] = None,
                 porn_flag: Optional[pulumi.Input[int]] = None,
                 snapshot_interval: Optional[pulumi.Input[int]] = None,
                 width: Optional[pulumi.Input[int]] = None):
        """
        The set of arguments for constructing a SnapshotTemplate resource.
        :param pulumi.Input[int] cos_app_id: Cos application ID.
        :param pulumi.Input[str] cos_bucket: Cos bucket name. Note: The CosBucket parameter value cannot include the - [appid] part.
        :param pulumi.Input[str] cos_region: Cos region.
        :param pulumi.Input[str] template_name: Template name. Maximum length: 255 bytes. Only Chinese, English, numbers, `_`, `-` are supported.
        :param pulumi.Input[str] cos_file_name: Cos file name. If it is empty, set according to the default value {StreamID}-screenshot-{Hour}-{Minute}-{Second}-{Width}x{Height}{Ext}.
        :param pulumi.Input[str] cos_prefix: Cos Bucket folder prefix. If it is empty, set according to the default value /{Year}-{Month}-{Day}/.
        :param pulumi.Input[str] description: Description information. Maximum length: 1024 bytes. Only `Chinese`, `English`, `numbers`, `_`, `-` are supported.
        :param pulumi.Input[int] height: Screenshot height. Default: 0 (original height). Range: 0-2000.
        :param pulumi.Input[int] porn_flag: Whether porn is enabled, 0: not enabled, 1: enabled. Default: 0.
        :param pulumi.Input[int] snapshot_interval: Screenshot interval, unit: s, default: 10s. Range: 2s~300s.
        :param pulumi.Input[int] width: Screenshot width. Default: 0 (original width). Range: 0-3000.
        """
        pulumi.set(__self__, "cos_app_id", cos_app_id)
        pulumi.set(__self__, "cos_bucket", cos_bucket)
        pulumi.set(__self__, "cos_region", cos_region)
        pulumi.set(__self__, "template_name", template_name)
        if cos_file_name is not None:
            pulumi.set(__self__, "cos_file_name", cos_file_name)
        if cos_prefix is not None:
            pulumi.set(__self__, "cos_prefix", cos_prefix)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if height is not None:
            pulumi.set(__self__, "height", height)
        if porn_flag is not None:
            pulumi.set(__self__, "porn_flag", porn_flag)
        if snapshot_interval is not None:
            pulumi.set(__self__, "snapshot_interval", snapshot_interval)
        if width is not None:
            pulumi.set(__self__, "width", width)

    @property
    @pulumi.getter(name="cosAppId")
    def cos_app_id(self) -> pulumi.Input[int]:
        """
        Cos application ID.
        """
        return pulumi.get(self, "cos_app_id")

    @cos_app_id.setter
    def cos_app_id(self, value: pulumi.Input[int]):
        pulumi.set(self, "cos_app_id", value)

    @property
    @pulumi.getter(name="cosBucket")
    def cos_bucket(self) -> pulumi.Input[str]:
        """
        Cos bucket name. Note: The CosBucket parameter value cannot include the - [appid] part.
        """
        return pulumi.get(self, "cos_bucket")

    @cos_bucket.setter
    def cos_bucket(self, value: pulumi.Input[str]):
        pulumi.set(self, "cos_bucket", value)

    @property
    @pulumi.getter(name="cosRegion")
    def cos_region(self) -> pulumi.Input[str]:
        """
        Cos region.
        """
        return pulumi.get(self, "cos_region")

    @cos_region.setter
    def cos_region(self, value: pulumi.Input[str]):
        pulumi.set(self, "cos_region", value)

    @property
    @pulumi.getter(name="templateName")
    def template_name(self) -> pulumi.Input[str]:
        """
        Template name. Maximum length: 255 bytes. Only Chinese, English, numbers, `_`, `-` are supported.
        """
        return pulumi.get(self, "template_name")

    @template_name.setter
    def template_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "template_name", value)

    @property
    @pulumi.getter(name="cosFileName")
    def cos_file_name(self) -> Optional[pulumi.Input[str]]:
        """
        Cos file name. If it is empty, set according to the default value {StreamID}-screenshot-{Hour}-{Minute}-{Second}-{Width}x{Height}{Ext}.
        """
        return pulumi.get(self, "cos_file_name")

    @cos_file_name.setter
    def cos_file_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cos_file_name", value)

    @property
    @pulumi.getter(name="cosPrefix")
    def cos_prefix(self) -> Optional[pulumi.Input[str]]:
        """
        Cos Bucket folder prefix. If it is empty, set according to the default value /{Year}-{Month}-{Day}/.
        """
        return pulumi.get(self, "cos_prefix")

    @cos_prefix.setter
    def cos_prefix(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cos_prefix", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Description information. Maximum length: 1024 bytes. Only `Chinese`, `English`, `numbers`, `_`, `-` are supported.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def height(self) -> Optional[pulumi.Input[int]]:
        """
        Screenshot height. Default: 0 (original height). Range: 0-2000.
        """
        return pulumi.get(self, "height")

    @height.setter
    def height(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "height", value)

    @property
    @pulumi.getter(name="pornFlag")
    def porn_flag(self) -> Optional[pulumi.Input[int]]:
        """
        Whether porn is enabled, 0: not enabled, 1: enabled. Default: 0.
        """
        return pulumi.get(self, "porn_flag")

    @porn_flag.setter
    def porn_flag(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "porn_flag", value)

    @property
    @pulumi.getter(name="snapshotInterval")
    def snapshot_interval(self) -> Optional[pulumi.Input[int]]:
        """
        Screenshot interval, unit: s, default: 10s. Range: 2s~300s.
        """
        return pulumi.get(self, "snapshot_interval")

    @snapshot_interval.setter
    def snapshot_interval(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "snapshot_interval", value)

    @property
    @pulumi.getter
    def width(self) -> Optional[pulumi.Input[int]]:
        """
        Screenshot width. Default: 0 (original width). Range: 0-3000.
        """
        return pulumi.get(self, "width")

    @width.setter
    def width(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "width", value)


@pulumi.input_type
class _SnapshotTemplateState:
    def __init__(__self__, *,
                 cos_app_id: Optional[pulumi.Input[int]] = None,
                 cos_bucket: Optional[pulumi.Input[str]] = None,
                 cos_file_name: Optional[pulumi.Input[str]] = None,
                 cos_prefix: Optional[pulumi.Input[str]] = None,
                 cos_region: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 height: Optional[pulumi.Input[int]] = None,
                 porn_flag: Optional[pulumi.Input[int]] = None,
                 snapshot_interval: Optional[pulumi.Input[int]] = None,
                 template_name: Optional[pulumi.Input[str]] = None,
                 width: Optional[pulumi.Input[int]] = None):
        """
        Input properties used for looking up and filtering SnapshotTemplate resources.
        :param pulumi.Input[int] cos_app_id: Cos application ID.
        :param pulumi.Input[str] cos_bucket: Cos bucket name. Note: The CosBucket parameter value cannot include the - [appid] part.
        :param pulumi.Input[str] cos_file_name: Cos file name. If it is empty, set according to the default value {StreamID}-screenshot-{Hour}-{Minute}-{Second}-{Width}x{Height}{Ext}.
        :param pulumi.Input[str] cos_prefix: Cos Bucket folder prefix. If it is empty, set according to the default value /{Year}-{Month}-{Day}/.
        :param pulumi.Input[str] cos_region: Cos region.
        :param pulumi.Input[str] description: Description information. Maximum length: 1024 bytes. Only `Chinese`, `English`, `numbers`, `_`, `-` are supported.
        :param pulumi.Input[int] height: Screenshot height. Default: 0 (original height). Range: 0-2000.
        :param pulumi.Input[int] porn_flag: Whether porn is enabled, 0: not enabled, 1: enabled. Default: 0.
        :param pulumi.Input[int] snapshot_interval: Screenshot interval, unit: s, default: 10s. Range: 2s~300s.
        :param pulumi.Input[str] template_name: Template name. Maximum length: 255 bytes. Only Chinese, English, numbers, `_`, `-` are supported.
        :param pulumi.Input[int] width: Screenshot width. Default: 0 (original width). Range: 0-3000.
        """
        if cos_app_id is not None:
            pulumi.set(__self__, "cos_app_id", cos_app_id)
        if cos_bucket is not None:
            pulumi.set(__self__, "cos_bucket", cos_bucket)
        if cos_file_name is not None:
            pulumi.set(__self__, "cos_file_name", cos_file_name)
        if cos_prefix is not None:
            pulumi.set(__self__, "cos_prefix", cos_prefix)
        if cos_region is not None:
            pulumi.set(__self__, "cos_region", cos_region)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if height is not None:
            pulumi.set(__self__, "height", height)
        if porn_flag is not None:
            pulumi.set(__self__, "porn_flag", porn_flag)
        if snapshot_interval is not None:
            pulumi.set(__self__, "snapshot_interval", snapshot_interval)
        if template_name is not None:
            pulumi.set(__self__, "template_name", template_name)
        if width is not None:
            pulumi.set(__self__, "width", width)

    @property
    @pulumi.getter(name="cosAppId")
    def cos_app_id(self) -> Optional[pulumi.Input[int]]:
        """
        Cos application ID.
        """
        return pulumi.get(self, "cos_app_id")

    @cos_app_id.setter
    def cos_app_id(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "cos_app_id", value)

    @property
    @pulumi.getter(name="cosBucket")
    def cos_bucket(self) -> Optional[pulumi.Input[str]]:
        """
        Cos bucket name. Note: The CosBucket parameter value cannot include the - [appid] part.
        """
        return pulumi.get(self, "cos_bucket")

    @cos_bucket.setter
    def cos_bucket(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cos_bucket", value)

    @property
    @pulumi.getter(name="cosFileName")
    def cos_file_name(self) -> Optional[pulumi.Input[str]]:
        """
        Cos file name. If it is empty, set according to the default value {StreamID}-screenshot-{Hour}-{Minute}-{Second}-{Width}x{Height}{Ext}.
        """
        return pulumi.get(self, "cos_file_name")

    @cos_file_name.setter
    def cos_file_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cos_file_name", value)

    @property
    @pulumi.getter(name="cosPrefix")
    def cos_prefix(self) -> Optional[pulumi.Input[str]]:
        """
        Cos Bucket folder prefix. If it is empty, set according to the default value /{Year}-{Month}-{Day}/.
        """
        return pulumi.get(self, "cos_prefix")

    @cos_prefix.setter
    def cos_prefix(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cos_prefix", value)

    @property
    @pulumi.getter(name="cosRegion")
    def cos_region(self) -> Optional[pulumi.Input[str]]:
        """
        Cos region.
        """
        return pulumi.get(self, "cos_region")

    @cos_region.setter
    def cos_region(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cos_region", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Description information. Maximum length: 1024 bytes. Only `Chinese`, `English`, `numbers`, `_`, `-` are supported.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def height(self) -> Optional[pulumi.Input[int]]:
        """
        Screenshot height. Default: 0 (original height). Range: 0-2000.
        """
        return pulumi.get(self, "height")

    @height.setter
    def height(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "height", value)

    @property
    @pulumi.getter(name="pornFlag")
    def porn_flag(self) -> Optional[pulumi.Input[int]]:
        """
        Whether porn is enabled, 0: not enabled, 1: enabled. Default: 0.
        """
        return pulumi.get(self, "porn_flag")

    @porn_flag.setter
    def porn_flag(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "porn_flag", value)

    @property
    @pulumi.getter(name="snapshotInterval")
    def snapshot_interval(self) -> Optional[pulumi.Input[int]]:
        """
        Screenshot interval, unit: s, default: 10s. Range: 2s~300s.
        """
        return pulumi.get(self, "snapshot_interval")

    @snapshot_interval.setter
    def snapshot_interval(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "snapshot_interval", value)

    @property
    @pulumi.getter(name="templateName")
    def template_name(self) -> Optional[pulumi.Input[str]]:
        """
        Template name. Maximum length: 255 bytes. Only Chinese, English, numbers, `_`, `-` are supported.
        """
        return pulumi.get(self, "template_name")

    @template_name.setter
    def template_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "template_name", value)

    @property
    @pulumi.getter
    def width(self) -> Optional[pulumi.Input[int]]:
        """
        Screenshot width. Default: 0 (original width). Range: 0-3000.
        """
        return pulumi.get(self, "width")

    @width.setter
    def width(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "width", value)


class SnapshotTemplate(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cos_app_id: Optional[pulumi.Input[int]] = None,
                 cos_bucket: Optional[pulumi.Input[str]] = None,
                 cos_file_name: Optional[pulumi.Input[str]] = None,
                 cos_prefix: Optional[pulumi.Input[str]] = None,
                 cos_region: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 height: Optional[pulumi.Input[int]] = None,
                 porn_flag: Optional[pulumi.Input[int]] = None,
                 snapshot_interval: Optional[pulumi.Input[int]] = None,
                 template_name: Optional[pulumi.Input[str]] = None,
                 width: Optional[pulumi.Input[int]] = None,
                 __props__=None):
        """
        Provides a resource to create a css snapshot_template

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        snapshot_template = tencentcloud.css.SnapshotTemplate("snapshotTemplate",
            cos_app_id=1308919341,
            cos_bucket="keep-bucket",
            cos_region="ap-guangzhou",
            description="snapshot template",
            height=0,
            porn_flag=0,
            snapshot_interval=2,
            template_name="tf-snapshot-template",
            width=0)
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        css snapshot_template can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Css/snapshotTemplate:SnapshotTemplate snapshot_template templateId
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[int] cos_app_id: Cos application ID.
        :param pulumi.Input[str] cos_bucket: Cos bucket name. Note: The CosBucket parameter value cannot include the - [appid] part.
        :param pulumi.Input[str] cos_file_name: Cos file name. If it is empty, set according to the default value {StreamID}-screenshot-{Hour}-{Minute}-{Second}-{Width}x{Height}{Ext}.
        :param pulumi.Input[str] cos_prefix: Cos Bucket folder prefix. If it is empty, set according to the default value /{Year}-{Month}-{Day}/.
        :param pulumi.Input[str] cos_region: Cos region.
        :param pulumi.Input[str] description: Description information. Maximum length: 1024 bytes. Only `Chinese`, `English`, `numbers`, `_`, `-` are supported.
        :param pulumi.Input[int] height: Screenshot height. Default: 0 (original height). Range: 0-2000.
        :param pulumi.Input[int] porn_flag: Whether porn is enabled, 0: not enabled, 1: enabled. Default: 0.
        :param pulumi.Input[int] snapshot_interval: Screenshot interval, unit: s, default: 10s. Range: 2s~300s.
        :param pulumi.Input[str] template_name: Template name. Maximum length: 255 bytes. Only Chinese, English, numbers, `_`, `-` are supported.
        :param pulumi.Input[int] width: Screenshot width. Default: 0 (original width). Range: 0-3000.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: SnapshotTemplateArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a css snapshot_template

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        snapshot_template = tencentcloud.css.SnapshotTemplate("snapshotTemplate",
            cos_app_id=1308919341,
            cos_bucket="keep-bucket",
            cos_region="ap-guangzhou",
            description="snapshot template",
            height=0,
            porn_flag=0,
            snapshot_interval=2,
            template_name="tf-snapshot-template",
            width=0)
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        css snapshot_template can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Css/snapshotTemplate:SnapshotTemplate snapshot_template templateId
        ```

        :param str resource_name: The name of the resource.
        :param SnapshotTemplateArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(SnapshotTemplateArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cos_app_id: Optional[pulumi.Input[int]] = None,
                 cos_bucket: Optional[pulumi.Input[str]] = None,
                 cos_file_name: Optional[pulumi.Input[str]] = None,
                 cos_prefix: Optional[pulumi.Input[str]] = None,
                 cos_region: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 height: Optional[pulumi.Input[int]] = None,
                 porn_flag: Optional[pulumi.Input[int]] = None,
                 snapshot_interval: Optional[pulumi.Input[int]] = None,
                 template_name: Optional[pulumi.Input[str]] = None,
                 width: Optional[pulumi.Input[int]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = SnapshotTemplateArgs.__new__(SnapshotTemplateArgs)

            if cos_app_id is None and not opts.urn:
                raise TypeError("Missing required property 'cos_app_id'")
            __props__.__dict__["cos_app_id"] = cos_app_id
            if cos_bucket is None and not opts.urn:
                raise TypeError("Missing required property 'cos_bucket'")
            __props__.__dict__["cos_bucket"] = cos_bucket
            __props__.__dict__["cos_file_name"] = cos_file_name
            __props__.__dict__["cos_prefix"] = cos_prefix
            if cos_region is None and not opts.urn:
                raise TypeError("Missing required property 'cos_region'")
            __props__.__dict__["cos_region"] = cos_region
            __props__.__dict__["description"] = description
            __props__.__dict__["height"] = height
            __props__.__dict__["porn_flag"] = porn_flag
            __props__.__dict__["snapshot_interval"] = snapshot_interval
            if template_name is None and not opts.urn:
                raise TypeError("Missing required property 'template_name'")
            __props__.__dict__["template_name"] = template_name
            __props__.__dict__["width"] = width
        super(SnapshotTemplate, __self__).__init__(
            'tencentcloud:Css/snapshotTemplate:SnapshotTemplate',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            cos_app_id: Optional[pulumi.Input[int]] = None,
            cos_bucket: Optional[pulumi.Input[str]] = None,
            cos_file_name: Optional[pulumi.Input[str]] = None,
            cos_prefix: Optional[pulumi.Input[str]] = None,
            cos_region: Optional[pulumi.Input[str]] = None,
            description: Optional[pulumi.Input[str]] = None,
            height: Optional[pulumi.Input[int]] = None,
            porn_flag: Optional[pulumi.Input[int]] = None,
            snapshot_interval: Optional[pulumi.Input[int]] = None,
            template_name: Optional[pulumi.Input[str]] = None,
            width: Optional[pulumi.Input[int]] = None) -> 'SnapshotTemplate':
        """
        Get an existing SnapshotTemplate resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[int] cos_app_id: Cos application ID.
        :param pulumi.Input[str] cos_bucket: Cos bucket name. Note: The CosBucket parameter value cannot include the - [appid] part.
        :param pulumi.Input[str] cos_file_name: Cos file name. If it is empty, set according to the default value {StreamID}-screenshot-{Hour}-{Minute}-{Second}-{Width}x{Height}{Ext}.
        :param pulumi.Input[str] cos_prefix: Cos Bucket folder prefix. If it is empty, set according to the default value /{Year}-{Month}-{Day}/.
        :param pulumi.Input[str] cos_region: Cos region.
        :param pulumi.Input[str] description: Description information. Maximum length: 1024 bytes. Only `Chinese`, `English`, `numbers`, `_`, `-` are supported.
        :param pulumi.Input[int] height: Screenshot height. Default: 0 (original height). Range: 0-2000.
        :param pulumi.Input[int] porn_flag: Whether porn is enabled, 0: not enabled, 1: enabled. Default: 0.
        :param pulumi.Input[int] snapshot_interval: Screenshot interval, unit: s, default: 10s. Range: 2s~300s.
        :param pulumi.Input[str] template_name: Template name. Maximum length: 255 bytes. Only Chinese, English, numbers, `_`, `-` are supported.
        :param pulumi.Input[int] width: Screenshot width. Default: 0 (original width). Range: 0-3000.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _SnapshotTemplateState.__new__(_SnapshotTemplateState)

        __props__.__dict__["cos_app_id"] = cos_app_id
        __props__.__dict__["cos_bucket"] = cos_bucket
        __props__.__dict__["cos_file_name"] = cos_file_name
        __props__.__dict__["cos_prefix"] = cos_prefix
        __props__.__dict__["cos_region"] = cos_region
        __props__.__dict__["description"] = description
        __props__.__dict__["height"] = height
        __props__.__dict__["porn_flag"] = porn_flag
        __props__.__dict__["snapshot_interval"] = snapshot_interval
        __props__.__dict__["template_name"] = template_name
        __props__.__dict__["width"] = width
        return SnapshotTemplate(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="cosAppId")
    def cos_app_id(self) -> pulumi.Output[int]:
        """
        Cos application ID.
        """
        return pulumi.get(self, "cos_app_id")

    @property
    @pulumi.getter(name="cosBucket")
    def cos_bucket(self) -> pulumi.Output[str]:
        """
        Cos bucket name. Note: The CosBucket parameter value cannot include the - [appid] part.
        """
        return pulumi.get(self, "cos_bucket")

    @property
    @pulumi.getter(name="cosFileName")
    def cos_file_name(self) -> pulumi.Output[Optional[str]]:
        """
        Cos file name. If it is empty, set according to the default value {StreamID}-screenshot-{Hour}-{Minute}-{Second}-{Width}x{Height}{Ext}.
        """
        return pulumi.get(self, "cos_file_name")

    @property
    @pulumi.getter(name="cosPrefix")
    def cos_prefix(self) -> pulumi.Output[Optional[str]]:
        """
        Cos Bucket folder prefix. If it is empty, set according to the default value /{Year}-{Month}-{Day}/.
        """
        return pulumi.get(self, "cos_prefix")

    @property
    @pulumi.getter(name="cosRegion")
    def cos_region(self) -> pulumi.Output[str]:
        """
        Cos region.
        """
        return pulumi.get(self, "cos_region")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        Description information. Maximum length: 1024 bytes. Only `Chinese`, `English`, `numbers`, `_`, `-` are supported.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def height(self) -> pulumi.Output[Optional[int]]:
        """
        Screenshot height. Default: 0 (original height). Range: 0-2000.
        """
        return pulumi.get(self, "height")

    @property
    @pulumi.getter(name="pornFlag")
    def porn_flag(self) -> pulumi.Output[Optional[int]]:
        """
        Whether porn is enabled, 0: not enabled, 1: enabled. Default: 0.
        """
        return pulumi.get(self, "porn_flag")

    @property
    @pulumi.getter(name="snapshotInterval")
    def snapshot_interval(self) -> pulumi.Output[Optional[int]]:
        """
        Screenshot interval, unit: s, default: 10s. Range: 2s~300s.
        """
        return pulumi.get(self, "snapshot_interval")

    @property
    @pulumi.getter(name="templateName")
    def template_name(self) -> pulumi.Output[str]:
        """
        Template name. Maximum length: 255 bytes. Only Chinese, English, numbers, `_`, `-` are supported.
        """
        return pulumi.get(self, "template_name")

    @property
    @pulumi.getter
    def width(self) -> pulumi.Output[Optional[int]]:
        """
        Screenshot width. Default: 0 (original width). Range: 0-3000.
        """
        return pulumi.get(self, "width")

