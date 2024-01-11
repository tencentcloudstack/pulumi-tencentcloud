# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['ProjectArgs', 'Project']

@pulumi.input_type
class ProjectArgs:
    def __init__(__self__, *,
                 color_code: pulumi.Input[str],
                 logo: Optional[pulumi.Input[str]] = None,
                 mark: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a Project resource.
        :param pulumi.Input[str] color_code: Logo background color.
        :param pulumi.Input[str] logo: Project logo.
        :param pulumi.Input[str] mark: Remark.
        :param pulumi.Input[str] name: Project name.
        """
        pulumi.set(__self__, "color_code", color_code)
        if logo is not None:
            pulumi.set(__self__, "logo", logo)
        if mark is not None:
            pulumi.set(__self__, "mark", mark)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter(name="colorCode")
    def color_code(self) -> pulumi.Input[str]:
        """
        Logo background color.
        """
        return pulumi.get(self, "color_code")

    @color_code.setter
    def color_code(self, value: pulumi.Input[str]):
        pulumi.set(self, "color_code", value)

    @property
    @pulumi.getter
    def logo(self) -> Optional[pulumi.Input[str]]:
        """
        Project logo.
        """
        return pulumi.get(self, "logo")

    @logo.setter
    def logo(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "logo", value)

    @property
    @pulumi.getter
    def mark(self) -> Optional[pulumi.Input[str]]:
        """
        Remark.
        """
        return pulumi.get(self, "mark")

    @mark.setter
    def mark(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "mark", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Project name.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)


@pulumi.input_type
class _ProjectState:
    def __init__(__self__, *,
                 color_code: Optional[pulumi.Input[str]] = None,
                 logo: Optional[pulumi.Input[str]] = None,
                 mark: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering Project resources.
        :param pulumi.Input[str] color_code: Logo background color.
        :param pulumi.Input[str] logo: Project logo.
        :param pulumi.Input[str] mark: Remark.
        :param pulumi.Input[str] name: Project name.
        """
        if color_code is not None:
            pulumi.set(__self__, "color_code", color_code)
        if logo is not None:
            pulumi.set(__self__, "logo", logo)
        if mark is not None:
            pulumi.set(__self__, "mark", mark)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter(name="colorCode")
    def color_code(self) -> Optional[pulumi.Input[str]]:
        """
        Logo background color.
        """
        return pulumi.get(self, "color_code")

    @color_code.setter
    def color_code(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "color_code", value)

    @property
    @pulumi.getter
    def logo(self) -> Optional[pulumi.Input[str]]:
        """
        Project logo.
        """
        return pulumi.get(self, "logo")

    @logo.setter
    def logo(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "logo", value)

    @property
    @pulumi.getter
    def mark(self) -> Optional[pulumi.Input[str]]:
        """
        Remark.
        """
        return pulumi.get(self, "mark")

    @mark.setter
    def mark(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "mark", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Project name.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)


class Project(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 color_code: Optional[pulumi.Input[str]] = None,
                 logo: Optional[pulumi.Input[str]] = None,
                 mark: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a resource to create a bi project

        ## Example Usage

        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        project = tencentcloud.bi.Project("project",
            color_code="#7BD936",
            logo="TF-test",
            mark="project mark")
        ```

        ## Import

        bi project can be imported using the id, e.g.

        ```sh
         $ pulumi import tencentcloud:Bi/project:Project project project_id
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] color_code: Logo background color.
        :param pulumi.Input[str] logo: Project logo.
        :param pulumi.Input[str] mark: Remark.
        :param pulumi.Input[str] name: Project name.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ProjectArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a bi project

        ## Example Usage

        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        project = tencentcloud.bi.Project("project",
            color_code="#7BD936",
            logo="TF-test",
            mark="project mark")
        ```

        ## Import

        bi project can be imported using the id, e.g.

        ```sh
         $ pulumi import tencentcloud:Bi/project:Project project project_id
        ```

        :param str resource_name: The name of the resource.
        :param ProjectArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ProjectArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 color_code: Optional[pulumi.Input[str]] = None,
                 logo: Optional[pulumi.Input[str]] = None,
                 mark: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
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
            __props__ = ProjectArgs.__new__(ProjectArgs)

            if color_code is None and not opts.urn:
                raise TypeError("Missing required property 'color_code'")
            __props__.__dict__["color_code"] = color_code
            __props__.__dict__["logo"] = logo
            __props__.__dict__["mark"] = mark
            __props__.__dict__["name"] = name
        super(Project, __self__).__init__(
            'tencentcloud:Bi/project:Project',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            color_code: Optional[pulumi.Input[str]] = None,
            logo: Optional[pulumi.Input[str]] = None,
            mark: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None) -> 'Project':
        """
        Get an existing Project resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] color_code: Logo background color.
        :param pulumi.Input[str] logo: Project logo.
        :param pulumi.Input[str] mark: Remark.
        :param pulumi.Input[str] name: Project name.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ProjectState.__new__(_ProjectState)

        __props__.__dict__["color_code"] = color_code
        __props__.__dict__["logo"] = logo
        __props__.__dict__["mark"] = mark
        __props__.__dict__["name"] = name
        return Project(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="colorCode")
    def color_code(self) -> pulumi.Output[str]:
        """
        Logo background color.
        """
        return pulumi.get(self, "color_code")

    @property
    @pulumi.getter
    def logo(self) -> pulumi.Output[Optional[str]]:
        """
        Project logo.
        """
        return pulumi.get(self, "logo")

    @property
    @pulumi.getter
    def mark(self) -> pulumi.Output[Optional[str]]:
        """
        Remark.
        """
        return pulumi.get(self, "mark")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Project name.
        """
        return pulumi.get(self, "name")
