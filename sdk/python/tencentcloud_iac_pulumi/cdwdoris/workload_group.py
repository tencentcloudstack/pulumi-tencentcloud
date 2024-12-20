# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs
from ._inputs import *

__all__ = ['WorkloadGroupArgs', 'WorkloadGroup']

@pulumi.input_type
class WorkloadGroupArgs:
    def __init__(__self__, *,
                 instance_id: pulumi.Input[str],
                 workload_group: Optional[pulumi.Input['WorkloadGroupWorkloadGroupArgs']] = None):
        """
        The set of arguments for constructing a WorkloadGroup resource.
        :param pulumi.Input[str] instance_id: Instance id.
        :param pulumi.Input['WorkloadGroupWorkloadGroupArgs'] workload_group: Resource group configuration.
        """
        pulumi.set(__self__, "instance_id", instance_id)
        if workload_group is not None:
            pulumi.set(__self__, "workload_group", workload_group)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Input[str]:
        """
        Instance id.
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "instance_id", value)

    @property
    @pulumi.getter(name="workloadGroup")
    def workload_group(self) -> Optional[pulumi.Input['WorkloadGroupWorkloadGroupArgs']]:
        """
        Resource group configuration.
        """
        return pulumi.get(self, "workload_group")

    @workload_group.setter
    def workload_group(self, value: Optional[pulumi.Input['WorkloadGroupWorkloadGroupArgs']]):
        pulumi.set(self, "workload_group", value)


@pulumi.input_type
class _WorkloadGroupState:
    def __init__(__self__, *,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 workload_group: Optional[pulumi.Input['WorkloadGroupWorkloadGroupArgs']] = None):
        """
        Input properties used for looking up and filtering WorkloadGroup resources.
        :param pulumi.Input[str] instance_id: Instance id.
        :param pulumi.Input['WorkloadGroupWorkloadGroupArgs'] workload_group: Resource group configuration.
        """
        if instance_id is not None:
            pulumi.set(__self__, "instance_id", instance_id)
        if workload_group is not None:
            pulumi.set(__self__, "workload_group", workload_group)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> Optional[pulumi.Input[str]]:
        """
        Instance id.
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "instance_id", value)

    @property
    @pulumi.getter(name="workloadGroup")
    def workload_group(self) -> Optional[pulumi.Input['WorkloadGroupWorkloadGroupArgs']]:
        """
        Resource group configuration.
        """
        return pulumi.get(self, "workload_group")

    @workload_group.setter
    def workload_group(self, value: Optional[pulumi.Input['WorkloadGroupWorkloadGroupArgs']]):
        pulumi.set(self, "workload_group", value)


class WorkloadGroup(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 workload_group: Optional[pulumi.Input[pulumi.InputType['WorkloadGroupWorkloadGroupArgs']]] = None,
                 __props__=None):
        """
        Provides a resource to create a cdwdoris workload group

        > **NOTE:** To use this resource, The `workload_group_status` field of `Cdwdoris.Instance` needs to be set to true.

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        config = pulumi.Config()
        availability_zone = config.get("availabilityZone")
        if availability_zone is None:
            availability_zone = "ap-guangzhou-6"
        # create vpc
        vpc = tencentcloud.vpc.Instance("vpc", cidr_block="172.16.0.0/16")
        # create subnet
        subnet = tencentcloud.subnet.Instance("subnet",
            availability_zone=availability_zone,
            vpc_id=vpc.id,
            cidr_block="172.16.0.0/24",
            is_multicast=False)
        # create instance
        example_instance = tencentcloud.cdwdoris.Instance("exampleInstance",
            zone=availability_zone,
            user_vpc_id=vpc.id,
            user_subnet_id=subnet.id,
            product_version="2.1",
            instance_name="tf-example",
            doris_user_pwd="Password@test",
            ha_flag=False,
            case_sensitive=0,
            enable_multi_zones=False,
            workload_group_status="open",
            charge_properties=tencentcloud.cdwdoris.InstanceChargePropertiesArgs(
                charge_type="POSTPAID_BY_HOUR",
            ),
            fe_spec=tencentcloud.cdwdoris.InstanceFeSpecArgs(
                spec_name="S_4_16_P",
                count=3,
                disk_size=200,
            ),
            be_spec=tencentcloud.cdwdoris.InstanceBeSpecArgs(
                spec_name="S_4_16_P",
                count=3,
                disk_size=200,
            ),
            tags=[tencentcloud.cdwdoris.InstanceTagArgs(
                tag_key="createBy",
                tag_value="Terraform",
            )])
        # create workload group
        example_workload_group = tencentcloud.cdwdoris.WorkloadGroup("exampleWorkloadGroup",
            instance_id=example_instance.id,
            workload_group=tencentcloud.cdwdoris.WorkloadGroupWorkloadGroupArgs(
                workload_group_name="example",
                cpu_share=1024,
                memory_limit=20,
                enable_memory_over_commit=True,
                cpu_hard_limit="30%",
            ))
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        cdwdoris workload group can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Cdwdoris/workloadGroup:WorkloadGroup example cdwdoris-rhbflamd#tf-example
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] instance_id: Instance id.
        :param pulumi.Input[pulumi.InputType['WorkloadGroupWorkloadGroupArgs']] workload_group: Resource group configuration.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: WorkloadGroupArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a cdwdoris workload group

        > **NOTE:** To use this resource, The `workload_group_status` field of `Cdwdoris.Instance` needs to be set to true.

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        config = pulumi.Config()
        availability_zone = config.get("availabilityZone")
        if availability_zone is None:
            availability_zone = "ap-guangzhou-6"
        # create vpc
        vpc = tencentcloud.vpc.Instance("vpc", cidr_block="172.16.0.0/16")
        # create subnet
        subnet = tencentcloud.subnet.Instance("subnet",
            availability_zone=availability_zone,
            vpc_id=vpc.id,
            cidr_block="172.16.0.0/24",
            is_multicast=False)
        # create instance
        example_instance = tencentcloud.cdwdoris.Instance("exampleInstance",
            zone=availability_zone,
            user_vpc_id=vpc.id,
            user_subnet_id=subnet.id,
            product_version="2.1",
            instance_name="tf-example",
            doris_user_pwd="Password@test",
            ha_flag=False,
            case_sensitive=0,
            enable_multi_zones=False,
            workload_group_status="open",
            charge_properties=tencentcloud.cdwdoris.InstanceChargePropertiesArgs(
                charge_type="POSTPAID_BY_HOUR",
            ),
            fe_spec=tencentcloud.cdwdoris.InstanceFeSpecArgs(
                spec_name="S_4_16_P",
                count=3,
                disk_size=200,
            ),
            be_spec=tencentcloud.cdwdoris.InstanceBeSpecArgs(
                spec_name="S_4_16_P",
                count=3,
                disk_size=200,
            ),
            tags=[tencentcloud.cdwdoris.InstanceTagArgs(
                tag_key="createBy",
                tag_value="Terraform",
            )])
        # create workload group
        example_workload_group = tencentcloud.cdwdoris.WorkloadGroup("exampleWorkloadGroup",
            instance_id=example_instance.id,
            workload_group=tencentcloud.cdwdoris.WorkloadGroupWorkloadGroupArgs(
                workload_group_name="example",
                cpu_share=1024,
                memory_limit=20,
                enable_memory_over_commit=True,
                cpu_hard_limit="30%",
            ))
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        cdwdoris workload group can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Cdwdoris/workloadGroup:WorkloadGroup example cdwdoris-rhbflamd#tf-example
        ```

        :param str resource_name: The name of the resource.
        :param WorkloadGroupArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(WorkloadGroupArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 workload_group: Optional[pulumi.Input[pulumi.InputType['WorkloadGroupWorkloadGroupArgs']]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = WorkloadGroupArgs.__new__(WorkloadGroupArgs)

            if instance_id is None and not opts.urn:
                raise TypeError("Missing required property 'instance_id'")
            __props__.__dict__["instance_id"] = instance_id
            __props__.__dict__["workload_group"] = workload_group
        super(WorkloadGroup, __self__).__init__(
            'tencentcloud:Cdwdoris/workloadGroup:WorkloadGroup',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            instance_id: Optional[pulumi.Input[str]] = None,
            workload_group: Optional[pulumi.Input[pulumi.InputType['WorkloadGroupWorkloadGroupArgs']]] = None) -> 'WorkloadGroup':
        """
        Get an existing WorkloadGroup resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] instance_id: Instance id.
        :param pulumi.Input[pulumi.InputType['WorkloadGroupWorkloadGroupArgs']] workload_group: Resource group configuration.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _WorkloadGroupState.__new__(_WorkloadGroupState)

        __props__.__dict__["instance_id"] = instance_id
        __props__.__dict__["workload_group"] = workload_group
        return WorkloadGroup(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Output[str]:
        """
        Instance id.
        """
        return pulumi.get(self, "instance_id")

    @property
    @pulumi.getter(name="workloadGroup")
    def workload_group(self) -> pulumi.Output[Optional['outputs.WorkloadGroupWorkloadGroup']]:
        """
        Resource group configuration.
        """
        return pulumi.get(self, "workload_group")

