# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['SetPolicyVersionConfigArgs', 'SetPolicyVersionConfig']

@pulumi.input_type
class SetPolicyVersionConfigArgs:
    def __init__(__self__, *,
                 policy_id: pulumi.Input[int],
                 version_id: pulumi.Input[int]):
        """
        The set of arguments for constructing a SetPolicyVersionConfig resource.
        :param pulumi.Input[int] policy_id: Policy ID.
        :param pulumi.Input[int] version_id: The policy version number, which can be obtained from ListPolicyVersions.
        """
        pulumi.set(__self__, "policy_id", policy_id)
        pulumi.set(__self__, "version_id", version_id)

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
    @pulumi.getter(name="versionId")
    def version_id(self) -> pulumi.Input[int]:
        """
        The policy version number, which can be obtained from ListPolicyVersions.
        """
        return pulumi.get(self, "version_id")

    @version_id.setter
    def version_id(self, value: pulumi.Input[int]):
        pulumi.set(self, "version_id", value)


@pulumi.input_type
class _SetPolicyVersionConfigState:
    def __init__(__self__, *,
                 policy_id: Optional[pulumi.Input[int]] = None,
                 version_id: Optional[pulumi.Input[int]] = None):
        """
        Input properties used for looking up and filtering SetPolicyVersionConfig resources.
        :param pulumi.Input[int] policy_id: Policy ID.
        :param pulumi.Input[int] version_id: The policy version number, which can be obtained from ListPolicyVersions.
        """
        if policy_id is not None:
            pulumi.set(__self__, "policy_id", policy_id)
        if version_id is not None:
            pulumi.set(__self__, "version_id", version_id)

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
    @pulumi.getter(name="versionId")
    def version_id(self) -> Optional[pulumi.Input[int]]:
        """
        The policy version number, which can be obtained from ListPolicyVersions.
        """
        return pulumi.get(self, "version_id")

    @version_id.setter
    def version_id(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "version_id", value)


class SetPolicyVersionConfig(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 policy_id: Optional[pulumi.Input[int]] = None,
                 version_id: Optional[pulumi.Input[int]] = None,
                 __props__=None):
        """
        Provides a resource to create a cam set_policy_version_config

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        set_policy_version_config = tencentcloud.cam.SetPolicyVersionConfig("setPolicyVersionConfig",
            policy_id=171162811,
            version_id=2)
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        cam set_policy_version_config can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Cam/setPolicyVersionConfig:SetPolicyVersionConfig set_policy_version_config set_policy_version_config_id
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[int] policy_id: Policy ID.
        :param pulumi.Input[int] version_id: The policy version number, which can be obtained from ListPolicyVersions.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: SetPolicyVersionConfigArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a cam set_policy_version_config

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        set_policy_version_config = tencentcloud.cam.SetPolicyVersionConfig("setPolicyVersionConfig",
            policy_id=171162811,
            version_id=2)
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        cam set_policy_version_config can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Cam/setPolicyVersionConfig:SetPolicyVersionConfig set_policy_version_config set_policy_version_config_id
        ```

        :param str resource_name: The name of the resource.
        :param SetPolicyVersionConfigArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(SetPolicyVersionConfigArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 policy_id: Optional[pulumi.Input[int]] = None,
                 version_id: Optional[pulumi.Input[int]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = SetPolicyVersionConfigArgs.__new__(SetPolicyVersionConfigArgs)

            if policy_id is None and not opts.urn:
                raise TypeError("Missing required property 'policy_id'")
            __props__.__dict__["policy_id"] = policy_id
            if version_id is None and not opts.urn:
                raise TypeError("Missing required property 'version_id'")
            __props__.__dict__["version_id"] = version_id
        super(SetPolicyVersionConfig, __self__).__init__(
            'tencentcloud:Cam/setPolicyVersionConfig:SetPolicyVersionConfig',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            policy_id: Optional[pulumi.Input[int]] = None,
            version_id: Optional[pulumi.Input[int]] = None) -> 'SetPolicyVersionConfig':
        """
        Get an existing SetPolicyVersionConfig resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[int] policy_id: Policy ID.
        :param pulumi.Input[int] version_id: The policy version number, which can be obtained from ListPolicyVersions.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _SetPolicyVersionConfigState.__new__(_SetPolicyVersionConfigState)

        __props__.__dict__["policy_id"] = policy_id
        __props__.__dict__["version_id"] = version_id
        return SetPolicyVersionConfig(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="policyId")
    def policy_id(self) -> pulumi.Output[int]:
        """
        Policy ID.
        """
        return pulumi.get(self, "policy_id")

    @property
    @pulumi.getter(name="versionId")
    def version_id(self) -> pulumi.Output[int]:
        """
        The policy version number, which can be obtained from ListPolicyVersions.
        """
        return pulumi.get(self, "version_id")

