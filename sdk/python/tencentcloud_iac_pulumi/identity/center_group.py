# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['CenterGroupArgs', 'CenterGroup']

@pulumi.input_type
class CenterGroupArgs:
    def __init__(__self__, *,
                 group_name: pulumi.Input[str],
                 zone_id: pulumi.Input[str],
                 description: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a CenterGroup resource.
        :param pulumi.Input[str] group_name: The name of the user group. Format: Allow English letters, numbers and special characters-. Length: Maximum 128 characters.
        :param pulumi.Input[str] zone_id: Zone id.
        :param pulumi.Input[str] description: A description of the user group. Length: Maximum 1024 characters.
        """
        pulumi.set(__self__, "group_name", group_name)
        pulumi.set(__self__, "zone_id", zone_id)
        if description is not None:
            pulumi.set(__self__, "description", description)

    @property
    @pulumi.getter(name="groupName")
    def group_name(self) -> pulumi.Input[str]:
        """
        The name of the user group. Format: Allow English letters, numbers and special characters-. Length: Maximum 128 characters.
        """
        return pulumi.get(self, "group_name")

    @group_name.setter
    def group_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "group_name", value)

    @property
    @pulumi.getter(name="zoneId")
    def zone_id(self) -> pulumi.Input[str]:
        """
        Zone id.
        """
        return pulumi.get(self, "zone_id")

    @zone_id.setter
    def zone_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "zone_id", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        A description of the user group. Length: Maximum 1024 characters.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)


@pulumi.input_type
class _CenterGroupState:
    def __init__(__self__, *,
                 create_time: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 group_id: Optional[pulumi.Input[str]] = None,
                 group_name: Optional[pulumi.Input[str]] = None,
                 group_type: Optional[pulumi.Input[str]] = None,
                 member_count: Optional[pulumi.Input[int]] = None,
                 update_time: Optional[pulumi.Input[str]] = None,
                 zone_id: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering CenterGroup resources.
        :param pulumi.Input[str] create_time: Creation time of the user group.
        :param pulumi.Input[str] description: A description of the user group. Length: Maximum 1024 characters.
        :param pulumi.Input[str] group_id: ID of the user group.
        :param pulumi.Input[str] group_name: The name of the user group. Format: Allow English letters, numbers and special characters-. Length: Maximum 128 characters.
        :param pulumi.Input[str] group_type: Type of user group. `Manual`: manual creation, `Synchronized`: external import.
        :param pulumi.Input[int] member_count: Number of team members.
        :param pulumi.Input[str] update_time: Modification time for the user group.
        :param pulumi.Input[str] zone_id: Zone id.
        """
        if create_time is not None:
            pulumi.set(__self__, "create_time", create_time)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if group_id is not None:
            pulumi.set(__self__, "group_id", group_id)
        if group_name is not None:
            pulumi.set(__self__, "group_name", group_name)
        if group_type is not None:
            pulumi.set(__self__, "group_type", group_type)
        if member_count is not None:
            pulumi.set(__self__, "member_count", member_count)
        if update_time is not None:
            pulumi.set(__self__, "update_time", update_time)
        if zone_id is not None:
            pulumi.set(__self__, "zone_id", zone_id)

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> Optional[pulumi.Input[str]]:
        """
        Creation time of the user group.
        """
        return pulumi.get(self, "create_time")

    @create_time.setter
    def create_time(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "create_time", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        A description of the user group. Length: Maximum 1024 characters.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="groupId")
    def group_id(self) -> Optional[pulumi.Input[str]]:
        """
        ID of the user group.
        """
        return pulumi.get(self, "group_id")

    @group_id.setter
    def group_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "group_id", value)

    @property
    @pulumi.getter(name="groupName")
    def group_name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the user group. Format: Allow English letters, numbers and special characters-. Length: Maximum 128 characters.
        """
        return pulumi.get(self, "group_name")

    @group_name.setter
    def group_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "group_name", value)

    @property
    @pulumi.getter(name="groupType")
    def group_type(self) -> Optional[pulumi.Input[str]]:
        """
        Type of user group. `Manual`: manual creation, `Synchronized`: external import.
        """
        return pulumi.get(self, "group_type")

    @group_type.setter
    def group_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "group_type", value)

    @property
    @pulumi.getter(name="memberCount")
    def member_count(self) -> Optional[pulumi.Input[int]]:
        """
        Number of team members.
        """
        return pulumi.get(self, "member_count")

    @member_count.setter
    def member_count(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "member_count", value)

    @property
    @pulumi.getter(name="updateTime")
    def update_time(self) -> Optional[pulumi.Input[str]]:
        """
        Modification time for the user group.
        """
        return pulumi.get(self, "update_time")

    @update_time.setter
    def update_time(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "update_time", value)

    @property
    @pulumi.getter(name="zoneId")
    def zone_id(self) -> Optional[pulumi.Input[str]]:
        """
        Zone id.
        """
        return pulumi.get(self, "zone_id")

    @zone_id.setter
    def zone_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "zone_id", value)


class CenterGroup(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 group_name: Optional[pulumi.Input[str]] = None,
                 zone_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a resource to create an identity center group

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        identity_center_group = tencentcloud.identity.CenterGroup("identityCenterGroup",
            description="test",
            group_name="test-group",
            zone_id="z-xxxxxx")
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        tencentcloud_identity_center_group can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Identity/centerGroup:CenterGroup identity_center_group ${zoneId}#${groupId}
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: A description of the user group. Length: Maximum 1024 characters.
        :param pulumi.Input[str] group_name: The name of the user group. Format: Allow English letters, numbers and special characters-. Length: Maximum 128 characters.
        :param pulumi.Input[str] zone_id: Zone id.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: CenterGroupArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create an identity center group

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        identity_center_group = tencentcloud.identity.CenterGroup("identityCenterGroup",
            description="test",
            group_name="test-group",
            zone_id="z-xxxxxx")
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        tencentcloud_identity_center_group can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Identity/centerGroup:CenterGroup identity_center_group ${zoneId}#${groupId}
        ```

        :param str resource_name: The name of the resource.
        :param CenterGroupArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(CenterGroupArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 group_name: Optional[pulumi.Input[str]] = None,
                 zone_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = CenterGroupArgs.__new__(CenterGroupArgs)

            __props__.__dict__["description"] = description
            if group_name is None and not opts.urn:
                raise TypeError("Missing required property 'group_name'")
            __props__.__dict__["group_name"] = group_name
            if zone_id is None and not opts.urn:
                raise TypeError("Missing required property 'zone_id'")
            __props__.__dict__["zone_id"] = zone_id
            __props__.__dict__["create_time"] = None
            __props__.__dict__["group_id"] = None
            __props__.__dict__["group_type"] = None
            __props__.__dict__["member_count"] = None
            __props__.__dict__["update_time"] = None
        super(CenterGroup, __self__).__init__(
            'tencentcloud:Identity/centerGroup:CenterGroup',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            create_time: Optional[pulumi.Input[str]] = None,
            description: Optional[pulumi.Input[str]] = None,
            group_id: Optional[pulumi.Input[str]] = None,
            group_name: Optional[pulumi.Input[str]] = None,
            group_type: Optional[pulumi.Input[str]] = None,
            member_count: Optional[pulumi.Input[int]] = None,
            update_time: Optional[pulumi.Input[str]] = None,
            zone_id: Optional[pulumi.Input[str]] = None) -> 'CenterGroup':
        """
        Get an existing CenterGroup resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] create_time: Creation time of the user group.
        :param pulumi.Input[str] description: A description of the user group. Length: Maximum 1024 characters.
        :param pulumi.Input[str] group_id: ID of the user group.
        :param pulumi.Input[str] group_name: The name of the user group. Format: Allow English letters, numbers and special characters-. Length: Maximum 128 characters.
        :param pulumi.Input[str] group_type: Type of user group. `Manual`: manual creation, `Synchronized`: external import.
        :param pulumi.Input[int] member_count: Number of team members.
        :param pulumi.Input[str] update_time: Modification time for the user group.
        :param pulumi.Input[str] zone_id: Zone id.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _CenterGroupState.__new__(_CenterGroupState)

        __props__.__dict__["create_time"] = create_time
        __props__.__dict__["description"] = description
        __props__.__dict__["group_id"] = group_id
        __props__.__dict__["group_name"] = group_name
        __props__.__dict__["group_type"] = group_type
        __props__.__dict__["member_count"] = member_count
        __props__.__dict__["update_time"] = update_time
        __props__.__dict__["zone_id"] = zone_id
        return CenterGroup(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> pulumi.Output[str]:
        """
        Creation time of the user group.
        """
        return pulumi.get(self, "create_time")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[str]:
        """
        A description of the user group. Length: Maximum 1024 characters.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="groupId")
    def group_id(self) -> pulumi.Output[str]:
        """
        ID of the user group.
        """
        return pulumi.get(self, "group_id")

    @property
    @pulumi.getter(name="groupName")
    def group_name(self) -> pulumi.Output[str]:
        """
        The name of the user group. Format: Allow English letters, numbers and special characters-. Length: Maximum 128 characters.
        """
        return pulumi.get(self, "group_name")

    @property
    @pulumi.getter(name="groupType")
    def group_type(self) -> pulumi.Output[str]:
        """
        Type of user group. `Manual`: manual creation, `Synchronized`: external import.
        """
        return pulumi.get(self, "group_type")

    @property
    @pulumi.getter(name="memberCount")
    def member_count(self) -> pulumi.Output[int]:
        """
        Number of team members.
        """
        return pulumi.get(self, "member_count")

    @property
    @pulumi.getter(name="updateTime")
    def update_time(self) -> pulumi.Output[str]:
        """
        Modification time for the user group.
        """
        return pulumi.get(self, "update_time")

    @property
    @pulumi.getter(name="zoneId")
    def zone_id(self) -> pulumi.Output[str]:
        """
        Zone id.
        """
        return pulumi.get(self, "zone_id")
