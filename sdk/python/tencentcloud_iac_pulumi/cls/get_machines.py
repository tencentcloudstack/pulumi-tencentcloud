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

__all__ = [
    'GetMachinesResult',
    'AwaitableGetMachinesResult',
    'get_machines',
    'get_machines_output',
]

@pulumi.output_type
class GetMachinesResult:
    """
    A collection of values returned by getMachines.
    """
    def __init__(__self__, group_id=None, id=None, machines=None, result_output_file=None):
        if group_id and not isinstance(group_id, str):
            raise TypeError("Expected argument 'group_id' to be a str")
        pulumi.set(__self__, "group_id", group_id)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if machines and not isinstance(machines, list):
            raise TypeError("Expected argument 'machines' to be a list")
        pulumi.set(__self__, "machines", machines)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)

    @property
    @pulumi.getter(name="groupId")
    def group_id(self) -> str:
        return pulumi.get(self, "group_id")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def machines(self) -> Sequence['outputs.GetMachinesMachineResult']:
        """
        Info of Machines.
        """
        return pulumi.get(self, "machines")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")


class AwaitableGetMachinesResult(GetMachinesResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetMachinesResult(
            group_id=self.group_id,
            id=self.id,
            machines=self.machines,
            result_output_file=self.result_output_file)


def get_machines(group_id: Optional[str] = None,
                 result_output_file: Optional[str] = None,
                 opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetMachinesResult:
    """
    Use this data source to query detailed information of cls machines

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud
    import tencentcloud_iac_pulumi as tencentcloud

    group = tencentcloud.cls.MachineGroup("group",
        group_name="tf-describe-mg-test",
        service_logging=True,
        auto_update=True,
        update_end_time="19:05:00",
        update_start_time="17:05:00",
        machine_group_type=tencentcloud.cls.MachineGroupMachineGroupTypeArgs(
            type="ip",
            values=[
                "192.168.1.1",
                "192.168.1.2",
            ],
        ))
    machines = tencentcloud.Cls.get_machines_output(group_id=group.id)
    ```
    <!--End PulumiCodeChooser -->


    :param str group_id: Group id.
    :param str result_output_file: Used to save results.
    """
    __args__ = dict()
    __args__['groupId'] = group_id
    __args__['resultOutputFile'] = result_output_file
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Cls/getMachines:getMachines', __args__, opts=opts, typ=GetMachinesResult).value

    return AwaitableGetMachinesResult(
        group_id=pulumi.get(__ret__, 'group_id'),
        id=pulumi.get(__ret__, 'id'),
        machines=pulumi.get(__ret__, 'machines'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'))


@_utilities.lift_output_func(get_machines)
def get_machines_output(group_id: Optional[pulumi.Input[str]] = None,
                        result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                        opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetMachinesResult]:
    """
    Use this data source to query detailed information of cls machines

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud
    import tencentcloud_iac_pulumi as tencentcloud

    group = tencentcloud.cls.MachineGroup("group",
        group_name="tf-describe-mg-test",
        service_logging=True,
        auto_update=True,
        update_end_time="19:05:00",
        update_start_time="17:05:00",
        machine_group_type=tencentcloud.cls.MachineGroupMachineGroupTypeArgs(
            type="ip",
            values=[
                "192.168.1.1",
                "192.168.1.2",
            ],
        ))
    machines = tencentcloud.Cls.get_machines_output(group_id=group.id)
    ```
    <!--End PulumiCodeChooser -->


    :param str group_id: Group id.
    :param str result_output_file: Used to save results.
    """
    ...
