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

__all__ = ['BatchArgs', 'Batch']

@pulumi.input_type
class BatchArgs:
    def __init__(__self__, *,
                 appid: pulumi.Input[int],
                 manifest: pulumi.Input['BatchManifestArgs'],
                 operation: pulumi.Input['BatchOperationArgs'],
                 priority: pulumi.Input[int],
                 report: pulumi.Input['BatchReportArgs'],
                 role_arn: pulumi.Input[str],
                 uin: pulumi.Input[str],
                 confirmation_required: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a Batch resource.
        :param pulumi.Input[int] appid: Appid.
        :param pulumi.Input['BatchManifestArgs'] manifest: List of objects to be processed.
        :param pulumi.Input['BatchOperationArgs'] operation: Select the action to be performed on the objects in the manifest file.
        :param pulumi.Input[int] priority: Mission priority. The higher the value, the higher the priority of the task. Priority values range from 0 to 2147483647.
        :param pulumi.Input['BatchReportArgs'] report: Task completion report.
        :param pulumi.Input[str] role_arn: COS resource identifier, which is used to identify the role you created. You need this resource identifier to verify your identity.
        :param pulumi.Input[str] uin: Uin.
        :param pulumi.Input[bool] confirmation_required: Whether to confirm before performing the task. The default is false.
        :param pulumi.Input[str] description: Mission description. If you configured this information when you created the task, the content is returned. The description length ranges from 0 to 256 bytes.
        :param pulumi.Input[str] status: Current status of the task.
               Legal parameter values include Active, Cancelled, Cancelling, Complete, Completing, Failed, Failing, New, Paused, Pausing, Preparing, Ready, Suspended.
               For Update status, when you move a task to the Ready state, COS will assume that you have confirmed the task and will perform it. When you move a task to the Cancelled state, COS cancels the task. Optional parameters include: Ready, Cancelled.
        """
        pulumi.set(__self__, "appid", appid)
        pulumi.set(__self__, "manifest", manifest)
        pulumi.set(__self__, "operation", operation)
        pulumi.set(__self__, "priority", priority)
        pulumi.set(__self__, "report", report)
        pulumi.set(__self__, "role_arn", role_arn)
        pulumi.set(__self__, "uin", uin)
        if confirmation_required is not None:
            pulumi.set(__self__, "confirmation_required", confirmation_required)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if status is not None:
            pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter
    def appid(self) -> pulumi.Input[int]:
        """
        Appid.
        """
        return pulumi.get(self, "appid")

    @appid.setter
    def appid(self, value: pulumi.Input[int]):
        pulumi.set(self, "appid", value)

    @property
    @pulumi.getter
    def manifest(self) -> pulumi.Input['BatchManifestArgs']:
        """
        List of objects to be processed.
        """
        return pulumi.get(self, "manifest")

    @manifest.setter
    def manifest(self, value: pulumi.Input['BatchManifestArgs']):
        pulumi.set(self, "manifest", value)

    @property
    @pulumi.getter
    def operation(self) -> pulumi.Input['BatchOperationArgs']:
        """
        Select the action to be performed on the objects in the manifest file.
        """
        return pulumi.get(self, "operation")

    @operation.setter
    def operation(self, value: pulumi.Input['BatchOperationArgs']):
        pulumi.set(self, "operation", value)

    @property
    @pulumi.getter
    def priority(self) -> pulumi.Input[int]:
        """
        Mission priority. The higher the value, the higher the priority of the task. Priority values range from 0 to 2147483647.
        """
        return pulumi.get(self, "priority")

    @priority.setter
    def priority(self, value: pulumi.Input[int]):
        pulumi.set(self, "priority", value)

    @property
    @pulumi.getter
    def report(self) -> pulumi.Input['BatchReportArgs']:
        """
        Task completion report.
        """
        return pulumi.get(self, "report")

    @report.setter
    def report(self, value: pulumi.Input['BatchReportArgs']):
        pulumi.set(self, "report", value)

    @property
    @pulumi.getter(name="roleArn")
    def role_arn(self) -> pulumi.Input[str]:
        """
        COS resource identifier, which is used to identify the role you created. You need this resource identifier to verify your identity.
        """
        return pulumi.get(self, "role_arn")

    @role_arn.setter
    def role_arn(self, value: pulumi.Input[str]):
        pulumi.set(self, "role_arn", value)

    @property
    @pulumi.getter
    def uin(self) -> pulumi.Input[str]:
        """
        Uin.
        """
        return pulumi.get(self, "uin")

    @uin.setter
    def uin(self, value: pulumi.Input[str]):
        pulumi.set(self, "uin", value)

    @property
    @pulumi.getter(name="confirmationRequired")
    def confirmation_required(self) -> Optional[pulumi.Input[bool]]:
        """
        Whether to confirm before performing the task. The default is false.
        """
        return pulumi.get(self, "confirmation_required")

    @confirmation_required.setter
    def confirmation_required(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "confirmation_required", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Mission description. If you configured this information when you created the task, the content is returned. The description length ranges from 0 to 256 bytes.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[str]]:
        """
        Current status of the task.
        Legal parameter values include Active, Cancelled, Cancelling, Complete, Completing, Failed, Failing, New, Paused, Pausing, Preparing, Ready, Suspended.
        For Update status, when you move a task to the Ready state, COS will assume that you have confirmed the task and will perform it. When you move a task to the Cancelled state, COS cancels the task. Optional parameters include: Ready, Cancelled.
        """
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "status", value)


@pulumi.input_type
class _BatchState:
    def __init__(__self__, *,
                 appid: Optional[pulumi.Input[int]] = None,
                 confirmation_required: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 job_id: Optional[pulumi.Input[str]] = None,
                 manifest: Optional[pulumi.Input['BatchManifestArgs']] = None,
                 operation: Optional[pulumi.Input['BatchOperationArgs']] = None,
                 priority: Optional[pulumi.Input[int]] = None,
                 report: Optional[pulumi.Input['BatchReportArgs']] = None,
                 role_arn: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 uin: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering Batch resources.
        :param pulumi.Input[int] appid: Appid.
        :param pulumi.Input[bool] confirmation_required: Whether to confirm before performing the task. The default is false.
        :param pulumi.Input[str] description: Mission description. If you configured this information when you created the task, the content is returned. The description length ranges from 0 to 256 bytes.
        :param pulumi.Input[str] job_id: Job id.
        :param pulumi.Input['BatchManifestArgs'] manifest: List of objects to be processed.
        :param pulumi.Input['BatchOperationArgs'] operation: Select the action to be performed on the objects in the manifest file.
        :param pulumi.Input[int] priority: Mission priority. The higher the value, the higher the priority of the task. Priority values range from 0 to 2147483647.
        :param pulumi.Input['BatchReportArgs'] report: Task completion report.
        :param pulumi.Input[str] role_arn: COS resource identifier, which is used to identify the role you created. You need this resource identifier to verify your identity.
        :param pulumi.Input[str] status: Current status of the task.
               Legal parameter values include Active, Cancelled, Cancelling, Complete, Completing, Failed, Failing, New, Paused, Pausing, Preparing, Ready, Suspended.
               For Update status, when you move a task to the Ready state, COS will assume that you have confirmed the task and will perform it. When you move a task to the Cancelled state, COS cancels the task. Optional parameters include: Ready, Cancelled.
        :param pulumi.Input[str] uin: Uin.
        """
        if appid is not None:
            pulumi.set(__self__, "appid", appid)
        if confirmation_required is not None:
            pulumi.set(__self__, "confirmation_required", confirmation_required)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if job_id is not None:
            pulumi.set(__self__, "job_id", job_id)
        if manifest is not None:
            pulumi.set(__self__, "manifest", manifest)
        if operation is not None:
            pulumi.set(__self__, "operation", operation)
        if priority is not None:
            pulumi.set(__self__, "priority", priority)
        if report is not None:
            pulumi.set(__self__, "report", report)
        if role_arn is not None:
            pulumi.set(__self__, "role_arn", role_arn)
        if status is not None:
            pulumi.set(__self__, "status", status)
        if uin is not None:
            pulumi.set(__self__, "uin", uin)

    @property
    @pulumi.getter
    def appid(self) -> Optional[pulumi.Input[int]]:
        """
        Appid.
        """
        return pulumi.get(self, "appid")

    @appid.setter
    def appid(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "appid", value)

    @property
    @pulumi.getter(name="confirmationRequired")
    def confirmation_required(self) -> Optional[pulumi.Input[bool]]:
        """
        Whether to confirm before performing the task. The default is false.
        """
        return pulumi.get(self, "confirmation_required")

    @confirmation_required.setter
    def confirmation_required(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "confirmation_required", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Mission description. If you configured this information when you created the task, the content is returned. The description length ranges from 0 to 256 bytes.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="jobId")
    def job_id(self) -> Optional[pulumi.Input[str]]:
        """
        Job id.
        """
        return pulumi.get(self, "job_id")

    @job_id.setter
    def job_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "job_id", value)

    @property
    @pulumi.getter
    def manifest(self) -> Optional[pulumi.Input['BatchManifestArgs']]:
        """
        List of objects to be processed.
        """
        return pulumi.get(self, "manifest")

    @manifest.setter
    def manifest(self, value: Optional[pulumi.Input['BatchManifestArgs']]):
        pulumi.set(self, "manifest", value)

    @property
    @pulumi.getter
    def operation(self) -> Optional[pulumi.Input['BatchOperationArgs']]:
        """
        Select the action to be performed on the objects in the manifest file.
        """
        return pulumi.get(self, "operation")

    @operation.setter
    def operation(self, value: Optional[pulumi.Input['BatchOperationArgs']]):
        pulumi.set(self, "operation", value)

    @property
    @pulumi.getter
    def priority(self) -> Optional[pulumi.Input[int]]:
        """
        Mission priority. The higher the value, the higher the priority of the task. Priority values range from 0 to 2147483647.
        """
        return pulumi.get(self, "priority")

    @priority.setter
    def priority(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "priority", value)

    @property
    @pulumi.getter
    def report(self) -> Optional[pulumi.Input['BatchReportArgs']]:
        """
        Task completion report.
        """
        return pulumi.get(self, "report")

    @report.setter
    def report(self, value: Optional[pulumi.Input['BatchReportArgs']]):
        pulumi.set(self, "report", value)

    @property
    @pulumi.getter(name="roleArn")
    def role_arn(self) -> Optional[pulumi.Input[str]]:
        """
        COS resource identifier, which is used to identify the role you created. You need this resource identifier to verify your identity.
        """
        return pulumi.get(self, "role_arn")

    @role_arn.setter
    def role_arn(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "role_arn", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[str]]:
        """
        Current status of the task.
        Legal parameter values include Active, Cancelled, Cancelling, Complete, Completing, Failed, Failing, New, Paused, Pausing, Preparing, Ready, Suspended.
        For Update status, when you move a task to the Ready state, COS will assume that you have confirmed the task and will perform it. When you move a task to the Cancelled state, COS cancels the task. Optional parameters include: Ready, Cancelled.
        """
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "status", value)

    @property
    @pulumi.getter
    def uin(self) -> Optional[pulumi.Input[str]]:
        """
        Uin.
        """
        return pulumi.get(self, "uin")

    @uin.setter
    def uin(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "uin", value)


class Batch(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 appid: Optional[pulumi.Input[int]] = None,
                 confirmation_required: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 manifest: Optional[pulumi.Input[pulumi.InputType['BatchManifestArgs']]] = None,
                 operation: Optional[pulumi.Input[pulumi.InputType['BatchOperationArgs']]] = None,
                 priority: Optional[pulumi.Input[int]] = None,
                 report: Optional[pulumi.Input[pulumi.InputType['BatchReportArgs']]] = None,
                 role_arn: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 uin: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a resource to create a cos bucket batch.

        > **NOTE:** The current resource does not support `cos_domain`.

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        cos_batch = tencentcloud.cos.Batch("cosBatch",
            appid=1308919341,
            confirmation_required=True,
            description="cos_batch",
            manifest=tencentcloud.cos.BatchManifestArgs(
                location=tencentcloud.cos.BatchManifestLocationArgs(
                    etag="64357de8fd75a3abae2200135a2c9627",
                    object_arn="qcs::cos:ap-guangzhou:uid/1308919341:keep-test-1308919341/cos_bucket_inventory/1308919341/keep-test/test/20230621/manifest.json",
                ),
                spec=tencentcloud.cos.BatchManifestSpecArgs(
                    format="COSInventoryReport_CSV_V1",
                ),
            ),
            operation=tencentcloud.cos.BatchOperationArgs(
                cos_put_object_copy=tencentcloud.cos.BatchOperationCosPutObjectCopyArgs(
                    access_control_directive="Copy",
                    metadata_directive="Copy",
                    prefix_replace=False,
                    storage_class="STANDARD",
                    tagging_directive="Copy",
                    target_resource="qcs::cos:ap-guangzhou:uid/1308919341:cos-lock-1308919341",
                ),
            ),
            priority=1,
            report=tencentcloud.cos.BatchReportArgs(
                bucket="qcs::cos:ap-guangzhou:uid/1308919341:keep-test-1308919341",
                enabled="true",
                format="Report_CSV_V1",
                report_scope="AllTasks",
            ),
            role_arn="qcs::cam::uin/100022975249:roleName/COSBatch_QCSRole",
            status="Cancelled",
            uin="100022975249")
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        cos bucket batch can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Cos/batch:Batch cos_batch ${uin}#${appid}#{job_id}
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[int] appid: Appid.
        :param pulumi.Input[bool] confirmation_required: Whether to confirm before performing the task. The default is false.
        :param pulumi.Input[str] description: Mission description. If you configured this information when you created the task, the content is returned. The description length ranges from 0 to 256 bytes.
        :param pulumi.Input[pulumi.InputType['BatchManifestArgs']] manifest: List of objects to be processed.
        :param pulumi.Input[pulumi.InputType['BatchOperationArgs']] operation: Select the action to be performed on the objects in the manifest file.
        :param pulumi.Input[int] priority: Mission priority. The higher the value, the higher the priority of the task. Priority values range from 0 to 2147483647.
        :param pulumi.Input[pulumi.InputType['BatchReportArgs']] report: Task completion report.
        :param pulumi.Input[str] role_arn: COS resource identifier, which is used to identify the role you created. You need this resource identifier to verify your identity.
        :param pulumi.Input[str] status: Current status of the task.
               Legal parameter values include Active, Cancelled, Cancelling, Complete, Completing, Failed, Failing, New, Paused, Pausing, Preparing, Ready, Suspended.
               For Update status, when you move a task to the Ready state, COS will assume that you have confirmed the task and will perform it. When you move a task to the Cancelled state, COS cancels the task. Optional parameters include: Ready, Cancelled.
        :param pulumi.Input[str] uin: Uin.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: BatchArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a cos bucket batch.

        > **NOTE:** The current resource does not support `cos_domain`.

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        cos_batch = tencentcloud.cos.Batch("cosBatch",
            appid=1308919341,
            confirmation_required=True,
            description="cos_batch",
            manifest=tencentcloud.cos.BatchManifestArgs(
                location=tencentcloud.cos.BatchManifestLocationArgs(
                    etag="64357de8fd75a3abae2200135a2c9627",
                    object_arn="qcs::cos:ap-guangzhou:uid/1308919341:keep-test-1308919341/cos_bucket_inventory/1308919341/keep-test/test/20230621/manifest.json",
                ),
                spec=tencentcloud.cos.BatchManifestSpecArgs(
                    format="COSInventoryReport_CSV_V1",
                ),
            ),
            operation=tencentcloud.cos.BatchOperationArgs(
                cos_put_object_copy=tencentcloud.cos.BatchOperationCosPutObjectCopyArgs(
                    access_control_directive="Copy",
                    metadata_directive="Copy",
                    prefix_replace=False,
                    storage_class="STANDARD",
                    tagging_directive="Copy",
                    target_resource="qcs::cos:ap-guangzhou:uid/1308919341:cos-lock-1308919341",
                ),
            ),
            priority=1,
            report=tencentcloud.cos.BatchReportArgs(
                bucket="qcs::cos:ap-guangzhou:uid/1308919341:keep-test-1308919341",
                enabled="true",
                format="Report_CSV_V1",
                report_scope="AllTasks",
            ),
            role_arn="qcs::cam::uin/100022975249:roleName/COSBatch_QCSRole",
            status="Cancelled",
            uin="100022975249")
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        cos bucket batch can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Cos/batch:Batch cos_batch ${uin}#${appid}#{job_id}
        ```

        :param str resource_name: The name of the resource.
        :param BatchArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(BatchArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 appid: Optional[pulumi.Input[int]] = None,
                 confirmation_required: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 manifest: Optional[pulumi.Input[pulumi.InputType['BatchManifestArgs']]] = None,
                 operation: Optional[pulumi.Input[pulumi.InputType['BatchOperationArgs']]] = None,
                 priority: Optional[pulumi.Input[int]] = None,
                 report: Optional[pulumi.Input[pulumi.InputType['BatchReportArgs']]] = None,
                 role_arn: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 uin: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = BatchArgs.__new__(BatchArgs)

            if appid is None and not opts.urn:
                raise TypeError("Missing required property 'appid'")
            __props__.__dict__["appid"] = appid
            __props__.__dict__["confirmation_required"] = confirmation_required
            __props__.__dict__["description"] = description
            if manifest is None and not opts.urn:
                raise TypeError("Missing required property 'manifest'")
            __props__.__dict__["manifest"] = manifest
            if operation is None and not opts.urn:
                raise TypeError("Missing required property 'operation'")
            __props__.__dict__["operation"] = operation
            if priority is None and not opts.urn:
                raise TypeError("Missing required property 'priority'")
            __props__.__dict__["priority"] = priority
            if report is None and not opts.urn:
                raise TypeError("Missing required property 'report'")
            __props__.__dict__["report"] = report
            if role_arn is None and not opts.urn:
                raise TypeError("Missing required property 'role_arn'")
            __props__.__dict__["role_arn"] = role_arn
            __props__.__dict__["status"] = status
            if uin is None and not opts.urn:
                raise TypeError("Missing required property 'uin'")
            __props__.__dict__["uin"] = uin
            __props__.__dict__["job_id"] = None
        super(Batch, __self__).__init__(
            'tencentcloud:Cos/batch:Batch',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            appid: Optional[pulumi.Input[int]] = None,
            confirmation_required: Optional[pulumi.Input[bool]] = None,
            description: Optional[pulumi.Input[str]] = None,
            job_id: Optional[pulumi.Input[str]] = None,
            manifest: Optional[pulumi.Input[pulumi.InputType['BatchManifestArgs']]] = None,
            operation: Optional[pulumi.Input[pulumi.InputType['BatchOperationArgs']]] = None,
            priority: Optional[pulumi.Input[int]] = None,
            report: Optional[pulumi.Input[pulumi.InputType['BatchReportArgs']]] = None,
            role_arn: Optional[pulumi.Input[str]] = None,
            status: Optional[pulumi.Input[str]] = None,
            uin: Optional[pulumi.Input[str]] = None) -> 'Batch':
        """
        Get an existing Batch resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[int] appid: Appid.
        :param pulumi.Input[bool] confirmation_required: Whether to confirm before performing the task. The default is false.
        :param pulumi.Input[str] description: Mission description. If you configured this information when you created the task, the content is returned. The description length ranges from 0 to 256 bytes.
        :param pulumi.Input[str] job_id: Job id.
        :param pulumi.Input[pulumi.InputType['BatchManifestArgs']] manifest: List of objects to be processed.
        :param pulumi.Input[pulumi.InputType['BatchOperationArgs']] operation: Select the action to be performed on the objects in the manifest file.
        :param pulumi.Input[int] priority: Mission priority. The higher the value, the higher the priority of the task. Priority values range from 0 to 2147483647.
        :param pulumi.Input[pulumi.InputType['BatchReportArgs']] report: Task completion report.
        :param pulumi.Input[str] role_arn: COS resource identifier, which is used to identify the role you created. You need this resource identifier to verify your identity.
        :param pulumi.Input[str] status: Current status of the task.
               Legal parameter values include Active, Cancelled, Cancelling, Complete, Completing, Failed, Failing, New, Paused, Pausing, Preparing, Ready, Suspended.
               For Update status, when you move a task to the Ready state, COS will assume that you have confirmed the task and will perform it. When you move a task to the Cancelled state, COS cancels the task. Optional parameters include: Ready, Cancelled.
        :param pulumi.Input[str] uin: Uin.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _BatchState.__new__(_BatchState)

        __props__.__dict__["appid"] = appid
        __props__.__dict__["confirmation_required"] = confirmation_required
        __props__.__dict__["description"] = description
        __props__.__dict__["job_id"] = job_id
        __props__.__dict__["manifest"] = manifest
        __props__.__dict__["operation"] = operation
        __props__.__dict__["priority"] = priority
        __props__.__dict__["report"] = report
        __props__.__dict__["role_arn"] = role_arn
        __props__.__dict__["status"] = status
        __props__.__dict__["uin"] = uin
        return Batch(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def appid(self) -> pulumi.Output[int]:
        """
        Appid.
        """
        return pulumi.get(self, "appid")

    @property
    @pulumi.getter(name="confirmationRequired")
    def confirmation_required(self) -> pulumi.Output[Optional[bool]]:
        """
        Whether to confirm before performing the task. The default is false.
        """
        return pulumi.get(self, "confirmation_required")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        Mission description. If you configured this information when you created the task, the content is returned. The description length ranges from 0 to 256 bytes.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="jobId")
    def job_id(self) -> pulumi.Output[str]:
        """
        Job id.
        """
        return pulumi.get(self, "job_id")

    @property
    @pulumi.getter
    def manifest(self) -> pulumi.Output['outputs.BatchManifest']:
        """
        List of objects to be processed.
        """
        return pulumi.get(self, "manifest")

    @property
    @pulumi.getter
    def operation(self) -> pulumi.Output['outputs.BatchOperation']:
        """
        Select the action to be performed on the objects in the manifest file.
        """
        return pulumi.get(self, "operation")

    @property
    @pulumi.getter
    def priority(self) -> pulumi.Output[int]:
        """
        Mission priority. The higher the value, the higher the priority of the task. Priority values range from 0 to 2147483647.
        """
        return pulumi.get(self, "priority")

    @property
    @pulumi.getter
    def report(self) -> pulumi.Output['outputs.BatchReport']:
        """
        Task completion report.
        """
        return pulumi.get(self, "report")

    @property
    @pulumi.getter(name="roleArn")
    def role_arn(self) -> pulumi.Output[str]:
        """
        COS resource identifier, which is used to identify the role you created. You need this resource identifier to verify your identity.
        """
        return pulumi.get(self, "role_arn")

    @property
    @pulumi.getter
    def status(self) -> pulumi.Output[str]:
        """
        Current status of the task.
        Legal parameter values include Active, Cancelled, Cancelling, Complete, Completing, Failed, Failing, New, Paused, Pausing, Preparing, Ready, Suspended.
        For Update status, when you move a task to the Ready state, COS will assume that you have confirmed the task and will perform it. When you move a task to the Cancelled state, COS cancels the task. Optional parameters include: Ready, Cancelled.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def uin(self) -> pulumi.Output[str]:
        """
        Uin.
        """
        return pulumi.get(self, "uin")

