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

__all__ = ['IntegrationOfflineTaskArgs', 'IntegrationOfflineTask']

@pulumi.input_type
class IntegrationOfflineTaskArgs:
    def __init__(__self__, *,
                 cycle_step: pulumi.Input[int],
                 delay_time: pulumi.Input[int],
                 end_time: pulumi.Input[str],
                 notes: pulumi.Input[str],
                 project_id: pulumi.Input[str],
                 start_time: pulumi.Input[str],
                 task_action: pulumi.Input[str],
                 task_info: pulumi.Input['IntegrationOfflineTaskTaskInfoArgs'],
                 task_mode: pulumi.Input[str],
                 task_name: pulumi.Input[str]):
        """
        The set of arguments for constructing a IntegrationOfflineTask resource.
        :param pulumi.Input[int] cycle_step: Interval time of scheduling, the minimum value: 1.
        :param pulumi.Input[int] delay_time: Execution time, unit is minutes, only available for day/week/month/year scheduling. For example, daily scheduling is executed once every day at 02:00, and the delayTime is 120 minutes.
        :param pulumi.Input[str] end_time: Effective end time, the format is yyyy-MM-dd HH:mm:ss.
        :param pulumi.Input[str] notes: Description information.
        :param pulumi.Input[str] project_id: Project ID.
        :param pulumi.Input[str] start_time: Effective start time, the format is yyyy-MM-dd HH:mm:ss.
        :param pulumi.Input[str] task_action: Scheduling configuration: flexible period configuration, only available for hourly/weekly/monthly/yearly scheduling. If the hourly task is specified to run at 0:00, 3:00 and 4:00 every day, it is 0,3,4.
        :param pulumi.Input['IntegrationOfflineTaskTaskInfoArgs'] task_info: Task Information.
        :param pulumi.Input[str] task_mode: Task display mode, 0: canvas mode, 1: form mode.
        :param pulumi.Input[str] task_name: Task name.
        """
        pulumi.set(__self__, "cycle_step", cycle_step)
        pulumi.set(__self__, "delay_time", delay_time)
        pulumi.set(__self__, "end_time", end_time)
        pulumi.set(__self__, "notes", notes)
        pulumi.set(__self__, "project_id", project_id)
        pulumi.set(__self__, "start_time", start_time)
        pulumi.set(__self__, "task_action", task_action)
        pulumi.set(__self__, "task_info", task_info)
        pulumi.set(__self__, "task_mode", task_mode)
        pulumi.set(__self__, "task_name", task_name)

    @property
    @pulumi.getter(name="cycleStep")
    def cycle_step(self) -> pulumi.Input[int]:
        """
        Interval time of scheduling, the minimum value: 1.
        """
        return pulumi.get(self, "cycle_step")

    @cycle_step.setter
    def cycle_step(self, value: pulumi.Input[int]):
        pulumi.set(self, "cycle_step", value)

    @property
    @pulumi.getter(name="delayTime")
    def delay_time(self) -> pulumi.Input[int]:
        """
        Execution time, unit is minutes, only available for day/week/month/year scheduling. For example, daily scheduling is executed once every day at 02:00, and the delayTime is 120 minutes.
        """
        return pulumi.get(self, "delay_time")

    @delay_time.setter
    def delay_time(self, value: pulumi.Input[int]):
        pulumi.set(self, "delay_time", value)

    @property
    @pulumi.getter(name="endTime")
    def end_time(self) -> pulumi.Input[str]:
        """
        Effective end time, the format is yyyy-MM-dd HH:mm:ss.
        """
        return pulumi.get(self, "end_time")

    @end_time.setter
    def end_time(self, value: pulumi.Input[str]):
        pulumi.set(self, "end_time", value)

    @property
    @pulumi.getter
    def notes(self) -> pulumi.Input[str]:
        """
        Description information.
        """
        return pulumi.get(self, "notes")

    @notes.setter
    def notes(self, value: pulumi.Input[str]):
        pulumi.set(self, "notes", value)

    @property
    @pulumi.getter(name="projectId")
    def project_id(self) -> pulumi.Input[str]:
        """
        Project ID.
        """
        return pulumi.get(self, "project_id")

    @project_id.setter
    def project_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "project_id", value)

    @property
    @pulumi.getter(name="startTime")
    def start_time(self) -> pulumi.Input[str]:
        """
        Effective start time, the format is yyyy-MM-dd HH:mm:ss.
        """
        return pulumi.get(self, "start_time")

    @start_time.setter
    def start_time(self, value: pulumi.Input[str]):
        pulumi.set(self, "start_time", value)

    @property
    @pulumi.getter(name="taskAction")
    def task_action(self) -> pulumi.Input[str]:
        """
        Scheduling configuration: flexible period configuration, only available for hourly/weekly/monthly/yearly scheduling. If the hourly task is specified to run at 0:00, 3:00 and 4:00 every day, it is 0,3,4.
        """
        return pulumi.get(self, "task_action")

    @task_action.setter
    def task_action(self, value: pulumi.Input[str]):
        pulumi.set(self, "task_action", value)

    @property
    @pulumi.getter(name="taskInfo")
    def task_info(self) -> pulumi.Input['IntegrationOfflineTaskTaskInfoArgs']:
        """
        Task Information.
        """
        return pulumi.get(self, "task_info")

    @task_info.setter
    def task_info(self, value: pulumi.Input['IntegrationOfflineTaskTaskInfoArgs']):
        pulumi.set(self, "task_info", value)

    @property
    @pulumi.getter(name="taskMode")
    def task_mode(self) -> pulumi.Input[str]:
        """
        Task display mode, 0: canvas mode, 1: form mode.
        """
        return pulumi.get(self, "task_mode")

    @task_mode.setter
    def task_mode(self, value: pulumi.Input[str]):
        pulumi.set(self, "task_mode", value)

    @property
    @pulumi.getter(name="taskName")
    def task_name(self) -> pulumi.Input[str]:
        """
        Task name.
        """
        return pulumi.get(self, "task_name")

    @task_name.setter
    def task_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "task_name", value)


@pulumi.input_type
class _IntegrationOfflineTaskState:
    def __init__(__self__, *,
                 cycle_step: Optional[pulumi.Input[int]] = None,
                 delay_time: Optional[pulumi.Input[int]] = None,
                 end_time: Optional[pulumi.Input[str]] = None,
                 notes: Optional[pulumi.Input[str]] = None,
                 project_id: Optional[pulumi.Input[str]] = None,
                 start_time: Optional[pulumi.Input[str]] = None,
                 task_action: Optional[pulumi.Input[str]] = None,
                 task_id: Optional[pulumi.Input[str]] = None,
                 task_info: Optional[pulumi.Input['IntegrationOfflineTaskTaskInfoArgs']] = None,
                 task_mode: Optional[pulumi.Input[str]] = None,
                 task_name: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering IntegrationOfflineTask resources.
        :param pulumi.Input[int] cycle_step: Interval time of scheduling, the minimum value: 1.
        :param pulumi.Input[int] delay_time: Execution time, unit is minutes, only available for day/week/month/year scheduling. For example, daily scheduling is executed once every day at 02:00, and the delayTime is 120 minutes.
        :param pulumi.Input[str] end_time: Effective end time, the format is yyyy-MM-dd HH:mm:ss.
        :param pulumi.Input[str] notes: Description information.
        :param pulumi.Input[str] project_id: Project ID.
        :param pulumi.Input[str] start_time: Effective start time, the format is yyyy-MM-dd HH:mm:ss.
        :param pulumi.Input[str] task_action: Scheduling configuration: flexible period configuration, only available for hourly/weekly/monthly/yearly scheduling. If the hourly task is specified to run at 0:00, 3:00 and 4:00 every day, it is 0,3,4.
        :param pulumi.Input[str] task_id: Task ID.
        :param pulumi.Input['IntegrationOfflineTaskTaskInfoArgs'] task_info: Task Information.
        :param pulumi.Input[str] task_mode: Task display mode, 0: canvas mode, 1: form mode.
        :param pulumi.Input[str] task_name: Task name.
        """
        if cycle_step is not None:
            pulumi.set(__self__, "cycle_step", cycle_step)
        if delay_time is not None:
            pulumi.set(__self__, "delay_time", delay_time)
        if end_time is not None:
            pulumi.set(__self__, "end_time", end_time)
        if notes is not None:
            pulumi.set(__self__, "notes", notes)
        if project_id is not None:
            pulumi.set(__self__, "project_id", project_id)
        if start_time is not None:
            pulumi.set(__self__, "start_time", start_time)
        if task_action is not None:
            pulumi.set(__self__, "task_action", task_action)
        if task_id is not None:
            pulumi.set(__self__, "task_id", task_id)
        if task_info is not None:
            pulumi.set(__self__, "task_info", task_info)
        if task_mode is not None:
            pulumi.set(__self__, "task_mode", task_mode)
        if task_name is not None:
            pulumi.set(__self__, "task_name", task_name)

    @property
    @pulumi.getter(name="cycleStep")
    def cycle_step(self) -> Optional[pulumi.Input[int]]:
        """
        Interval time of scheduling, the minimum value: 1.
        """
        return pulumi.get(self, "cycle_step")

    @cycle_step.setter
    def cycle_step(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "cycle_step", value)

    @property
    @pulumi.getter(name="delayTime")
    def delay_time(self) -> Optional[pulumi.Input[int]]:
        """
        Execution time, unit is minutes, only available for day/week/month/year scheduling. For example, daily scheduling is executed once every day at 02:00, and the delayTime is 120 minutes.
        """
        return pulumi.get(self, "delay_time")

    @delay_time.setter
    def delay_time(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "delay_time", value)

    @property
    @pulumi.getter(name="endTime")
    def end_time(self) -> Optional[pulumi.Input[str]]:
        """
        Effective end time, the format is yyyy-MM-dd HH:mm:ss.
        """
        return pulumi.get(self, "end_time")

    @end_time.setter
    def end_time(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "end_time", value)

    @property
    @pulumi.getter
    def notes(self) -> Optional[pulumi.Input[str]]:
        """
        Description information.
        """
        return pulumi.get(self, "notes")

    @notes.setter
    def notes(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "notes", value)

    @property
    @pulumi.getter(name="projectId")
    def project_id(self) -> Optional[pulumi.Input[str]]:
        """
        Project ID.
        """
        return pulumi.get(self, "project_id")

    @project_id.setter
    def project_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "project_id", value)

    @property
    @pulumi.getter(name="startTime")
    def start_time(self) -> Optional[pulumi.Input[str]]:
        """
        Effective start time, the format is yyyy-MM-dd HH:mm:ss.
        """
        return pulumi.get(self, "start_time")

    @start_time.setter
    def start_time(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "start_time", value)

    @property
    @pulumi.getter(name="taskAction")
    def task_action(self) -> Optional[pulumi.Input[str]]:
        """
        Scheduling configuration: flexible period configuration, only available for hourly/weekly/monthly/yearly scheduling. If the hourly task is specified to run at 0:00, 3:00 and 4:00 every day, it is 0,3,4.
        """
        return pulumi.get(self, "task_action")

    @task_action.setter
    def task_action(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "task_action", value)

    @property
    @pulumi.getter(name="taskId")
    def task_id(self) -> Optional[pulumi.Input[str]]:
        """
        Task ID.
        """
        return pulumi.get(self, "task_id")

    @task_id.setter
    def task_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "task_id", value)

    @property
    @pulumi.getter(name="taskInfo")
    def task_info(self) -> Optional[pulumi.Input['IntegrationOfflineTaskTaskInfoArgs']]:
        """
        Task Information.
        """
        return pulumi.get(self, "task_info")

    @task_info.setter
    def task_info(self, value: Optional[pulumi.Input['IntegrationOfflineTaskTaskInfoArgs']]):
        pulumi.set(self, "task_info", value)

    @property
    @pulumi.getter(name="taskMode")
    def task_mode(self) -> Optional[pulumi.Input[str]]:
        """
        Task display mode, 0: canvas mode, 1: form mode.
        """
        return pulumi.get(self, "task_mode")

    @task_mode.setter
    def task_mode(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "task_mode", value)

    @property
    @pulumi.getter(name="taskName")
    def task_name(self) -> Optional[pulumi.Input[str]]:
        """
        Task name.
        """
        return pulumi.get(self, "task_name")

    @task_name.setter
    def task_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "task_name", value)


class IntegrationOfflineTask(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cycle_step: Optional[pulumi.Input[int]] = None,
                 delay_time: Optional[pulumi.Input[int]] = None,
                 end_time: Optional[pulumi.Input[str]] = None,
                 notes: Optional[pulumi.Input[str]] = None,
                 project_id: Optional[pulumi.Input[str]] = None,
                 start_time: Optional[pulumi.Input[str]] = None,
                 task_action: Optional[pulumi.Input[str]] = None,
                 task_info: Optional[pulumi.Input[pulumi.InputType['IntegrationOfflineTaskTaskInfoArgs']]] = None,
                 task_mode: Optional[pulumi.Input[str]] = None,
                 task_name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a resource to create a wedata integration_offline_task

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        example = tencentcloud.wedata.IntegrationOfflineTask("example",
            cycle_step=1,
            delay_time=0,
            end_time="2099-12-31 00:00:00",
            notes="terraform example demo.",
            project_id="1612982498218618880",
            start_time="2023-12-31 00:00:00",
            task_action="2",
            task_info=tencentcloud.wedata.IntegrationOfflineTaskTaskInfoArgs(
                configs=[
                    tencentcloud.wedata.IntegrationOfflineTaskTaskInfoConfigArgs(
                        name="Args",
                        value="args",
                    ),
                    tencentcloud.wedata.IntegrationOfflineTaskTaskInfoConfigArgs(
                        name="dirtyDataThreshold",
                        value="0",
                    ),
                    tencentcloud.wedata.IntegrationOfflineTaskTaskInfoConfigArgs(
                        name="concurrency",
                        value="1",
                    ),
                    tencentcloud.wedata.IntegrationOfflineTaskTaskInfoConfigArgs(
                        name="syncRateLimitUnit",
                        value="0",
                    ),
                ],
                executor_id="20230313175748567418",
                ext_configs=[tencentcloud.wedata.IntegrationOfflineTaskTaskInfoExtConfigArgs(
                    name="TaskAlarmRegularList",
                    value="73",
                )],
                incharge="demo",
                offline_task_add_entity=tencentcloud.wedata.IntegrationOfflineTaskTaskInfoOfflineTaskAddEntityArgs(
                    crontab_expression="0 0 1 * * ?",
                    cycle_type=3,
                    retriable=1,
                    retry_wait=5,
                    self_depend=1,
                    try_limit=5,
                ),
            ),
            task_mode="1",
            task_name="tf_example")
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        wedata integration_offline_task can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Wedata/integrationOfflineTask:IntegrationOfflineTask example 1612982498218618880#20231102200955095
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[int] cycle_step: Interval time of scheduling, the minimum value: 1.
        :param pulumi.Input[int] delay_time: Execution time, unit is minutes, only available for day/week/month/year scheduling. For example, daily scheduling is executed once every day at 02:00, and the delayTime is 120 minutes.
        :param pulumi.Input[str] end_time: Effective end time, the format is yyyy-MM-dd HH:mm:ss.
        :param pulumi.Input[str] notes: Description information.
        :param pulumi.Input[str] project_id: Project ID.
        :param pulumi.Input[str] start_time: Effective start time, the format is yyyy-MM-dd HH:mm:ss.
        :param pulumi.Input[str] task_action: Scheduling configuration: flexible period configuration, only available for hourly/weekly/monthly/yearly scheduling. If the hourly task is specified to run at 0:00, 3:00 and 4:00 every day, it is 0,3,4.
        :param pulumi.Input[pulumi.InputType['IntegrationOfflineTaskTaskInfoArgs']] task_info: Task Information.
        :param pulumi.Input[str] task_mode: Task display mode, 0: canvas mode, 1: form mode.
        :param pulumi.Input[str] task_name: Task name.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: IntegrationOfflineTaskArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a wedata integration_offline_task

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        example = tencentcloud.wedata.IntegrationOfflineTask("example",
            cycle_step=1,
            delay_time=0,
            end_time="2099-12-31 00:00:00",
            notes="terraform example demo.",
            project_id="1612982498218618880",
            start_time="2023-12-31 00:00:00",
            task_action="2",
            task_info=tencentcloud.wedata.IntegrationOfflineTaskTaskInfoArgs(
                configs=[
                    tencentcloud.wedata.IntegrationOfflineTaskTaskInfoConfigArgs(
                        name="Args",
                        value="args",
                    ),
                    tencentcloud.wedata.IntegrationOfflineTaskTaskInfoConfigArgs(
                        name="dirtyDataThreshold",
                        value="0",
                    ),
                    tencentcloud.wedata.IntegrationOfflineTaskTaskInfoConfigArgs(
                        name="concurrency",
                        value="1",
                    ),
                    tencentcloud.wedata.IntegrationOfflineTaskTaskInfoConfigArgs(
                        name="syncRateLimitUnit",
                        value="0",
                    ),
                ],
                executor_id="20230313175748567418",
                ext_configs=[tencentcloud.wedata.IntegrationOfflineTaskTaskInfoExtConfigArgs(
                    name="TaskAlarmRegularList",
                    value="73",
                )],
                incharge="demo",
                offline_task_add_entity=tencentcloud.wedata.IntegrationOfflineTaskTaskInfoOfflineTaskAddEntityArgs(
                    crontab_expression="0 0 1 * * ?",
                    cycle_type=3,
                    retriable=1,
                    retry_wait=5,
                    self_depend=1,
                    try_limit=5,
                ),
            ),
            task_mode="1",
            task_name="tf_example")
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        wedata integration_offline_task can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Wedata/integrationOfflineTask:IntegrationOfflineTask example 1612982498218618880#20231102200955095
        ```

        :param str resource_name: The name of the resource.
        :param IntegrationOfflineTaskArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(IntegrationOfflineTaskArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cycle_step: Optional[pulumi.Input[int]] = None,
                 delay_time: Optional[pulumi.Input[int]] = None,
                 end_time: Optional[pulumi.Input[str]] = None,
                 notes: Optional[pulumi.Input[str]] = None,
                 project_id: Optional[pulumi.Input[str]] = None,
                 start_time: Optional[pulumi.Input[str]] = None,
                 task_action: Optional[pulumi.Input[str]] = None,
                 task_info: Optional[pulumi.Input[pulumi.InputType['IntegrationOfflineTaskTaskInfoArgs']]] = None,
                 task_mode: Optional[pulumi.Input[str]] = None,
                 task_name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = IntegrationOfflineTaskArgs.__new__(IntegrationOfflineTaskArgs)

            if cycle_step is None and not opts.urn:
                raise TypeError("Missing required property 'cycle_step'")
            __props__.__dict__["cycle_step"] = cycle_step
            if delay_time is None and not opts.urn:
                raise TypeError("Missing required property 'delay_time'")
            __props__.__dict__["delay_time"] = delay_time
            if end_time is None and not opts.urn:
                raise TypeError("Missing required property 'end_time'")
            __props__.__dict__["end_time"] = end_time
            if notes is None and not opts.urn:
                raise TypeError("Missing required property 'notes'")
            __props__.__dict__["notes"] = notes
            if project_id is None and not opts.urn:
                raise TypeError("Missing required property 'project_id'")
            __props__.__dict__["project_id"] = project_id
            if start_time is None and not opts.urn:
                raise TypeError("Missing required property 'start_time'")
            __props__.__dict__["start_time"] = start_time
            if task_action is None and not opts.urn:
                raise TypeError("Missing required property 'task_action'")
            __props__.__dict__["task_action"] = task_action
            if task_info is None and not opts.urn:
                raise TypeError("Missing required property 'task_info'")
            __props__.__dict__["task_info"] = task_info
            if task_mode is None and not opts.urn:
                raise TypeError("Missing required property 'task_mode'")
            __props__.__dict__["task_mode"] = task_mode
            if task_name is None and not opts.urn:
                raise TypeError("Missing required property 'task_name'")
            __props__.__dict__["task_name"] = task_name
            __props__.__dict__["task_id"] = None
        super(IntegrationOfflineTask, __self__).__init__(
            'tencentcloud:Wedata/integrationOfflineTask:IntegrationOfflineTask',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            cycle_step: Optional[pulumi.Input[int]] = None,
            delay_time: Optional[pulumi.Input[int]] = None,
            end_time: Optional[pulumi.Input[str]] = None,
            notes: Optional[pulumi.Input[str]] = None,
            project_id: Optional[pulumi.Input[str]] = None,
            start_time: Optional[pulumi.Input[str]] = None,
            task_action: Optional[pulumi.Input[str]] = None,
            task_id: Optional[pulumi.Input[str]] = None,
            task_info: Optional[pulumi.Input[pulumi.InputType['IntegrationOfflineTaskTaskInfoArgs']]] = None,
            task_mode: Optional[pulumi.Input[str]] = None,
            task_name: Optional[pulumi.Input[str]] = None) -> 'IntegrationOfflineTask':
        """
        Get an existing IntegrationOfflineTask resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[int] cycle_step: Interval time of scheduling, the minimum value: 1.
        :param pulumi.Input[int] delay_time: Execution time, unit is minutes, only available for day/week/month/year scheduling. For example, daily scheduling is executed once every day at 02:00, and the delayTime is 120 minutes.
        :param pulumi.Input[str] end_time: Effective end time, the format is yyyy-MM-dd HH:mm:ss.
        :param pulumi.Input[str] notes: Description information.
        :param pulumi.Input[str] project_id: Project ID.
        :param pulumi.Input[str] start_time: Effective start time, the format is yyyy-MM-dd HH:mm:ss.
        :param pulumi.Input[str] task_action: Scheduling configuration: flexible period configuration, only available for hourly/weekly/monthly/yearly scheduling. If the hourly task is specified to run at 0:00, 3:00 and 4:00 every day, it is 0,3,4.
        :param pulumi.Input[str] task_id: Task ID.
        :param pulumi.Input[pulumi.InputType['IntegrationOfflineTaskTaskInfoArgs']] task_info: Task Information.
        :param pulumi.Input[str] task_mode: Task display mode, 0: canvas mode, 1: form mode.
        :param pulumi.Input[str] task_name: Task name.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _IntegrationOfflineTaskState.__new__(_IntegrationOfflineTaskState)

        __props__.__dict__["cycle_step"] = cycle_step
        __props__.__dict__["delay_time"] = delay_time
        __props__.__dict__["end_time"] = end_time
        __props__.__dict__["notes"] = notes
        __props__.__dict__["project_id"] = project_id
        __props__.__dict__["start_time"] = start_time
        __props__.__dict__["task_action"] = task_action
        __props__.__dict__["task_id"] = task_id
        __props__.__dict__["task_info"] = task_info
        __props__.__dict__["task_mode"] = task_mode
        __props__.__dict__["task_name"] = task_name
        return IntegrationOfflineTask(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="cycleStep")
    def cycle_step(self) -> pulumi.Output[int]:
        """
        Interval time of scheduling, the minimum value: 1.
        """
        return pulumi.get(self, "cycle_step")

    @property
    @pulumi.getter(name="delayTime")
    def delay_time(self) -> pulumi.Output[int]:
        """
        Execution time, unit is minutes, only available for day/week/month/year scheduling. For example, daily scheduling is executed once every day at 02:00, and the delayTime is 120 minutes.
        """
        return pulumi.get(self, "delay_time")

    @property
    @pulumi.getter(name="endTime")
    def end_time(self) -> pulumi.Output[str]:
        """
        Effective end time, the format is yyyy-MM-dd HH:mm:ss.
        """
        return pulumi.get(self, "end_time")

    @property
    @pulumi.getter
    def notes(self) -> pulumi.Output[str]:
        """
        Description information.
        """
        return pulumi.get(self, "notes")

    @property
    @pulumi.getter(name="projectId")
    def project_id(self) -> pulumi.Output[str]:
        """
        Project ID.
        """
        return pulumi.get(self, "project_id")

    @property
    @pulumi.getter(name="startTime")
    def start_time(self) -> pulumi.Output[str]:
        """
        Effective start time, the format is yyyy-MM-dd HH:mm:ss.
        """
        return pulumi.get(self, "start_time")

    @property
    @pulumi.getter(name="taskAction")
    def task_action(self) -> pulumi.Output[str]:
        """
        Scheduling configuration: flexible period configuration, only available for hourly/weekly/monthly/yearly scheduling. If the hourly task is specified to run at 0:00, 3:00 and 4:00 every day, it is 0,3,4.
        """
        return pulumi.get(self, "task_action")

    @property
    @pulumi.getter(name="taskId")
    def task_id(self) -> pulumi.Output[str]:
        """
        Task ID.
        """
        return pulumi.get(self, "task_id")

    @property
    @pulumi.getter(name="taskInfo")
    def task_info(self) -> pulumi.Output['outputs.IntegrationOfflineTaskTaskInfo']:
        """
        Task Information.
        """
        return pulumi.get(self, "task_info")

    @property
    @pulumi.getter(name="taskMode")
    def task_mode(self) -> pulumi.Output[str]:
        """
        Task display mode, 0: canvas mode, 1: form mode.
        """
        return pulumi.get(self, "task_mode")

    @property
    @pulumi.getter(name="taskName")
    def task_name(self) -> pulumi.Output[str]:
        """
        Task name.
        """
        return pulumi.get(self, "task_name")

