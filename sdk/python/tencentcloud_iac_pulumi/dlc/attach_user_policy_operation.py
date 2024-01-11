# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs
from ._inputs import *

__all__ = ['AttachUserPolicyOperationArgs', 'AttachUserPolicyOperation']

@pulumi.input_type
class AttachUserPolicyOperationArgs:
    def __init__(__self__, *,
                 user_id: pulumi.Input[str],
                 policy_sets: Optional[pulumi.Input[Sequence[pulumi.Input['AttachUserPolicyOperationPolicySetArgs']]]] = None):
        """
        The set of arguments for constructing a AttachUserPolicyOperation resource.
        :param pulumi.Input[str] user_id: User id, the same as the sub-user uin.
        :param pulumi.Input[Sequence[pulumi.Input['AttachUserPolicyOperationPolicySetArgs']]] policy_sets: Authentication policy collection.
        """
        pulumi.set(__self__, "user_id", user_id)
        if policy_sets is not None:
            pulumi.set(__self__, "policy_sets", policy_sets)

    @property
    @pulumi.getter(name="userId")
    def user_id(self) -> pulumi.Input[str]:
        """
        User id, the same as the sub-user uin.
        """
        return pulumi.get(self, "user_id")

    @user_id.setter
    def user_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "user_id", value)

    @property
    @pulumi.getter(name="policySets")
    def policy_sets(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['AttachUserPolicyOperationPolicySetArgs']]]]:
        """
        Authentication policy collection.
        """
        return pulumi.get(self, "policy_sets")

    @policy_sets.setter
    def policy_sets(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['AttachUserPolicyOperationPolicySetArgs']]]]):
        pulumi.set(self, "policy_sets", value)


@pulumi.input_type
class _AttachUserPolicyOperationState:
    def __init__(__self__, *,
                 policy_sets: Optional[pulumi.Input[Sequence[pulumi.Input['AttachUserPolicyOperationPolicySetArgs']]]] = None,
                 user_id: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering AttachUserPolicyOperation resources.
        :param pulumi.Input[Sequence[pulumi.Input['AttachUserPolicyOperationPolicySetArgs']]] policy_sets: Authentication policy collection.
        :param pulumi.Input[str] user_id: User id, the same as the sub-user uin.
        """
        if policy_sets is not None:
            pulumi.set(__self__, "policy_sets", policy_sets)
        if user_id is not None:
            pulumi.set(__self__, "user_id", user_id)

    @property
    @pulumi.getter(name="policySets")
    def policy_sets(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['AttachUserPolicyOperationPolicySetArgs']]]]:
        """
        Authentication policy collection.
        """
        return pulumi.get(self, "policy_sets")

    @policy_sets.setter
    def policy_sets(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['AttachUserPolicyOperationPolicySetArgs']]]]):
        pulumi.set(self, "policy_sets", value)

    @property
    @pulumi.getter(name="userId")
    def user_id(self) -> Optional[pulumi.Input[str]]:
        """
        User id, the same as the sub-user uin.
        """
        return pulumi.get(self, "user_id")

    @user_id.setter
    def user_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "user_id", value)


class AttachUserPolicyOperation(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 policy_sets: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AttachUserPolicyOperationPolicySetArgs']]]]] = None,
                 user_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a AttachUserPolicyOperation resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AttachUserPolicyOperationPolicySetArgs']]]] policy_sets: Authentication policy collection.
        :param pulumi.Input[str] user_id: User id, the same as the sub-user uin.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: AttachUserPolicyOperationArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a AttachUserPolicyOperation resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param AttachUserPolicyOperationArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(AttachUserPolicyOperationArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 policy_sets: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AttachUserPolicyOperationPolicySetArgs']]]]] = None,
                 user_id: Optional[pulumi.Input[str]] = None,
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
            __props__ = AttachUserPolicyOperationArgs.__new__(AttachUserPolicyOperationArgs)

            __props__.__dict__["policy_sets"] = policy_sets
            if user_id is None and not opts.urn:
                raise TypeError("Missing required property 'user_id'")
            __props__.__dict__["user_id"] = user_id
        super(AttachUserPolicyOperation, __self__).__init__(
            'tencentcloud:Dlc/attachUserPolicyOperation:AttachUserPolicyOperation',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            policy_sets: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AttachUserPolicyOperationPolicySetArgs']]]]] = None,
            user_id: Optional[pulumi.Input[str]] = None) -> 'AttachUserPolicyOperation':
        """
        Get an existing AttachUserPolicyOperation resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AttachUserPolicyOperationPolicySetArgs']]]] policy_sets: Authentication policy collection.
        :param pulumi.Input[str] user_id: User id, the same as the sub-user uin.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _AttachUserPolicyOperationState.__new__(_AttachUserPolicyOperationState)

        __props__.__dict__["policy_sets"] = policy_sets
        __props__.__dict__["user_id"] = user_id
        return AttachUserPolicyOperation(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="policySets")
    def policy_sets(self) -> pulumi.Output[Optional[Sequence['outputs.AttachUserPolicyOperationPolicySet']]]:
        """
        Authentication policy collection.
        """
        return pulumi.get(self, "policy_sets")

    @property
    @pulumi.getter(name="userId")
    def user_id(self) -> pulumi.Output[str]:
        """
        User id, the same as the sub-user uin.
        """
        return pulumi.get(self, "user_id")
