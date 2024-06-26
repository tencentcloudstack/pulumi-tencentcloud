# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['ModifyRecordGroupOperationArgs', 'ModifyRecordGroupOperation']

@pulumi.input_type
class ModifyRecordGroupOperationArgs:
    def __init__(__self__, *,
                 domain: pulumi.Input[str],
                 group_id: pulumi.Input[int],
                 record_id: pulumi.Input[str],
                 domain_id: Optional[pulumi.Input[int]] = None):
        """
        The set of arguments for constructing a ModifyRecordGroupOperation resource.
        :param pulumi.Input[str] domain: Domain.
        :param pulumi.Input[int] group_id: Record Group ID.
        :param pulumi.Input[str] record_id: Record ID, multiple IDs are separated by a vertical line |.
        :param pulumi.Input[int] domain_id: Domain ID. The parameter DomainId has a higher priority than the parameter Domain. If the parameter DomainId is passed, the parameter Domain will be ignored. You can find all Domains and DomainIds through the DescribeDomainList interface.
        """
        pulumi.set(__self__, "domain", domain)
        pulumi.set(__self__, "group_id", group_id)
        pulumi.set(__self__, "record_id", record_id)
        if domain_id is not None:
            pulumi.set(__self__, "domain_id", domain_id)

    @property
    @pulumi.getter
    def domain(self) -> pulumi.Input[str]:
        """
        Domain.
        """
        return pulumi.get(self, "domain")

    @domain.setter
    def domain(self, value: pulumi.Input[str]):
        pulumi.set(self, "domain", value)

    @property
    @pulumi.getter(name="groupId")
    def group_id(self) -> pulumi.Input[int]:
        """
        Record Group ID.
        """
        return pulumi.get(self, "group_id")

    @group_id.setter
    def group_id(self, value: pulumi.Input[int]):
        pulumi.set(self, "group_id", value)

    @property
    @pulumi.getter(name="recordId")
    def record_id(self) -> pulumi.Input[str]:
        """
        Record ID, multiple IDs are separated by a vertical line |.
        """
        return pulumi.get(self, "record_id")

    @record_id.setter
    def record_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "record_id", value)

    @property
    @pulumi.getter(name="domainId")
    def domain_id(self) -> Optional[pulumi.Input[int]]:
        """
        Domain ID. The parameter DomainId has a higher priority than the parameter Domain. If the parameter DomainId is passed, the parameter Domain will be ignored. You can find all Domains and DomainIds through the DescribeDomainList interface.
        """
        return pulumi.get(self, "domain_id")

    @domain_id.setter
    def domain_id(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "domain_id", value)


@pulumi.input_type
class _ModifyRecordGroupOperationState:
    def __init__(__self__, *,
                 domain: Optional[pulumi.Input[str]] = None,
                 domain_id: Optional[pulumi.Input[int]] = None,
                 group_id: Optional[pulumi.Input[int]] = None,
                 record_id: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering ModifyRecordGroupOperation resources.
        :param pulumi.Input[str] domain: Domain.
        :param pulumi.Input[int] domain_id: Domain ID. The parameter DomainId has a higher priority than the parameter Domain. If the parameter DomainId is passed, the parameter Domain will be ignored. You can find all Domains and DomainIds through the DescribeDomainList interface.
        :param pulumi.Input[int] group_id: Record Group ID.
        :param pulumi.Input[str] record_id: Record ID, multiple IDs are separated by a vertical line |.
        """
        if domain is not None:
            pulumi.set(__self__, "domain", domain)
        if domain_id is not None:
            pulumi.set(__self__, "domain_id", domain_id)
        if group_id is not None:
            pulumi.set(__self__, "group_id", group_id)
        if record_id is not None:
            pulumi.set(__self__, "record_id", record_id)

    @property
    @pulumi.getter
    def domain(self) -> Optional[pulumi.Input[str]]:
        """
        Domain.
        """
        return pulumi.get(self, "domain")

    @domain.setter
    def domain(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "domain", value)

    @property
    @pulumi.getter(name="domainId")
    def domain_id(self) -> Optional[pulumi.Input[int]]:
        """
        Domain ID. The parameter DomainId has a higher priority than the parameter Domain. If the parameter DomainId is passed, the parameter Domain will be ignored. You can find all Domains and DomainIds through the DescribeDomainList interface.
        """
        return pulumi.get(self, "domain_id")

    @domain_id.setter
    def domain_id(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "domain_id", value)

    @property
    @pulumi.getter(name="groupId")
    def group_id(self) -> Optional[pulumi.Input[int]]:
        """
        Record Group ID.
        """
        return pulumi.get(self, "group_id")

    @group_id.setter
    def group_id(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "group_id", value)

    @property
    @pulumi.getter(name="recordId")
    def record_id(self) -> Optional[pulumi.Input[str]]:
        """
        Record ID, multiple IDs are separated by a vertical line |.
        """
        return pulumi.get(self, "record_id")

    @record_id.setter
    def record_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "record_id", value)


class ModifyRecordGroupOperation(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 domain: Optional[pulumi.Input[str]] = None,
                 domain_id: Optional[pulumi.Input[int]] = None,
                 group_id: Optional[pulumi.Input[int]] = None,
                 record_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a resource to create a dnspod Dnspod.ModifyRecordGroupOperation

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        modify_record_group = tencentcloud.dnspod.ModifyRecordGroupOperation("modifyRecordGroup",
            domain="dnspod.cn",
            domain_id=123,
            group_id=1,
            record_id="234|345")
        ```
        <!--End PulumiCodeChooser -->

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] domain: Domain.
        :param pulumi.Input[int] domain_id: Domain ID. The parameter DomainId has a higher priority than the parameter Domain. If the parameter DomainId is passed, the parameter Domain will be ignored. You can find all Domains and DomainIds through the DescribeDomainList interface.
        :param pulumi.Input[int] group_id: Record Group ID.
        :param pulumi.Input[str] record_id: Record ID, multiple IDs are separated by a vertical line |.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ModifyRecordGroupOperationArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a dnspod Dnspod.ModifyRecordGroupOperation

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        modify_record_group = tencentcloud.dnspod.ModifyRecordGroupOperation("modifyRecordGroup",
            domain="dnspod.cn",
            domain_id=123,
            group_id=1,
            record_id="234|345")
        ```
        <!--End PulumiCodeChooser -->

        :param str resource_name: The name of the resource.
        :param ModifyRecordGroupOperationArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ModifyRecordGroupOperationArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 domain: Optional[pulumi.Input[str]] = None,
                 domain_id: Optional[pulumi.Input[int]] = None,
                 group_id: Optional[pulumi.Input[int]] = None,
                 record_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ModifyRecordGroupOperationArgs.__new__(ModifyRecordGroupOperationArgs)

            if domain is None and not opts.urn:
                raise TypeError("Missing required property 'domain'")
            __props__.__dict__["domain"] = domain
            __props__.__dict__["domain_id"] = domain_id
            if group_id is None and not opts.urn:
                raise TypeError("Missing required property 'group_id'")
            __props__.__dict__["group_id"] = group_id
            if record_id is None and not opts.urn:
                raise TypeError("Missing required property 'record_id'")
            __props__.__dict__["record_id"] = record_id
        super(ModifyRecordGroupOperation, __self__).__init__(
            'tencentcloud:Dnspod/modifyRecordGroupOperation:ModifyRecordGroupOperation',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            domain: Optional[pulumi.Input[str]] = None,
            domain_id: Optional[pulumi.Input[int]] = None,
            group_id: Optional[pulumi.Input[int]] = None,
            record_id: Optional[pulumi.Input[str]] = None) -> 'ModifyRecordGroupOperation':
        """
        Get an existing ModifyRecordGroupOperation resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] domain: Domain.
        :param pulumi.Input[int] domain_id: Domain ID. The parameter DomainId has a higher priority than the parameter Domain. If the parameter DomainId is passed, the parameter Domain will be ignored. You can find all Domains and DomainIds through the DescribeDomainList interface.
        :param pulumi.Input[int] group_id: Record Group ID.
        :param pulumi.Input[str] record_id: Record ID, multiple IDs are separated by a vertical line |.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ModifyRecordGroupOperationState.__new__(_ModifyRecordGroupOperationState)

        __props__.__dict__["domain"] = domain
        __props__.__dict__["domain_id"] = domain_id
        __props__.__dict__["group_id"] = group_id
        __props__.__dict__["record_id"] = record_id
        return ModifyRecordGroupOperation(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def domain(self) -> pulumi.Output[str]:
        """
        Domain.
        """
        return pulumi.get(self, "domain")

    @property
    @pulumi.getter(name="domainId")
    def domain_id(self) -> pulumi.Output[Optional[int]]:
        """
        Domain ID. The parameter DomainId has a higher priority than the parameter Domain. If the parameter DomainId is passed, the parameter Domain will be ignored. You can find all Domains and DomainIds through the DescribeDomainList interface.
        """
        return pulumi.get(self, "domain_id")

    @property
    @pulumi.getter(name="groupId")
    def group_id(self) -> pulumi.Output[int]:
        """
        Record Group ID.
        """
        return pulumi.get(self, "group_id")

    @property
    @pulumi.getter(name="recordId")
    def record_id(self) -> pulumi.Output[str]:
        """
        Record ID, multiple IDs are separated by a vertical line |.
        """
        return pulumi.get(self, "record_id")

