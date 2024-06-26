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
    'GetPolicyGrantingServiceAccessResult',
    'AwaitableGetPolicyGrantingServiceAccessResult',
    'get_policy_granting_service_access',
    'get_policy_granting_service_access_output',
]

@pulumi.output_type
class GetPolicyGrantingServiceAccessResult:
    """
    A collection of values returned by getPolicyGrantingServiceAccess.
    """
    def __init__(__self__, group_id=None, id=None, lists=None, result_output_file=None, role_id=None, service_type=None, target_uin=None):
        if group_id and not isinstance(group_id, int):
            raise TypeError("Expected argument 'group_id' to be a int")
        pulumi.set(__self__, "group_id", group_id)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if lists and not isinstance(lists, list):
            raise TypeError("Expected argument 'lists' to be a list")
        pulumi.set(__self__, "lists", lists)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)
        if role_id and not isinstance(role_id, int):
            raise TypeError("Expected argument 'role_id' to be a int")
        pulumi.set(__self__, "role_id", role_id)
        if service_type and not isinstance(service_type, str):
            raise TypeError("Expected argument 'service_type' to be a str")
        pulumi.set(__self__, "service_type", service_type)
        if target_uin and not isinstance(target_uin, int):
            raise TypeError("Expected argument 'target_uin' to be a int")
        pulumi.set(__self__, "target_uin", target_uin)

    @property
    @pulumi.getter(name="groupId")
    def group_id(self) -> Optional[int]:
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
    def lists(self) -> Sequence['outputs.GetPolicyGrantingServiceAccessListResult']:
        """
        List.
        """
        return pulumi.get(self, "lists")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")

    @property
    @pulumi.getter(name="roleId")
    def role_id(self) -> Optional[int]:
        return pulumi.get(self, "role_id")

    @property
    @pulumi.getter(name="serviceType")
    def service_type(self) -> Optional[str]:
        """
        Service type.
        """
        return pulumi.get(self, "service_type")

    @property
    @pulumi.getter(name="targetUin")
    def target_uin(self) -> Optional[int]:
        return pulumi.get(self, "target_uin")


class AwaitableGetPolicyGrantingServiceAccessResult(GetPolicyGrantingServiceAccessResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetPolicyGrantingServiceAccessResult(
            group_id=self.group_id,
            id=self.id,
            lists=self.lists,
            result_output_file=self.result_output_file,
            role_id=self.role_id,
            service_type=self.service_type,
            target_uin=self.target_uin)


def get_policy_granting_service_access(group_id: Optional[int] = None,
                                       result_output_file: Optional[str] = None,
                                       role_id: Optional[int] = None,
                                       service_type: Optional[str] = None,
                                       target_uin: Optional[int] = None,
                                       opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetPolicyGrantingServiceAccessResult:
    """
    Use this data source to query detailed information of cam policy_granting_service_access

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    policy_granting_service_access = tencentcloud.Cam.get_policy_granting_service_access(role_id=4611686018436804608,
        service_type="cam")
    ```
    <!--End PulumiCodeChooser -->


    :param int group_id: Group Id, one of the three (TargetUin, RoleId, GroupId) must be passed.
    :param str result_output_file: Used to save results.
    :param int role_id: Role Id, one of the three (TargetUin, RoleId, GroupId) must be passed.
    :param str service_type: Service type, this field needs to be passed when viewing the details of the service authorization interface.
    :param int target_uin: Sub-account uin, one of the three (TargetUin, RoleId, GroupId) must be passed.
    """
    __args__ = dict()
    __args__['groupId'] = group_id
    __args__['resultOutputFile'] = result_output_file
    __args__['roleId'] = role_id
    __args__['serviceType'] = service_type
    __args__['targetUin'] = target_uin
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Cam/getPolicyGrantingServiceAccess:getPolicyGrantingServiceAccess', __args__, opts=opts, typ=GetPolicyGrantingServiceAccessResult).value

    return AwaitableGetPolicyGrantingServiceAccessResult(
        group_id=pulumi.get(__ret__, 'group_id'),
        id=pulumi.get(__ret__, 'id'),
        lists=pulumi.get(__ret__, 'lists'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'),
        role_id=pulumi.get(__ret__, 'role_id'),
        service_type=pulumi.get(__ret__, 'service_type'),
        target_uin=pulumi.get(__ret__, 'target_uin'))


@_utilities.lift_output_func(get_policy_granting_service_access)
def get_policy_granting_service_access_output(group_id: Optional[pulumi.Input[Optional[int]]] = None,
                                              result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                                              role_id: Optional[pulumi.Input[Optional[int]]] = None,
                                              service_type: Optional[pulumi.Input[Optional[str]]] = None,
                                              target_uin: Optional[pulumi.Input[Optional[int]]] = None,
                                              opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetPolicyGrantingServiceAccessResult]:
    """
    Use this data source to query detailed information of cam policy_granting_service_access

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    policy_granting_service_access = tencentcloud.Cam.get_policy_granting_service_access(role_id=4611686018436804608,
        service_type="cam")
    ```
    <!--End PulumiCodeChooser -->


    :param int group_id: Group Id, one of the three (TargetUin, RoleId, GroupId) must be passed.
    :param str result_output_file: Used to save results.
    :param int role_id: Role Id, one of the three (TargetUin, RoleId, GroupId) must be passed.
    :param str service_type: Service type, this field needs to be passed when viewing the details of the service authorization interface.
    :param int target_uin: Sub-account uin, one of the three (TargetUin, RoleId, GroupId) must be passed.
    """
    ...
