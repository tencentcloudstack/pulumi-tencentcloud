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

__all__ = ['NativeNodePoolArgs', 'NativeNodePool']

@pulumi.input_type
class NativeNodePoolArgs:
    def __init__(__self__, *,
                 cluster_id: pulumi.Input[str],
                 native: pulumi.Input['NativeNodePoolNativeArgs'],
                 type: pulumi.Input[str],
                 annotations: Optional[pulumi.Input[Sequence[pulumi.Input['NativeNodePoolAnnotationArgs']]]] = None,
                 deletion_protection: Optional[pulumi.Input[bool]] = None,
                 labels: Optional[pulumi.Input[Sequence[pulumi.Input['NativeNodePoolLabelArgs']]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input['NativeNodePoolTagArgs']]]] = None,
                 taints: Optional[pulumi.Input[Sequence[pulumi.Input['NativeNodePoolTaintArgs']]]] = None,
                 unschedulable: Optional[pulumi.Input[bool]] = None):
        """
        The set of arguments for constructing a NativeNodePool resource.
        :param pulumi.Input[str] cluster_id: ID of the cluster.
        :param pulumi.Input['NativeNodePoolNativeArgs'] native: Native node pool creation parameters.
        :param pulumi.Input[str] type: Node pool type. Optional value is `Native`.
        :param pulumi.Input[Sequence[pulumi.Input['NativeNodePoolAnnotationArgs']]] annotations: Node Annotation List.
        :param pulumi.Input[bool] deletion_protection: Whether to enable deletion protection.
        :param pulumi.Input[Sequence[pulumi.Input['NativeNodePoolLabelArgs']]] labels: Node Labels.
        :param pulumi.Input[str] name: Node pool name.
        :param pulumi.Input[Sequence[pulumi.Input['NativeNodePoolTagArgs']]] tags: Node tags.
        :param pulumi.Input[Sequence[pulumi.Input['NativeNodePoolTaintArgs']]] taints: Node taint.
        :param pulumi.Input[bool] unschedulable: Whether the node is not schedulable by default. The native node is not aware of it and passes false by default.
        """
        pulumi.set(__self__, "cluster_id", cluster_id)
        pulumi.set(__self__, "native", native)
        pulumi.set(__self__, "type", type)
        if annotations is not None:
            pulumi.set(__self__, "annotations", annotations)
        if deletion_protection is not None:
            pulumi.set(__self__, "deletion_protection", deletion_protection)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)
        if taints is not None:
            pulumi.set(__self__, "taints", taints)
        if unschedulable is not None:
            pulumi.set(__self__, "unschedulable", unschedulable)

    @property
    @pulumi.getter(name="clusterId")
    def cluster_id(self) -> pulumi.Input[str]:
        """
        ID of the cluster.
        """
        return pulumi.get(self, "cluster_id")

    @cluster_id.setter
    def cluster_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "cluster_id", value)

    @property
    @pulumi.getter
    def native(self) -> pulumi.Input['NativeNodePoolNativeArgs']:
        """
        Native node pool creation parameters.
        """
        return pulumi.get(self, "native")

    @native.setter
    def native(self, value: pulumi.Input['NativeNodePoolNativeArgs']):
        pulumi.set(self, "native", value)

    @property
    @pulumi.getter
    def type(self) -> pulumi.Input[str]:
        """
        Node pool type. Optional value is `Native`.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: pulumi.Input[str]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter
    def annotations(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['NativeNodePoolAnnotationArgs']]]]:
        """
        Node Annotation List.
        """
        return pulumi.get(self, "annotations")

    @annotations.setter
    def annotations(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['NativeNodePoolAnnotationArgs']]]]):
        pulumi.set(self, "annotations", value)

    @property
    @pulumi.getter(name="deletionProtection")
    def deletion_protection(self) -> Optional[pulumi.Input[bool]]:
        """
        Whether to enable deletion protection.
        """
        return pulumi.get(self, "deletion_protection")

    @deletion_protection.setter
    def deletion_protection(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "deletion_protection", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['NativeNodePoolLabelArgs']]]]:
        """
        Node Labels.
        """
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['NativeNodePoolLabelArgs']]]]):
        pulumi.set(self, "labels", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Node pool name.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['NativeNodePoolTagArgs']]]]:
        """
        Node tags.
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['NativeNodePoolTagArgs']]]]):
        pulumi.set(self, "tags", value)

    @property
    @pulumi.getter
    def taints(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['NativeNodePoolTaintArgs']]]]:
        """
        Node taint.
        """
        return pulumi.get(self, "taints")

    @taints.setter
    def taints(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['NativeNodePoolTaintArgs']]]]):
        pulumi.set(self, "taints", value)

    @property
    @pulumi.getter
    def unschedulable(self) -> Optional[pulumi.Input[bool]]:
        """
        Whether the node is not schedulable by default. The native node is not aware of it and passes false by default.
        """
        return pulumi.get(self, "unschedulable")

    @unschedulable.setter
    def unschedulable(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "unschedulable", value)


@pulumi.input_type
class _NativeNodePoolState:
    def __init__(__self__, *,
                 annotations: Optional[pulumi.Input[Sequence[pulumi.Input['NativeNodePoolAnnotationArgs']]]] = None,
                 cluster_id: Optional[pulumi.Input[str]] = None,
                 created_at: Optional[pulumi.Input[str]] = None,
                 deletion_protection: Optional[pulumi.Input[bool]] = None,
                 labels: Optional[pulumi.Input[Sequence[pulumi.Input['NativeNodePoolLabelArgs']]]] = None,
                 life_state: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 native: Optional[pulumi.Input['NativeNodePoolNativeArgs']] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input['NativeNodePoolTagArgs']]]] = None,
                 taints: Optional[pulumi.Input[Sequence[pulumi.Input['NativeNodePoolTaintArgs']]]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 unschedulable: Optional[pulumi.Input[bool]] = None):
        """
        Input properties used for looking up and filtering NativeNodePool resources.
        :param pulumi.Input[Sequence[pulumi.Input['NativeNodePoolAnnotationArgs']]] annotations: Node Annotation List.
        :param pulumi.Input[str] cluster_id: ID of the cluster.
        :param pulumi.Input[str] created_at: Creation time.
        :param pulumi.Input[bool] deletion_protection: Whether to enable deletion protection.
        :param pulumi.Input[Sequence[pulumi.Input['NativeNodePoolLabelArgs']]] labels: Node Labels.
        :param pulumi.Input[str] life_state: Node pool status.
        :param pulumi.Input[str] name: Node pool name.
        :param pulumi.Input['NativeNodePoolNativeArgs'] native: Native node pool creation parameters.
        :param pulumi.Input[Sequence[pulumi.Input['NativeNodePoolTagArgs']]] tags: Node tags.
        :param pulumi.Input[Sequence[pulumi.Input['NativeNodePoolTaintArgs']]] taints: Node taint.
        :param pulumi.Input[str] type: Node pool type. Optional value is `Native`.
        :param pulumi.Input[bool] unschedulable: Whether the node is not schedulable by default. The native node is not aware of it and passes false by default.
        """
        if annotations is not None:
            pulumi.set(__self__, "annotations", annotations)
        if cluster_id is not None:
            pulumi.set(__self__, "cluster_id", cluster_id)
        if created_at is not None:
            pulumi.set(__self__, "created_at", created_at)
        if deletion_protection is not None:
            pulumi.set(__self__, "deletion_protection", deletion_protection)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if life_state is not None:
            pulumi.set(__self__, "life_state", life_state)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if native is not None:
            pulumi.set(__self__, "native", native)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)
        if taints is not None:
            pulumi.set(__self__, "taints", taints)
        if type is not None:
            pulumi.set(__self__, "type", type)
        if unschedulable is not None:
            pulumi.set(__self__, "unschedulable", unschedulable)

    @property
    @pulumi.getter
    def annotations(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['NativeNodePoolAnnotationArgs']]]]:
        """
        Node Annotation List.
        """
        return pulumi.get(self, "annotations")

    @annotations.setter
    def annotations(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['NativeNodePoolAnnotationArgs']]]]):
        pulumi.set(self, "annotations", value)

    @property
    @pulumi.getter(name="clusterId")
    def cluster_id(self) -> Optional[pulumi.Input[str]]:
        """
        ID of the cluster.
        """
        return pulumi.get(self, "cluster_id")

    @cluster_id.setter
    def cluster_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cluster_id", value)

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> Optional[pulumi.Input[str]]:
        """
        Creation time.
        """
        return pulumi.get(self, "created_at")

    @created_at.setter
    def created_at(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "created_at", value)

    @property
    @pulumi.getter(name="deletionProtection")
    def deletion_protection(self) -> Optional[pulumi.Input[bool]]:
        """
        Whether to enable deletion protection.
        """
        return pulumi.get(self, "deletion_protection")

    @deletion_protection.setter
    def deletion_protection(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "deletion_protection", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['NativeNodePoolLabelArgs']]]]:
        """
        Node Labels.
        """
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['NativeNodePoolLabelArgs']]]]):
        pulumi.set(self, "labels", value)

    @property
    @pulumi.getter(name="lifeState")
    def life_state(self) -> Optional[pulumi.Input[str]]:
        """
        Node pool status.
        """
        return pulumi.get(self, "life_state")

    @life_state.setter
    def life_state(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "life_state", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Node pool name.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def native(self) -> Optional[pulumi.Input['NativeNodePoolNativeArgs']]:
        """
        Native node pool creation parameters.
        """
        return pulumi.get(self, "native")

    @native.setter
    def native(self, value: Optional[pulumi.Input['NativeNodePoolNativeArgs']]):
        pulumi.set(self, "native", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['NativeNodePoolTagArgs']]]]:
        """
        Node tags.
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['NativeNodePoolTagArgs']]]]):
        pulumi.set(self, "tags", value)

    @property
    @pulumi.getter
    def taints(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['NativeNodePoolTaintArgs']]]]:
        """
        Node taint.
        """
        return pulumi.get(self, "taints")

    @taints.setter
    def taints(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['NativeNodePoolTaintArgs']]]]):
        pulumi.set(self, "taints", value)

    @property
    @pulumi.getter
    def type(self) -> Optional[pulumi.Input[str]]:
        """
        Node pool type. Optional value is `Native`.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter
    def unschedulable(self) -> Optional[pulumi.Input[bool]]:
        """
        Whether the node is not schedulable by default. The native node is not aware of it and passes false by default.
        """
        return pulumi.get(self, "unschedulable")

    @unschedulable.setter
    def unschedulable(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "unschedulable", value)


class NativeNodePool(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 annotations: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['NativeNodePoolAnnotationArgs']]]]] = None,
                 cluster_id: Optional[pulumi.Input[str]] = None,
                 deletion_protection: Optional[pulumi.Input[bool]] = None,
                 labels: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['NativeNodePoolLabelArgs']]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 native: Optional[pulumi.Input[pulumi.InputType['NativeNodePoolNativeArgs']]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['NativeNodePoolTagArgs']]]]] = None,
                 taints: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['NativeNodePoolTaintArgs']]]]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 unschedulable: Optional[pulumi.Input[bool]] = None,
                 __props__=None):
        """
        Provides a resource to create a tke kubernetes_native_node_pool

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        kubernetes_native_node_pool = tencentcloud.kubernetes.NativeNodePool("kubernetesNativeNodePool",
            annotations=[
                tencentcloud.kubernetes.NativeNodePoolAnnotationArgs(
                    name="node.tke.cloud.tencent.com/test-anno",
                    value="test",
                ),
                tencentcloud.kubernetes.NativeNodePoolAnnotationArgs(
                    name="node.tke.cloud.tencent.com/test-label",
                    value="test",
                ),
            ],
            cluster_id="cls-eyier120",
            deletion_protection=False,
            labels=[tencentcloud.kubernetes.NativeNodePoolLabelArgs(
                name="test11",
                value="test21",
            )],
            native=tencentcloud.kubernetes.NativeNodePoolNativeArgs(
                auto_repair=False,
                data_disks=[tencentcloud.kubernetes.NativeNodePoolNativeDataDiskArgs(
                    auto_format_and_mount=True,
                    disk_size=60,
                    disk_type="CLOUD_PREMIUM",
                    file_system="ext4",
                    mount_target="/var/lib/containerd",
                )],
                enable_autoscaling=True,
                host_name_pattern="aaa{R:3}",
                instance_charge_prepaid=tencentcloud.kubernetes.NativeNodePoolNativeInstanceChargePrepaidArgs(
                    period=1,
                    renew_flag="NOTIFY_AND_MANUAL_RENEW",
                ),
                instance_charge_type="PREPAID",
                instance_types=["SA2.MEDIUM2"],
                internet_accessible=tencentcloud.kubernetes.NativeNodePoolNativeInternetAccessibleArgs(
                    charge_type="TRAFFIC_POSTPAID_BY_HOUR",
                    max_bandwidth_out=50,
                ),
                key_ids=["skey-9pcs2100"],
                kubelet_args=[
                    "allowed-unsafe-sysctls=net.core.somaxconn",
                    "root-dir=/var/lib/test",
                ],
                lifecycle=tencentcloud.kubernetes.NativeNodePoolNativeLifecycleArgs(
                    post_init="ZWNobyBoZWxsb3dvcmxk",
                    pre_init="ZWNobyBoZWxsb3dvcmxk",
                ),
                management=tencentcloud.kubernetes.NativeNodePoolNativeManagementArgs(
                    hosts=[
                        "192.168.2.42 static.fake.com",
                        "192.168.2.42 static.fake.com2",
                    ],
                    kernel_args=[
                        "kernel.pid_max=65535",
                        "fs.file-max=400000",
                    ],
                    nameservers=[
                        "183.60.83.19",
                        "183.60.82.98",
                    ],
                ),
                replicas=2,
                runtime_root_dir="/var/lib/docker",
                scaling=tencentcloud.kubernetes.NativeNodePoolNativeScalingArgs(
                    create_policy="ZoneEquality",
                    max_replicas=10,
                    min_replicas=1,
                ),
                security_group_ids=["sg-7tum9120"],
                subnet_ids=["subnet-itb6d123"],
                system_disk=tencentcloud.kubernetes.NativeNodePoolNativeSystemDiskArgs(
                    disk_size=50,
                    disk_type="CLOUD_SSD",
                ),
            ),
            tags=[tencentcloud.kubernetes.NativeNodePoolTagArgs(
                resource_type="machine",
                tags=[
                    tencentcloud.kubernetes.NativeNodePoolTagTagArgs(
                        key="keep-test-np1",
                        value="test1",
                    ),
                    tencentcloud.kubernetes.NativeNodePoolTagTagArgs(
                        key="keep-test-np3",
                        value="test3",
                    ),
                ],
            )],
            taints=[tencentcloud.kubernetes.NativeNodePoolTaintArgs(
                effect="NoExecute",
                key="product",
                value="coderider",
            )],
            type="Native",
            unschedulable=False)
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        tke kubernetes_native_node_pool can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Kubernetes/nativeNodePool:NativeNodePool kubernetes_native_node_pool cls-xxx#np-xxx
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['NativeNodePoolAnnotationArgs']]]] annotations: Node Annotation List.
        :param pulumi.Input[str] cluster_id: ID of the cluster.
        :param pulumi.Input[bool] deletion_protection: Whether to enable deletion protection.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['NativeNodePoolLabelArgs']]]] labels: Node Labels.
        :param pulumi.Input[str] name: Node pool name.
        :param pulumi.Input[pulumi.InputType['NativeNodePoolNativeArgs']] native: Native node pool creation parameters.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['NativeNodePoolTagArgs']]]] tags: Node tags.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['NativeNodePoolTaintArgs']]]] taints: Node taint.
        :param pulumi.Input[str] type: Node pool type. Optional value is `Native`.
        :param pulumi.Input[bool] unschedulable: Whether the node is not schedulable by default. The native node is not aware of it and passes false by default.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: NativeNodePoolArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a tke kubernetes_native_node_pool

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        kubernetes_native_node_pool = tencentcloud.kubernetes.NativeNodePool("kubernetesNativeNodePool",
            annotations=[
                tencentcloud.kubernetes.NativeNodePoolAnnotationArgs(
                    name="node.tke.cloud.tencent.com/test-anno",
                    value="test",
                ),
                tencentcloud.kubernetes.NativeNodePoolAnnotationArgs(
                    name="node.tke.cloud.tencent.com/test-label",
                    value="test",
                ),
            ],
            cluster_id="cls-eyier120",
            deletion_protection=False,
            labels=[tencentcloud.kubernetes.NativeNodePoolLabelArgs(
                name="test11",
                value="test21",
            )],
            native=tencentcloud.kubernetes.NativeNodePoolNativeArgs(
                auto_repair=False,
                data_disks=[tencentcloud.kubernetes.NativeNodePoolNativeDataDiskArgs(
                    auto_format_and_mount=True,
                    disk_size=60,
                    disk_type="CLOUD_PREMIUM",
                    file_system="ext4",
                    mount_target="/var/lib/containerd",
                )],
                enable_autoscaling=True,
                host_name_pattern="aaa{R:3}",
                instance_charge_prepaid=tencentcloud.kubernetes.NativeNodePoolNativeInstanceChargePrepaidArgs(
                    period=1,
                    renew_flag="NOTIFY_AND_MANUAL_RENEW",
                ),
                instance_charge_type="PREPAID",
                instance_types=["SA2.MEDIUM2"],
                internet_accessible=tencentcloud.kubernetes.NativeNodePoolNativeInternetAccessibleArgs(
                    charge_type="TRAFFIC_POSTPAID_BY_HOUR",
                    max_bandwidth_out=50,
                ),
                key_ids=["skey-9pcs2100"],
                kubelet_args=[
                    "allowed-unsafe-sysctls=net.core.somaxconn",
                    "root-dir=/var/lib/test",
                ],
                lifecycle=tencentcloud.kubernetes.NativeNodePoolNativeLifecycleArgs(
                    post_init="ZWNobyBoZWxsb3dvcmxk",
                    pre_init="ZWNobyBoZWxsb3dvcmxk",
                ),
                management=tencentcloud.kubernetes.NativeNodePoolNativeManagementArgs(
                    hosts=[
                        "192.168.2.42 static.fake.com",
                        "192.168.2.42 static.fake.com2",
                    ],
                    kernel_args=[
                        "kernel.pid_max=65535",
                        "fs.file-max=400000",
                    ],
                    nameservers=[
                        "183.60.83.19",
                        "183.60.82.98",
                    ],
                ),
                replicas=2,
                runtime_root_dir="/var/lib/docker",
                scaling=tencentcloud.kubernetes.NativeNodePoolNativeScalingArgs(
                    create_policy="ZoneEquality",
                    max_replicas=10,
                    min_replicas=1,
                ),
                security_group_ids=["sg-7tum9120"],
                subnet_ids=["subnet-itb6d123"],
                system_disk=tencentcloud.kubernetes.NativeNodePoolNativeSystemDiskArgs(
                    disk_size=50,
                    disk_type="CLOUD_SSD",
                ),
            ),
            tags=[tencentcloud.kubernetes.NativeNodePoolTagArgs(
                resource_type="machine",
                tags=[
                    tencentcloud.kubernetes.NativeNodePoolTagTagArgs(
                        key="keep-test-np1",
                        value="test1",
                    ),
                    tencentcloud.kubernetes.NativeNodePoolTagTagArgs(
                        key="keep-test-np3",
                        value="test3",
                    ),
                ],
            )],
            taints=[tencentcloud.kubernetes.NativeNodePoolTaintArgs(
                effect="NoExecute",
                key="product",
                value="coderider",
            )],
            type="Native",
            unschedulable=False)
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        tke kubernetes_native_node_pool can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Kubernetes/nativeNodePool:NativeNodePool kubernetes_native_node_pool cls-xxx#np-xxx
        ```

        :param str resource_name: The name of the resource.
        :param NativeNodePoolArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(NativeNodePoolArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 annotations: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['NativeNodePoolAnnotationArgs']]]]] = None,
                 cluster_id: Optional[pulumi.Input[str]] = None,
                 deletion_protection: Optional[pulumi.Input[bool]] = None,
                 labels: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['NativeNodePoolLabelArgs']]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 native: Optional[pulumi.Input[pulumi.InputType['NativeNodePoolNativeArgs']]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['NativeNodePoolTagArgs']]]]] = None,
                 taints: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['NativeNodePoolTaintArgs']]]]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 unschedulable: Optional[pulumi.Input[bool]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = NativeNodePoolArgs.__new__(NativeNodePoolArgs)

            __props__.__dict__["annotations"] = annotations
            if cluster_id is None and not opts.urn:
                raise TypeError("Missing required property 'cluster_id'")
            __props__.__dict__["cluster_id"] = cluster_id
            __props__.__dict__["deletion_protection"] = deletion_protection
            __props__.__dict__["labels"] = labels
            __props__.__dict__["name"] = name
            if native is None and not opts.urn:
                raise TypeError("Missing required property 'native'")
            __props__.__dict__["native"] = native
            __props__.__dict__["tags"] = tags
            __props__.__dict__["taints"] = taints
            if type is None and not opts.urn:
                raise TypeError("Missing required property 'type'")
            __props__.__dict__["type"] = type
            __props__.__dict__["unschedulable"] = unschedulable
            __props__.__dict__["created_at"] = None
            __props__.__dict__["life_state"] = None
        super(NativeNodePool, __self__).__init__(
            'tencentcloud:Kubernetes/nativeNodePool:NativeNodePool',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            annotations: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['NativeNodePoolAnnotationArgs']]]]] = None,
            cluster_id: Optional[pulumi.Input[str]] = None,
            created_at: Optional[pulumi.Input[str]] = None,
            deletion_protection: Optional[pulumi.Input[bool]] = None,
            labels: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['NativeNodePoolLabelArgs']]]]] = None,
            life_state: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            native: Optional[pulumi.Input[pulumi.InputType['NativeNodePoolNativeArgs']]] = None,
            tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['NativeNodePoolTagArgs']]]]] = None,
            taints: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['NativeNodePoolTaintArgs']]]]] = None,
            type: Optional[pulumi.Input[str]] = None,
            unschedulable: Optional[pulumi.Input[bool]] = None) -> 'NativeNodePool':
        """
        Get an existing NativeNodePool resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['NativeNodePoolAnnotationArgs']]]] annotations: Node Annotation List.
        :param pulumi.Input[str] cluster_id: ID of the cluster.
        :param pulumi.Input[str] created_at: Creation time.
        :param pulumi.Input[bool] deletion_protection: Whether to enable deletion protection.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['NativeNodePoolLabelArgs']]]] labels: Node Labels.
        :param pulumi.Input[str] life_state: Node pool status.
        :param pulumi.Input[str] name: Node pool name.
        :param pulumi.Input[pulumi.InputType['NativeNodePoolNativeArgs']] native: Native node pool creation parameters.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['NativeNodePoolTagArgs']]]] tags: Node tags.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['NativeNodePoolTaintArgs']]]] taints: Node taint.
        :param pulumi.Input[str] type: Node pool type. Optional value is `Native`.
        :param pulumi.Input[bool] unschedulable: Whether the node is not schedulable by default. The native node is not aware of it and passes false by default.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _NativeNodePoolState.__new__(_NativeNodePoolState)

        __props__.__dict__["annotations"] = annotations
        __props__.__dict__["cluster_id"] = cluster_id
        __props__.__dict__["created_at"] = created_at
        __props__.__dict__["deletion_protection"] = deletion_protection
        __props__.__dict__["labels"] = labels
        __props__.__dict__["life_state"] = life_state
        __props__.__dict__["name"] = name
        __props__.__dict__["native"] = native
        __props__.__dict__["tags"] = tags
        __props__.__dict__["taints"] = taints
        __props__.__dict__["type"] = type
        __props__.__dict__["unschedulable"] = unschedulable
        return NativeNodePool(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def annotations(self) -> pulumi.Output[Sequence['outputs.NativeNodePoolAnnotation']]:
        """
        Node Annotation List.
        """
        return pulumi.get(self, "annotations")

    @property
    @pulumi.getter(name="clusterId")
    def cluster_id(self) -> pulumi.Output[str]:
        """
        ID of the cluster.
        """
        return pulumi.get(self, "cluster_id")

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> pulumi.Output[str]:
        """
        Creation time.
        """
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter(name="deletionProtection")
    def deletion_protection(self) -> pulumi.Output[bool]:
        """
        Whether to enable deletion protection.
        """
        return pulumi.get(self, "deletion_protection")

    @property
    @pulumi.getter
    def labels(self) -> pulumi.Output[Optional[Sequence['outputs.NativeNodePoolLabel']]]:
        """
        Node Labels.
        """
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter(name="lifeState")
    def life_state(self) -> pulumi.Output[str]:
        """
        Node pool status.
        """
        return pulumi.get(self, "life_state")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Node pool name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def native(self) -> pulumi.Output['outputs.NativeNodePoolNative']:
        """
        Native node pool creation parameters.
        """
        return pulumi.get(self, "native")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence['outputs.NativeNodePoolTag']]]:
        """
        Node tags.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def taints(self) -> pulumi.Output[Optional[Sequence['outputs.NativeNodePoolTaint']]]:
        """
        Node taint.
        """
        return pulumi.get(self, "taints")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Node pool type. Optional value is `Native`.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def unschedulable(self) -> pulumi.Output[bool]:
        """
        Whether the node is not schedulable by default. The native node is not aware of it and passes false by default.
        """
        return pulumi.get(self, "unschedulable")

