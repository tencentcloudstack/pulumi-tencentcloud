# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['DedicatedClusterArgs', 'DedicatedCluster']

@pulumi.input_type
class DedicatedClusterArgs:
    def __init__(__self__, *,
                 site_id: pulumi.Input[str],
                 zone: pulumi.Input[str],
                 description: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a DedicatedCluster resource.
        :param pulumi.Input[str] site_id: Dedicated Cluster Site ID.
        :param pulumi.Input[str] zone: Dedicated Cluster Zone.
        :param pulumi.Input[str] description: Dedicated Cluster Description.
        :param pulumi.Input[str] name: Dedicated Cluster Name.
        """
        pulumi.set(__self__, "site_id", site_id)
        pulumi.set(__self__, "zone", zone)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter(name="siteId")
    def site_id(self) -> pulumi.Input[str]:
        """
        Dedicated Cluster Site ID.
        """
        return pulumi.get(self, "site_id")

    @site_id.setter
    def site_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "site_id", value)

    @property
    @pulumi.getter
    def zone(self) -> pulumi.Input[str]:
        """
        Dedicated Cluster Zone.
        """
        return pulumi.get(self, "zone")

    @zone.setter
    def zone(self, value: pulumi.Input[str]):
        pulumi.set(self, "zone", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Dedicated Cluster Description.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Dedicated Cluster Name.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)


@pulumi.input_type
class _DedicatedClusterState:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 site_id: Optional[pulumi.Input[str]] = None,
                 zone: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering DedicatedCluster resources.
        :param pulumi.Input[str] description: Dedicated Cluster Description.
        :param pulumi.Input[str] name: Dedicated Cluster Name.
        :param pulumi.Input[str] site_id: Dedicated Cluster Site ID.
        :param pulumi.Input[str] zone: Dedicated Cluster Zone.
        """
        if description is not None:
            pulumi.set(__self__, "description", description)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if site_id is not None:
            pulumi.set(__self__, "site_id", site_id)
        if zone is not None:
            pulumi.set(__self__, "zone", zone)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Dedicated Cluster Description.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Dedicated Cluster Name.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="siteId")
    def site_id(self) -> Optional[pulumi.Input[str]]:
        """
        Dedicated Cluster Site ID.
        """
        return pulumi.get(self, "site_id")

    @site_id.setter
    def site_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "site_id", value)

    @property
    @pulumi.getter
    def zone(self) -> Optional[pulumi.Input[str]]:
        """
        Dedicated Cluster Zone.
        """
        return pulumi.get(self, "zone")

    @zone.setter
    def zone(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "zone", value)


class DedicatedCluster(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 site_id: Optional[pulumi.Input[str]] = None,
                 zone: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a resource to create a CDC dedicated cluster

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        # create cdc site
        example_site = tencentcloud.cdc.Site("exampleSite",
            country="China",
            province="Guangdong Province",
            city="Guangzhou",
            address_line="Tencent Building",
            description="desc.")
        # create cdc dedicated cluster
        example_dedicated_cluster = tencentcloud.cdc.DedicatedCluster("exampleDedicatedCluster",
            site_id=example_site.id,
            zone="ap-guangzhou-6",
            description="desc.")
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        CDC dedicated cluster can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Cdc/dedicatedCluster:DedicatedCluster example cluster-d574omhk
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: Dedicated Cluster Description.
        :param pulumi.Input[str] name: Dedicated Cluster Name.
        :param pulumi.Input[str] site_id: Dedicated Cluster Site ID.
        :param pulumi.Input[str] zone: Dedicated Cluster Zone.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: DedicatedClusterArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a CDC dedicated cluster

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        # create cdc site
        example_site = tencentcloud.cdc.Site("exampleSite",
            country="China",
            province="Guangdong Province",
            city="Guangzhou",
            address_line="Tencent Building",
            description="desc.")
        # create cdc dedicated cluster
        example_dedicated_cluster = tencentcloud.cdc.DedicatedCluster("exampleDedicatedCluster",
            site_id=example_site.id,
            zone="ap-guangzhou-6",
            description="desc.")
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        CDC dedicated cluster can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Cdc/dedicatedCluster:DedicatedCluster example cluster-d574omhk
        ```

        :param str resource_name: The name of the resource.
        :param DedicatedClusterArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(DedicatedClusterArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 site_id: Optional[pulumi.Input[str]] = None,
                 zone: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = DedicatedClusterArgs.__new__(DedicatedClusterArgs)

            __props__.__dict__["description"] = description
            __props__.__dict__["name"] = name
            if site_id is None and not opts.urn:
                raise TypeError("Missing required property 'site_id'")
            __props__.__dict__["site_id"] = site_id
            if zone is None and not opts.urn:
                raise TypeError("Missing required property 'zone'")
            __props__.__dict__["zone"] = zone
        super(DedicatedCluster, __self__).__init__(
            'tencentcloud:Cdc/dedicatedCluster:DedicatedCluster',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            description: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            site_id: Optional[pulumi.Input[str]] = None,
            zone: Optional[pulumi.Input[str]] = None) -> 'DedicatedCluster':
        """
        Get an existing DedicatedCluster resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: Dedicated Cluster Description.
        :param pulumi.Input[str] name: Dedicated Cluster Name.
        :param pulumi.Input[str] site_id: Dedicated Cluster Site ID.
        :param pulumi.Input[str] zone: Dedicated Cluster Zone.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _DedicatedClusterState.__new__(_DedicatedClusterState)

        __props__.__dict__["description"] = description
        __props__.__dict__["name"] = name
        __props__.__dict__["site_id"] = site_id
        __props__.__dict__["zone"] = zone
        return DedicatedCluster(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        Dedicated Cluster Description.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Dedicated Cluster Name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="siteId")
    def site_id(self) -> pulumi.Output[str]:
        """
        Dedicated Cluster Site ID.
        """
        return pulumi.get(self, "site_id")

    @property
    @pulumi.getter
    def zone(self) -> pulumi.Output[str]:
        """
        Dedicated Cluster Zone.
        """
        return pulumi.get(self, "zone")

