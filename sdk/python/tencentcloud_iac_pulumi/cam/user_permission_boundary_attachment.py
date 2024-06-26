# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['UserPermissionBoundaryAttachmentArgs', 'UserPermissionBoundaryAttachment']

@pulumi.input_type
class UserPermissionBoundaryAttachmentArgs:
    def __init__(__self__, *,
                 policy_id: pulumi.Input[int],
                 target_uin: pulumi.Input[int]):
        """
        The set of arguments for constructing a UserPermissionBoundaryAttachment resource.
        :param pulumi.Input[int] policy_id: Policy ID.
        :param pulumi.Input[int] target_uin: Sub account Uin.
        """
        pulumi.set(__self__, "policy_id", policy_id)
        pulumi.set(__self__, "target_uin", target_uin)

    @property
    @pulumi.getter(name="policyId")
    def policy_id(self) -> pulumi.Input[int]:
        """
        Policy ID.
        """
        return pulumi.get(self, "policy_id")

    @policy_id.setter
    def policy_id(self, value: pulumi.Input[int]):
        pulumi.set(self, "policy_id", value)

    @property
    @pulumi.getter(name="targetUin")
    def target_uin(self) -> pulumi.Input[int]:
        """
        Sub account Uin.
        """
        return pulumi.get(self, "target_uin")

    @target_uin.setter
    def target_uin(self, value: pulumi.Input[int]):
        pulumi.set(self, "target_uin", value)


@pulumi.input_type
class _UserPermissionBoundaryAttachmentState:
    def __init__(__self__, *,
                 policy_id: Optional[pulumi.Input[int]] = None,
                 target_uin: Optional[pulumi.Input[int]] = None):
        """
        Input properties used for looking up and filtering UserPermissionBoundaryAttachment resources.
        :param pulumi.Input[int] policy_id: Policy ID.
        :param pulumi.Input[int] target_uin: Sub account Uin.
        """
        if policy_id is not None:
            pulumi.set(__self__, "policy_id", policy_id)
        if target_uin is not None:
            pulumi.set(__self__, "target_uin", target_uin)

    @property
    @pulumi.getter(name="policyId")
    def policy_id(self) -> Optional[pulumi.Input[int]]:
        """
        Policy ID.
        """
        return pulumi.get(self, "policy_id")

    @policy_id.setter
    def policy_id(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "policy_id", value)

    @property
    @pulumi.getter(name="targetUin")
    def target_uin(self) -> Optional[pulumi.Input[int]]:
        """
        Sub account Uin.
        """
        return pulumi.get(self, "target_uin")

    @target_uin.setter
    def target_uin(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "target_uin", value)


class UserPermissionBoundaryAttachment(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 policy_id: Optional[pulumi.Input[int]] = None,
                 target_uin: Optional[pulumi.Input[int]] = None,
                 __props__=None):
        """
        Provides a resource to create a cam user_permission_boundary

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        user_permission_boundary = tencentcloud.cam.UserPermissionBoundaryAttachment("userPermissionBoundary",
            policy_id=151113272,
            target_uin=100032767426)
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        cam user_permission_boundary can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Cam/userPermissionBoundaryAttachment:UserPermissionBoundaryAttachment user_permission_boundary user_permission_boundary_id
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[int] policy_id: Policy ID.
        :param pulumi.Input[int] target_uin: Sub account Uin.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: UserPermissionBoundaryAttachmentArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a cam user_permission_boundary

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        user_permission_boundary = tencentcloud.cam.UserPermissionBoundaryAttachment("userPermissionBoundary",
            policy_id=151113272,
            target_uin=100032767426)
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        cam user_permission_boundary can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Cam/userPermissionBoundaryAttachment:UserPermissionBoundaryAttachment user_permission_boundary user_permission_boundary_id
        ```

        :param str resource_name: The name of the resource.
        :param UserPermissionBoundaryAttachmentArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(UserPermissionBoundaryAttachmentArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 policy_id: Optional[pulumi.Input[int]] = None,
                 target_uin: Optional[pulumi.Input[int]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = UserPermissionBoundaryAttachmentArgs.__new__(UserPermissionBoundaryAttachmentArgs)

            if policy_id is None and not opts.urn:
                raise TypeError("Missing required property 'policy_id'")
            __props__.__dict__["policy_id"] = policy_id
            if target_uin is None and not opts.urn:
                raise TypeError("Missing required property 'target_uin'")
            __props__.__dict__["target_uin"] = target_uin
        super(UserPermissionBoundaryAttachment, __self__).__init__(
            'tencentcloud:Cam/userPermissionBoundaryAttachment:UserPermissionBoundaryAttachment',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            policy_id: Optional[pulumi.Input[int]] = None,
            target_uin: Optional[pulumi.Input[int]] = None) -> 'UserPermissionBoundaryAttachment':
        """
        Get an existing UserPermissionBoundaryAttachment resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[int] policy_id: Policy ID.
        :param pulumi.Input[int] target_uin: Sub account Uin.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _UserPermissionBoundaryAttachmentState.__new__(_UserPermissionBoundaryAttachmentState)

        __props__.__dict__["policy_id"] = policy_id
        __props__.__dict__["target_uin"] = target_uin
        return UserPermissionBoundaryAttachment(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="policyId")
    def policy_id(self) -> pulumi.Output[int]:
        """
        Policy ID.
        """
        return pulumi.get(self, "policy_id")

    @property
    @pulumi.getter(name="targetUin")
    def target_uin(self) -> pulumi.Output[int]:
        """
        Sub account Uin.
        """
        return pulumi.get(self, "target_uin")

