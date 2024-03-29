# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['TmpTkeRecordRuleYamlArgs', 'TmpTkeRecordRuleYaml']

@pulumi.input_type
class TmpTkeRecordRuleYamlArgs:
    def __init__(__self__, *,
                 content: pulumi.Input[str],
                 instance_id: pulumi.Input[str]):
        """
        The set of arguments for constructing a TmpTkeRecordRuleYaml resource.
        :param pulumi.Input[str] content: Contents of record rules in yaml format.
        :param pulumi.Input[str] instance_id: Instance Id.
        """
        pulumi.set(__self__, "content", content)
        pulumi.set(__self__, "instance_id", instance_id)

    @property
    @pulumi.getter
    def content(self) -> pulumi.Input[str]:
        """
        Contents of record rules in yaml format.
        """
        return pulumi.get(self, "content")

    @content.setter
    def content(self, value: pulumi.Input[str]):
        pulumi.set(self, "content", value)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Input[str]:
        """
        Instance Id.
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "instance_id", value)


@pulumi.input_type
class _TmpTkeRecordRuleYamlState:
    def __init__(__self__, *,
                 cluster_id: Optional[pulumi.Input[str]] = None,
                 content: Optional[pulumi.Input[str]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 template_id: Optional[pulumi.Input[str]] = None,
                 update_time: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering TmpTkeRecordRuleYaml resources.
        :param pulumi.Input[str] cluster_id: An ID identify the cluster, like cls-xxxxxx.
        :param pulumi.Input[str] content: Contents of record rules in yaml format.
        :param pulumi.Input[str] instance_id: Instance Id.
        :param pulumi.Input[str] name: Name of the instance.
        :param pulumi.Input[str] template_id: Used for the argument, if the configuration comes to the template, the template id.
        :param pulumi.Input[str] update_time: Last modified time of record rule.
        """
        if cluster_id is not None:
            pulumi.set(__self__, "cluster_id", cluster_id)
        if content is not None:
            pulumi.set(__self__, "content", content)
        if instance_id is not None:
            pulumi.set(__self__, "instance_id", instance_id)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if template_id is not None:
            pulumi.set(__self__, "template_id", template_id)
        if update_time is not None:
            pulumi.set(__self__, "update_time", update_time)

    @property
    @pulumi.getter(name="clusterId")
    def cluster_id(self) -> Optional[pulumi.Input[str]]:
        """
        An ID identify the cluster, like cls-xxxxxx.
        """
        return pulumi.get(self, "cluster_id")

    @cluster_id.setter
    def cluster_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cluster_id", value)

    @property
    @pulumi.getter
    def content(self) -> Optional[pulumi.Input[str]]:
        """
        Contents of record rules in yaml format.
        """
        return pulumi.get(self, "content")

    @content.setter
    def content(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "content", value)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> Optional[pulumi.Input[str]]:
        """
        Instance Id.
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "instance_id", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the instance.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="templateId")
    def template_id(self) -> Optional[pulumi.Input[str]]:
        """
        Used for the argument, if the configuration comes to the template, the template id.
        """
        return pulumi.get(self, "template_id")

    @template_id.setter
    def template_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "template_id", value)

    @property
    @pulumi.getter(name="updateTime")
    def update_time(self) -> Optional[pulumi.Input[str]]:
        """
        Last modified time of record rule.
        """
        return pulumi.get(self, "update_time")

    @update_time.setter
    def update_time(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "update_time", value)


class TmpTkeRecordRuleYaml(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 content: Optional[pulumi.Input[str]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a resource to create a tke tmpRecordRule

        ## Example Usage

        ```python
        import pulumi
        import pulumi_tencentcloud as tencentcloud
        import tencentcloud_iac_pulumi as tencentcloud

        config = pulumi.Config()
        default_instance_type = config.get("defaultInstanceType")
        if default_instance_type is None:
            default_instance_type = "SA1.MEDIUM2"
        availability_zone_first = config.get("availabilityZoneFirst")
        if availability_zone_first is None:
            availability_zone_first = "ap-guangzhou-3"
        availability_zone_second = config.get("availabilityZoneSecond")
        if availability_zone_second is None:
            availability_zone_second = "ap-guangzhou-4"
        example_cluster_cidr = config.get("exampleClusterCidr")
        if example_cluster_cidr is None:
            example_cluster_cidr = "10.31.0.0/16"
        vpc_one = tencentcloud.Vpc.get_subnets(is_default=True,
            availability_zone=availability_zone_first)
        first_vpc_id = vpc_one.instance_lists[0].vpc_id
        first_subnet_id = vpc_one.instance_lists[0].subnet_id
        vpc_two = tencentcloud.Vpc.get_subnets(is_default=True,
            availability_zone=availability_zone_second)
        second_vpc_id = vpc_two.instance_lists[0].vpc_id
        second_subnet_id = vpc_two.instance_lists[0].subnet_id
        sg = tencentcloud.security.Group("sg")
        sg_id = sg.id
        default = tencentcloud.Images.get_instance(image_types=["PUBLIC_IMAGE"],
            image_name_regex="Final")
        image_id = default.image_id
        sg_rule = tencentcloud.security.GroupLiteRule("sgRule",
            security_group_id=sg.id,
            ingresses=[
                "ACCEPT#10.0.0.0/16#ALL#ALL",
                "ACCEPT#172.16.0.0/22#ALL#ALL",
                "DROP#0.0.0.0/0#ALL#ALL",
            ],
            egresses=["ACCEPT#172.16.0.0/22#ALL#ALL"])
        example = tencentcloud.kubernetes.Cluster("example",
            vpc_id=first_vpc_id,
            cluster_cidr=example_cluster_cidr,
            cluster_max_pod_num=32,
            cluster_name="tf_example_cluster",
            cluster_desc="example for tke cluster",
            cluster_max_service_num=32,
            cluster_internet=False,
            cluster_internet_security_group=sg_id,
            cluster_version="1.22.5",
            cluster_deploy_type="MANAGED_CLUSTER",
            worker_configs=[
                tencentcloud.kubernetes.ClusterWorkerConfigArgs(
                    count=1,
                    availability_zone=availability_zone_first,
                    instance_type=default_instance_type,
                    system_disk_type="CLOUD_SSD",
                    system_disk_size=60,
                    internet_charge_type="TRAFFIC_POSTPAID_BY_HOUR",
                    internet_max_bandwidth_out=100,
                    public_ip_assigned=True,
                    subnet_id=first_subnet_id,
                    img_id=image_id,
                    data_disks=[tencentcloud.kubernetes.ClusterWorkerConfigDataDiskArgs(
                        disk_type="CLOUD_PREMIUM",
                        disk_size=50,
                    )],
                    enhanced_security_service=False,
                    enhanced_monitor_service=False,
                    user_data="dGVzdA==",
                    password="ZZXXccvv1212",
                ),
                tencentcloud.kubernetes.ClusterWorkerConfigArgs(
                    count=1,
                    availability_zone=availability_zone_second,
                    instance_type=default_instance_type,
                    system_disk_type="CLOUD_SSD",
                    system_disk_size=60,
                    internet_charge_type="TRAFFIC_POSTPAID_BY_HOUR",
                    internet_max_bandwidth_out=100,
                    public_ip_assigned=True,
                    subnet_id=second_subnet_id,
                    data_disks=[tencentcloud.kubernetes.ClusterWorkerConfigDataDiskArgs(
                        disk_type="CLOUD_PREMIUM",
                        disk_size=50,
                    )],
                    enhanced_security_service=False,
                    enhanced_monitor_service=False,
                    user_data="dGVzdA==",
                    cam_role_name="CVM_QcsRole",
                    password="ZZXXccvv1212",
                ),
            ],
            labels={
                "test1": "test1",
                "test2": "test2",
            })
        zone = config.get("zone")
        if zone is None:
            zone = "ap-guangzhou"
        cluster_type = config.get("clusterType")
        if cluster_type is None:
            cluster_type = "tke"
        foo_tmp_instance = tencentcloud.monitor.TmpInstance("fooTmpInstance",
            instance_name="tf-tmp-instance",
            vpc_id=first_vpc_id,
            subnet_id=first_subnet_id,
            data_retention_time=30,
            zone=availability_zone_second,
            tags={
                "createdBy": "terraform",
            })
        # tmp tke bind
        foo_tmp_tke_cluster_agent = tencentcloud.monitor.TmpTkeClusterAgent("fooTmpTkeClusterAgent",
            instance_id=foo_tmp_instance.id,
            agents=tencentcloud.monitor.TmpTkeClusterAgentAgentsArgs(
                region=zone,
                cluster_type=cluster_type,
                cluster_id=example.id,
                enable_external=False,
            ))
        # create record rule
        foo_tmp_tke_record_rule_yaml = tencentcloud.monitor.TmpTkeRecordRuleYaml("fooTmpTkeRecordRuleYaml",
            instance_id=foo_tmp_instance.id,
            content=\"\"\"apiVersion: monitoring.coreos.com/v1
        kind: PrometheusRule
        metadata:
          name: example-record
        spec:
          groups:
            - name: kube-apiserver.rules
              rules:
                - expr: sum(metrics_test)
                  labels:
                    verb: read
                  record: 'apiserver_request:burnrate1d'
        \"\"\",
            opts=pulumi.ResourceOptions(depends_on=[foo_tmp_tke_cluster_agent]))
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] content: Contents of record rules in yaml format.
        :param pulumi.Input[str] instance_id: Instance Id.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: TmpTkeRecordRuleYamlArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a tke tmpRecordRule

        ## Example Usage

        ```python
        import pulumi
        import pulumi_tencentcloud as tencentcloud
        import tencentcloud_iac_pulumi as tencentcloud

        config = pulumi.Config()
        default_instance_type = config.get("defaultInstanceType")
        if default_instance_type is None:
            default_instance_type = "SA1.MEDIUM2"
        availability_zone_first = config.get("availabilityZoneFirst")
        if availability_zone_first is None:
            availability_zone_first = "ap-guangzhou-3"
        availability_zone_second = config.get("availabilityZoneSecond")
        if availability_zone_second is None:
            availability_zone_second = "ap-guangzhou-4"
        example_cluster_cidr = config.get("exampleClusterCidr")
        if example_cluster_cidr is None:
            example_cluster_cidr = "10.31.0.0/16"
        vpc_one = tencentcloud.Vpc.get_subnets(is_default=True,
            availability_zone=availability_zone_first)
        first_vpc_id = vpc_one.instance_lists[0].vpc_id
        first_subnet_id = vpc_one.instance_lists[0].subnet_id
        vpc_two = tencentcloud.Vpc.get_subnets(is_default=True,
            availability_zone=availability_zone_second)
        second_vpc_id = vpc_two.instance_lists[0].vpc_id
        second_subnet_id = vpc_two.instance_lists[0].subnet_id
        sg = tencentcloud.security.Group("sg")
        sg_id = sg.id
        default = tencentcloud.Images.get_instance(image_types=["PUBLIC_IMAGE"],
            image_name_regex="Final")
        image_id = default.image_id
        sg_rule = tencentcloud.security.GroupLiteRule("sgRule",
            security_group_id=sg.id,
            ingresses=[
                "ACCEPT#10.0.0.0/16#ALL#ALL",
                "ACCEPT#172.16.0.0/22#ALL#ALL",
                "DROP#0.0.0.0/0#ALL#ALL",
            ],
            egresses=["ACCEPT#172.16.0.0/22#ALL#ALL"])
        example = tencentcloud.kubernetes.Cluster("example",
            vpc_id=first_vpc_id,
            cluster_cidr=example_cluster_cidr,
            cluster_max_pod_num=32,
            cluster_name="tf_example_cluster",
            cluster_desc="example for tke cluster",
            cluster_max_service_num=32,
            cluster_internet=False,
            cluster_internet_security_group=sg_id,
            cluster_version="1.22.5",
            cluster_deploy_type="MANAGED_CLUSTER",
            worker_configs=[
                tencentcloud.kubernetes.ClusterWorkerConfigArgs(
                    count=1,
                    availability_zone=availability_zone_first,
                    instance_type=default_instance_type,
                    system_disk_type="CLOUD_SSD",
                    system_disk_size=60,
                    internet_charge_type="TRAFFIC_POSTPAID_BY_HOUR",
                    internet_max_bandwidth_out=100,
                    public_ip_assigned=True,
                    subnet_id=first_subnet_id,
                    img_id=image_id,
                    data_disks=[tencentcloud.kubernetes.ClusterWorkerConfigDataDiskArgs(
                        disk_type="CLOUD_PREMIUM",
                        disk_size=50,
                    )],
                    enhanced_security_service=False,
                    enhanced_monitor_service=False,
                    user_data="dGVzdA==",
                    password="ZZXXccvv1212",
                ),
                tencentcloud.kubernetes.ClusterWorkerConfigArgs(
                    count=1,
                    availability_zone=availability_zone_second,
                    instance_type=default_instance_type,
                    system_disk_type="CLOUD_SSD",
                    system_disk_size=60,
                    internet_charge_type="TRAFFIC_POSTPAID_BY_HOUR",
                    internet_max_bandwidth_out=100,
                    public_ip_assigned=True,
                    subnet_id=second_subnet_id,
                    data_disks=[tencentcloud.kubernetes.ClusterWorkerConfigDataDiskArgs(
                        disk_type="CLOUD_PREMIUM",
                        disk_size=50,
                    )],
                    enhanced_security_service=False,
                    enhanced_monitor_service=False,
                    user_data="dGVzdA==",
                    cam_role_name="CVM_QcsRole",
                    password="ZZXXccvv1212",
                ),
            ],
            labels={
                "test1": "test1",
                "test2": "test2",
            })
        zone = config.get("zone")
        if zone is None:
            zone = "ap-guangzhou"
        cluster_type = config.get("clusterType")
        if cluster_type is None:
            cluster_type = "tke"
        foo_tmp_instance = tencentcloud.monitor.TmpInstance("fooTmpInstance",
            instance_name="tf-tmp-instance",
            vpc_id=first_vpc_id,
            subnet_id=first_subnet_id,
            data_retention_time=30,
            zone=availability_zone_second,
            tags={
                "createdBy": "terraform",
            })
        # tmp tke bind
        foo_tmp_tke_cluster_agent = tencentcloud.monitor.TmpTkeClusterAgent("fooTmpTkeClusterAgent",
            instance_id=foo_tmp_instance.id,
            agents=tencentcloud.monitor.TmpTkeClusterAgentAgentsArgs(
                region=zone,
                cluster_type=cluster_type,
                cluster_id=example.id,
                enable_external=False,
            ))
        # create record rule
        foo_tmp_tke_record_rule_yaml = tencentcloud.monitor.TmpTkeRecordRuleYaml("fooTmpTkeRecordRuleYaml",
            instance_id=foo_tmp_instance.id,
            content=\"\"\"apiVersion: monitoring.coreos.com/v1
        kind: PrometheusRule
        metadata:
          name: example-record
        spec:
          groups:
            - name: kube-apiserver.rules
              rules:
                - expr: sum(metrics_test)
                  labels:
                    verb: read
                  record: 'apiserver_request:burnrate1d'
        \"\"\",
            opts=pulumi.ResourceOptions(depends_on=[foo_tmp_tke_cluster_agent]))
        ```

        :param str resource_name: The name of the resource.
        :param TmpTkeRecordRuleYamlArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(TmpTkeRecordRuleYamlArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 content: Optional[pulumi.Input[str]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
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
            __props__ = TmpTkeRecordRuleYamlArgs.__new__(TmpTkeRecordRuleYamlArgs)

            if content is None and not opts.urn:
                raise TypeError("Missing required property 'content'")
            __props__.__dict__["content"] = content
            if instance_id is None and not opts.urn:
                raise TypeError("Missing required property 'instance_id'")
            __props__.__dict__["instance_id"] = instance_id
            __props__.__dict__["cluster_id"] = None
            __props__.__dict__["name"] = None
            __props__.__dict__["template_id"] = None
            __props__.__dict__["update_time"] = None
        super(TmpTkeRecordRuleYaml, __self__).__init__(
            'tencentcloud:Monitor/tmpTkeRecordRuleYaml:TmpTkeRecordRuleYaml',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            cluster_id: Optional[pulumi.Input[str]] = None,
            content: Optional[pulumi.Input[str]] = None,
            instance_id: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            template_id: Optional[pulumi.Input[str]] = None,
            update_time: Optional[pulumi.Input[str]] = None) -> 'TmpTkeRecordRuleYaml':
        """
        Get an existing TmpTkeRecordRuleYaml resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] cluster_id: An ID identify the cluster, like cls-xxxxxx.
        :param pulumi.Input[str] content: Contents of record rules in yaml format.
        :param pulumi.Input[str] instance_id: Instance Id.
        :param pulumi.Input[str] name: Name of the instance.
        :param pulumi.Input[str] template_id: Used for the argument, if the configuration comes to the template, the template id.
        :param pulumi.Input[str] update_time: Last modified time of record rule.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _TmpTkeRecordRuleYamlState.__new__(_TmpTkeRecordRuleYamlState)

        __props__.__dict__["cluster_id"] = cluster_id
        __props__.__dict__["content"] = content
        __props__.__dict__["instance_id"] = instance_id
        __props__.__dict__["name"] = name
        __props__.__dict__["template_id"] = template_id
        __props__.__dict__["update_time"] = update_time
        return TmpTkeRecordRuleYaml(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="clusterId")
    def cluster_id(self) -> pulumi.Output[str]:
        """
        An ID identify the cluster, like cls-xxxxxx.
        """
        return pulumi.get(self, "cluster_id")

    @property
    @pulumi.getter
    def content(self) -> pulumi.Output[str]:
        """
        Contents of record rules in yaml format.
        """
        return pulumi.get(self, "content")

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Output[str]:
        """
        Instance Id.
        """
        return pulumi.get(self, "instance_id")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Name of the instance.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="templateId")
    def template_id(self) -> pulumi.Output[str]:
        """
        Used for the argument, if the configuration comes to the template, the template id.
        """
        return pulumi.get(self, "template_id")

    @property
    @pulumi.getter(name="updateTime")
    def update_time(self) -> pulumi.Output[str]:
        """
        Last modified time of record rule.
        """
        return pulumi.get(self, "update_time")

