# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['UserGroupMembersArgs', 'UserGroupMembers']

@pulumi.input_type
class UserGroupMembersArgs:
    def __init__(__self__, *,
                 member_id_sets: pulumi.Input[Sequence[pulumi.Input[int]]],
                 user_group_id: pulumi.Input[int]):
        """
        The set of arguments for constructing a UserGroupMembers resource.
        :param pulumi.Input[Sequence[pulumi.Input[int]]] member_id_sets: Collection of member user IDs.
        :param pulumi.Input[int] user_group_id: User Group ID.
        """
        pulumi.set(__self__, "member_id_sets", member_id_sets)
        pulumi.set(__self__, "user_group_id", user_group_id)

    @property
    @pulumi.getter(name="memberIdSets")
    def member_id_sets(self) -> pulumi.Input[Sequence[pulumi.Input[int]]]:
        """
        Collection of member user IDs.
        """
        return pulumi.get(self, "member_id_sets")

    @member_id_sets.setter
    def member_id_sets(self, value: pulumi.Input[Sequence[pulumi.Input[int]]]):
        pulumi.set(self, "member_id_sets", value)

    @property
    @pulumi.getter(name="userGroupId")
    def user_group_id(self) -> pulumi.Input[int]:
        """
        User Group ID.
        """
        return pulumi.get(self, "user_group_id")

    @user_group_id.setter
    def user_group_id(self, value: pulumi.Input[int]):
        pulumi.set(self, "user_group_id", value)


@pulumi.input_type
class _UserGroupMembersState:
    def __init__(__self__, *,
                 member_id_sets: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]] = None,
                 user_group_id: Optional[pulumi.Input[int]] = None):
        """
        Input properties used for looking up and filtering UserGroupMembers resources.
        :param pulumi.Input[Sequence[pulumi.Input[int]]] member_id_sets: Collection of member user IDs.
        :param pulumi.Input[int] user_group_id: User Group ID.
        """
        if member_id_sets is not None:
            pulumi.set(__self__, "member_id_sets", member_id_sets)
        if user_group_id is not None:
            pulumi.set(__self__, "user_group_id", user_group_id)

    @property
    @pulumi.getter(name="memberIdSets")
    def member_id_sets(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[int]]]]:
        """
        Collection of member user IDs.
        """
        return pulumi.get(self, "member_id_sets")

    @member_id_sets.setter
    def member_id_sets(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]]):
        pulumi.set(self, "member_id_sets", value)

    @property
    @pulumi.getter(name="userGroupId")
    def user_group_id(self) -> Optional[pulumi.Input[int]]:
        """
        User Group ID.
        """
        return pulumi.get(self, "user_group_id")

    @user_group_id.setter
    def user_group_id(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "user_group_id", value)


class UserGroupMembers(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 member_id_sets: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]] = None,
                 user_group_id: Optional[pulumi.Input[int]] = None,
                 __props__=None):
        """
        Provides a resource to create a dasb user_group_members

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        example_user = tencentcloud.dasb.User("exampleUser",
            user_name="tf_example",
            real_name="terraform",
            phone="+86|18345678782",
            email="demo@tencent.com",
            auth_type=0)
        example_user_group = tencentcloud.dasb.UserGroup("exampleUserGroup")
        example_user_group_members = tencentcloud.dasb.UserGroupMembers("exampleUserGroupMembers",
            user_group_id=example_user_group.id,
            member_id_sets=[example_user.id])
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        dasb user_group_members can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Dasb/userGroupMembers:UserGroupMembers example 3#14
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[int]]] member_id_sets: Collection of member user IDs.
        :param pulumi.Input[int] user_group_id: User Group ID.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: UserGroupMembersArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a dasb user_group_members

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        example_user = tencentcloud.dasb.User("exampleUser",
            user_name="tf_example",
            real_name="terraform",
            phone="+86|18345678782",
            email="demo@tencent.com",
            auth_type=0)
        example_user_group = tencentcloud.dasb.UserGroup("exampleUserGroup")
        example_user_group_members = tencentcloud.dasb.UserGroupMembers("exampleUserGroupMembers",
            user_group_id=example_user_group.id,
            member_id_sets=[example_user.id])
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        dasb user_group_members can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Dasb/userGroupMembers:UserGroupMembers example 3#14
        ```

        :param str resource_name: The name of the resource.
        :param UserGroupMembersArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(UserGroupMembersArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 member_id_sets: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]] = None,
                 user_group_id: Optional[pulumi.Input[int]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = UserGroupMembersArgs.__new__(UserGroupMembersArgs)

            if member_id_sets is None and not opts.urn:
                raise TypeError("Missing required property 'member_id_sets'")
            __props__.__dict__["member_id_sets"] = member_id_sets
            if user_group_id is None and not opts.urn:
                raise TypeError("Missing required property 'user_group_id'")
            __props__.__dict__["user_group_id"] = user_group_id
        super(UserGroupMembers, __self__).__init__(
            'tencentcloud:Dasb/userGroupMembers:UserGroupMembers',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            member_id_sets: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]] = None,
            user_group_id: Optional[pulumi.Input[int]] = None) -> 'UserGroupMembers':
        """
        Get an existing UserGroupMembers resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[int]]] member_id_sets: Collection of member user IDs.
        :param pulumi.Input[int] user_group_id: User Group ID.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _UserGroupMembersState.__new__(_UserGroupMembersState)

        __props__.__dict__["member_id_sets"] = member_id_sets
        __props__.__dict__["user_group_id"] = user_group_id
        return UserGroupMembers(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="memberIdSets")
    def member_id_sets(self) -> pulumi.Output[Sequence[int]]:
        """
        Collection of member user IDs.
        """
        return pulumi.get(self, "member_id_sets")

    @property
    @pulumi.getter(name="userGroupId")
    def user_group_id(self) -> pulumi.Output[int]:
        """
        User Group ID.
        """
        return pulumi.get(self, "user_group_id")

