# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['PolicySubAccountAttachmentArgs', 'PolicySubAccountAttachment']

@pulumi.input_type
class PolicySubAccountAttachmentArgs:
    def __init__(__self__, *,
                 member_uin: pulumi.Input[int],
                 org_sub_account_uin: pulumi.Input[int],
                 policy_id: pulumi.Input[int]):
        """
        The set of arguments for constructing a PolicySubAccountAttachment resource.
        :param pulumi.Input[int] member_uin: Organization member uin.
        :param pulumi.Input[int] org_sub_account_uin: Organization administrator sub account uin list.
        :param pulumi.Input[int] policy_id: Policy ID.
        """
        pulumi.set(__self__, "member_uin", member_uin)
        pulumi.set(__self__, "org_sub_account_uin", org_sub_account_uin)
        pulumi.set(__self__, "policy_id", policy_id)

    @property
    @pulumi.getter(name="memberUin")
    def member_uin(self) -> pulumi.Input[int]:
        """
        Organization member uin.
        """
        return pulumi.get(self, "member_uin")

    @member_uin.setter
    def member_uin(self, value: pulumi.Input[int]):
        pulumi.set(self, "member_uin", value)

    @property
    @pulumi.getter(name="orgSubAccountUin")
    def org_sub_account_uin(self) -> pulumi.Input[int]:
        """
        Organization administrator sub account uin list.
        """
        return pulumi.get(self, "org_sub_account_uin")

    @org_sub_account_uin.setter
    def org_sub_account_uin(self, value: pulumi.Input[int]):
        pulumi.set(self, "org_sub_account_uin", value)

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


@pulumi.input_type
class _PolicySubAccountAttachmentState:
    def __init__(__self__, *,
                 create_time: Optional[pulumi.Input[str]] = None,
                 identity_id: Optional[pulumi.Input[int]] = None,
                 identity_role_alias_name: Optional[pulumi.Input[str]] = None,
                 identity_role_name: Optional[pulumi.Input[str]] = None,
                 member_uin: Optional[pulumi.Input[int]] = None,
                 org_sub_account_name: Optional[pulumi.Input[str]] = None,
                 org_sub_account_uin: Optional[pulumi.Input[int]] = None,
                 policy_id: Optional[pulumi.Input[int]] = None,
                 policy_name: Optional[pulumi.Input[str]] = None,
                 update_time: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering PolicySubAccountAttachment resources.
        :param pulumi.Input[str] create_time: Creation time.
        :param pulumi.Input[int] identity_id: Manage Identity ID.
        :param pulumi.Input[str] identity_role_alias_name: Identity role alias name.
        :param pulumi.Input[str] identity_role_name: Identity role name.
        :param pulumi.Input[int] member_uin: Organization member uin.
        :param pulumi.Input[str] org_sub_account_name: Organization administrator sub account name.
        :param pulumi.Input[int] org_sub_account_uin: Organization administrator sub account uin list.
        :param pulumi.Input[int] policy_id: Policy ID.
        :param pulumi.Input[str] policy_name: Policy name.
        :param pulumi.Input[str] update_time: Update time.
        """
        if create_time is not None:
            pulumi.set(__self__, "create_time", create_time)
        if identity_id is not None:
            pulumi.set(__self__, "identity_id", identity_id)
        if identity_role_alias_name is not None:
            pulumi.set(__self__, "identity_role_alias_name", identity_role_alias_name)
        if identity_role_name is not None:
            pulumi.set(__self__, "identity_role_name", identity_role_name)
        if member_uin is not None:
            pulumi.set(__self__, "member_uin", member_uin)
        if org_sub_account_name is not None:
            pulumi.set(__self__, "org_sub_account_name", org_sub_account_name)
        if org_sub_account_uin is not None:
            pulumi.set(__self__, "org_sub_account_uin", org_sub_account_uin)
        if policy_id is not None:
            pulumi.set(__self__, "policy_id", policy_id)
        if policy_name is not None:
            pulumi.set(__self__, "policy_name", policy_name)
        if update_time is not None:
            pulumi.set(__self__, "update_time", update_time)

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> Optional[pulumi.Input[str]]:
        """
        Creation time.
        """
        return pulumi.get(self, "create_time")

    @create_time.setter
    def create_time(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "create_time", value)

    @property
    @pulumi.getter(name="identityId")
    def identity_id(self) -> Optional[pulumi.Input[int]]:
        """
        Manage Identity ID.
        """
        return pulumi.get(self, "identity_id")

    @identity_id.setter
    def identity_id(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "identity_id", value)

    @property
    @pulumi.getter(name="identityRoleAliasName")
    def identity_role_alias_name(self) -> Optional[pulumi.Input[str]]:
        """
        Identity role alias name.
        """
        return pulumi.get(self, "identity_role_alias_name")

    @identity_role_alias_name.setter
    def identity_role_alias_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "identity_role_alias_name", value)

    @property
    @pulumi.getter(name="identityRoleName")
    def identity_role_name(self) -> Optional[pulumi.Input[str]]:
        """
        Identity role name.
        """
        return pulumi.get(self, "identity_role_name")

    @identity_role_name.setter
    def identity_role_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "identity_role_name", value)

    @property
    @pulumi.getter(name="memberUin")
    def member_uin(self) -> Optional[pulumi.Input[int]]:
        """
        Organization member uin.
        """
        return pulumi.get(self, "member_uin")

    @member_uin.setter
    def member_uin(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "member_uin", value)

    @property
    @pulumi.getter(name="orgSubAccountName")
    def org_sub_account_name(self) -> Optional[pulumi.Input[str]]:
        """
        Organization administrator sub account name.
        """
        return pulumi.get(self, "org_sub_account_name")

    @org_sub_account_name.setter
    def org_sub_account_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "org_sub_account_name", value)

    @property
    @pulumi.getter(name="orgSubAccountUin")
    def org_sub_account_uin(self) -> Optional[pulumi.Input[int]]:
        """
        Organization administrator sub account uin list.
        """
        return pulumi.get(self, "org_sub_account_uin")

    @org_sub_account_uin.setter
    def org_sub_account_uin(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "org_sub_account_uin", value)

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
    @pulumi.getter(name="policyName")
    def policy_name(self) -> Optional[pulumi.Input[str]]:
        """
        Policy name.
        """
        return pulumi.get(self, "policy_name")

    @policy_name.setter
    def policy_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "policy_name", value)

    @property
    @pulumi.getter(name="updateTime")
    def update_time(self) -> Optional[pulumi.Input[str]]:
        """
        Update time.
        """
        return pulumi.get(self, "update_time")

    @update_time.setter
    def update_time(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "update_time", value)


class PolicySubAccountAttachment(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 member_uin: Optional[pulumi.Input[int]] = None,
                 org_sub_account_uin: Optional[pulumi.Input[int]] = None,
                 policy_id: Optional[pulumi.Input[int]] = None,
                 __props__=None):
        """
        Provides a resource to create a organization policy_sub_account_attachment

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        policy_sub_account_attachment = tencentcloud.organization.PolicySubAccountAttachment("policySubAccountAttachment",
            member_uin=100028582828,
            org_sub_account_uin=100028223737,
            policy_id=144256499)
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        organization policy_sub_account_attachment can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Organization/policySubAccountAttachment:PolicySubAccountAttachment policy_sub_account_attachment policyId#memberUin#orgSubAccountUin
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[int] member_uin: Organization member uin.
        :param pulumi.Input[int] org_sub_account_uin: Organization administrator sub account uin list.
        :param pulumi.Input[int] policy_id: Policy ID.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: PolicySubAccountAttachmentArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a organization policy_sub_account_attachment

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        policy_sub_account_attachment = tencentcloud.organization.PolicySubAccountAttachment("policySubAccountAttachment",
            member_uin=100028582828,
            org_sub_account_uin=100028223737,
            policy_id=144256499)
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        organization policy_sub_account_attachment can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Organization/policySubAccountAttachment:PolicySubAccountAttachment policy_sub_account_attachment policyId#memberUin#orgSubAccountUin
        ```

        :param str resource_name: The name of the resource.
        :param PolicySubAccountAttachmentArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(PolicySubAccountAttachmentArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 member_uin: Optional[pulumi.Input[int]] = None,
                 org_sub_account_uin: Optional[pulumi.Input[int]] = None,
                 policy_id: Optional[pulumi.Input[int]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = PolicySubAccountAttachmentArgs.__new__(PolicySubAccountAttachmentArgs)

            if member_uin is None and not opts.urn:
                raise TypeError("Missing required property 'member_uin'")
            __props__.__dict__["member_uin"] = member_uin
            if org_sub_account_uin is None and not opts.urn:
                raise TypeError("Missing required property 'org_sub_account_uin'")
            __props__.__dict__["org_sub_account_uin"] = org_sub_account_uin
            if policy_id is None and not opts.urn:
                raise TypeError("Missing required property 'policy_id'")
            __props__.__dict__["policy_id"] = policy_id
            __props__.__dict__["create_time"] = None
            __props__.__dict__["identity_id"] = None
            __props__.__dict__["identity_role_alias_name"] = None
            __props__.__dict__["identity_role_name"] = None
            __props__.__dict__["org_sub_account_name"] = None
            __props__.__dict__["policy_name"] = None
            __props__.__dict__["update_time"] = None
        super(PolicySubAccountAttachment, __self__).__init__(
            'tencentcloud:Organization/policySubAccountAttachment:PolicySubAccountAttachment',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            create_time: Optional[pulumi.Input[str]] = None,
            identity_id: Optional[pulumi.Input[int]] = None,
            identity_role_alias_name: Optional[pulumi.Input[str]] = None,
            identity_role_name: Optional[pulumi.Input[str]] = None,
            member_uin: Optional[pulumi.Input[int]] = None,
            org_sub_account_name: Optional[pulumi.Input[str]] = None,
            org_sub_account_uin: Optional[pulumi.Input[int]] = None,
            policy_id: Optional[pulumi.Input[int]] = None,
            policy_name: Optional[pulumi.Input[str]] = None,
            update_time: Optional[pulumi.Input[str]] = None) -> 'PolicySubAccountAttachment':
        """
        Get an existing PolicySubAccountAttachment resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] create_time: Creation time.
        :param pulumi.Input[int] identity_id: Manage Identity ID.
        :param pulumi.Input[str] identity_role_alias_name: Identity role alias name.
        :param pulumi.Input[str] identity_role_name: Identity role name.
        :param pulumi.Input[int] member_uin: Organization member uin.
        :param pulumi.Input[str] org_sub_account_name: Organization administrator sub account name.
        :param pulumi.Input[int] org_sub_account_uin: Organization administrator sub account uin list.
        :param pulumi.Input[int] policy_id: Policy ID.
        :param pulumi.Input[str] policy_name: Policy name.
        :param pulumi.Input[str] update_time: Update time.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _PolicySubAccountAttachmentState.__new__(_PolicySubAccountAttachmentState)

        __props__.__dict__["create_time"] = create_time
        __props__.__dict__["identity_id"] = identity_id
        __props__.__dict__["identity_role_alias_name"] = identity_role_alias_name
        __props__.__dict__["identity_role_name"] = identity_role_name
        __props__.__dict__["member_uin"] = member_uin
        __props__.__dict__["org_sub_account_name"] = org_sub_account_name
        __props__.__dict__["org_sub_account_uin"] = org_sub_account_uin
        __props__.__dict__["policy_id"] = policy_id
        __props__.__dict__["policy_name"] = policy_name
        __props__.__dict__["update_time"] = update_time
        return PolicySubAccountAttachment(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> pulumi.Output[str]:
        """
        Creation time.
        """
        return pulumi.get(self, "create_time")

    @property
    @pulumi.getter(name="identityId")
    def identity_id(self) -> pulumi.Output[int]:
        """
        Manage Identity ID.
        """
        return pulumi.get(self, "identity_id")

    @property
    @pulumi.getter(name="identityRoleAliasName")
    def identity_role_alias_name(self) -> pulumi.Output[str]:
        """
        Identity role alias name.
        """
        return pulumi.get(self, "identity_role_alias_name")

    @property
    @pulumi.getter(name="identityRoleName")
    def identity_role_name(self) -> pulumi.Output[str]:
        """
        Identity role name.
        """
        return pulumi.get(self, "identity_role_name")

    @property
    @pulumi.getter(name="memberUin")
    def member_uin(self) -> pulumi.Output[int]:
        """
        Organization member uin.
        """
        return pulumi.get(self, "member_uin")

    @property
    @pulumi.getter(name="orgSubAccountName")
    def org_sub_account_name(self) -> pulumi.Output[str]:
        """
        Organization administrator sub account name.
        """
        return pulumi.get(self, "org_sub_account_name")

    @property
    @pulumi.getter(name="orgSubAccountUin")
    def org_sub_account_uin(self) -> pulumi.Output[int]:
        """
        Organization administrator sub account uin list.
        """
        return pulumi.get(self, "org_sub_account_uin")

    @property
    @pulumi.getter(name="policyId")
    def policy_id(self) -> pulumi.Output[int]:
        """
        Policy ID.
        """
        return pulumi.get(self, "policy_id")

    @property
    @pulumi.getter(name="policyName")
    def policy_name(self) -> pulumi.Output[str]:
        """
        Policy name.
        """
        return pulumi.get(self, "policy_name")

    @property
    @pulumi.getter(name="updateTime")
    def update_time(self) -> pulumi.Output[str]:
        """
        Update time.
        """
        return pulumi.get(self, "update_time")

