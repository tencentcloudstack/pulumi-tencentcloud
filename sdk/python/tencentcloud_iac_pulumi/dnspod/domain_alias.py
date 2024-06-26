# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['DomainAliasArgs', 'DomainAlias']

@pulumi.input_type
class DomainAliasArgs:
    def __init__(__self__, *,
                 domain: pulumi.Input[str],
                 domain_alias: pulumi.Input[str]):
        """
        The set of arguments for constructing a DomainAlias resource.
        :param pulumi.Input[str] domain: Domain.
        :param pulumi.Input[str] domain_alias: Domain alias.
        """
        pulumi.set(__self__, "domain", domain)
        pulumi.set(__self__, "domain_alias", domain_alias)

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
    @pulumi.getter(name="domainAlias")
    def domain_alias(self) -> pulumi.Input[str]:
        """
        Domain alias.
        """
        return pulumi.get(self, "domain_alias")

    @domain_alias.setter
    def domain_alias(self, value: pulumi.Input[str]):
        pulumi.set(self, "domain_alias", value)


@pulumi.input_type
class _DomainAliasState:
    def __init__(__self__, *,
                 domain: Optional[pulumi.Input[str]] = None,
                 domain_alias: Optional[pulumi.Input[str]] = None,
                 domain_alias_id: Optional[pulumi.Input[int]] = None):
        """
        Input properties used for looking up and filtering DomainAlias resources.
        :param pulumi.Input[str] domain: Domain.
        :param pulumi.Input[str] domain_alias: Domain alias.
        :param pulumi.Input[int] domain_alias_id: Domain alias ID.
        """
        if domain is not None:
            pulumi.set(__self__, "domain", domain)
        if domain_alias is not None:
            pulumi.set(__self__, "domain_alias", domain_alias)
        if domain_alias_id is not None:
            pulumi.set(__self__, "domain_alias_id", domain_alias_id)

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
    @pulumi.getter(name="domainAlias")
    def domain_alias(self) -> Optional[pulumi.Input[str]]:
        """
        Domain alias.
        """
        return pulumi.get(self, "domain_alias")

    @domain_alias.setter
    def domain_alias(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "domain_alias", value)

    @property
    @pulumi.getter(name="domainAliasId")
    def domain_alias_id(self) -> Optional[pulumi.Input[int]]:
        """
        Domain alias ID.
        """
        return pulumi.get(self, "domain_alias_id")

    @domain_alias_id.setter
    def domain_alias_id(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "domain_alias_id", value)


class DomainAlias(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 domain: Optional[pulumi.Input[str]] = None,
                 domain_alias: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a resource to create a dnspod domain_alias

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        domain_alias = tencentcloud.dnspod.DomainAlias("domainAlias",
            domain="dnspod.cn",
            domain_alias="dnspod.com")
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        dnspod domain_alias can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Dnspod/domainAlias:DomainAlias domain_alias domain#domain_alias_id
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] domain: Domain.
        :param pulumi.Input[str] domain_alias: Domain alias.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: DomainAliasArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a dnspod domain_alias

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        domain_alias = tencentcloud.dnspod.DomainAlias("domainAlias",
            domain="dnspod.cn",
            domain_alias="dnspod.com")
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        dnspod domain_alias can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Dnspod/domainAlias:DomainAlias domain_alias domain#domain_alias_id
        ```

        :param str resource_name: The name of the resource.
        :param DomainAliasArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(DomainAliasArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 domain: Optional[pulumi.Input[str]] = None,
                 domain_alias: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = DomainAliasArgs.__new__(DomainAliasArgs)

            if domain is None and not opts.urn:
                raise TypeError("Missing required property 'domain'")
            __props__.__dict__["domain"] = domain
            if domain_alias is None and not opts.urn:
                raise TypeError("Missing required property 'domain_alias'")
            __props__.__dict__["domain_alias"] = domain_alias
            __props__.__dict__["domain_alias_id"] = None
        super(DomainAlias, __self__).__init__(
            'tencentcloud:Dnspod/domainAlias:DomainAlias',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            domain: Optional[pulumi.Input[str]] = None,
            domain_alias: Optional[pulumi.Input[str]] = None,
            domain_alias_id: Optional[pulumi.Input[int]] = None) -> 'DomainAlias':
        """
        Get an existing DomainAlias resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] domain: Domain.
        :param pulumi.Input[str] domain_alias: Domain alias.
        :param pulumi.Input[int] domain_alias_id: Domain alias ID.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _DomainAliasState.__new__(_DomainAliasState)

        __props__.__dict__["domain"] = domain
        __props__.__dict__["domain_alias"] = domain_alias
        __props__.__dict__["domain_alias_id"] = domain_alias_id
        return DomainAlias(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def domain(self) -> pulumi.Output[str]:
        """
        Domain.
        """
        return pulumi.get(self, "domain")

    @property
    @pulumi.getter(name="domainAlias")
    def domain_alias(self) -> pulumi.Output[str]:
        """
        Domain alias.
        """
        return pulumi.get(self, "domain_alias")

    @property
    @pulumi.getter(name="domainAliasId")
    def domain_alias_id(self) -> pulumi.Output[int]:
        """
        Domain alias ID.
        """
        return pulumi.get(self, "domain_alias_id")

