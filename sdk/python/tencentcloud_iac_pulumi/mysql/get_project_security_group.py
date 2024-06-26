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
    'GetProjectSecurityGroupResult',
    'AwaitableGetProjectSecurityGroupResult',
    'get_project_security_group',
    'get_project_security_group_output',
]

@pulumi.output_type
class GetProjectSecurityGroupResult:
    """
    A collection of values returned by getProjectSecurityGroup.
    """
    def __init__(__self__, groups=None, id=None, project_id=None, result_output_file=None):
        if groups and not isinstance(groups, list):
            raise TypeError("Expected argument 'groups' to be a list")
        pulumi.set(__self__, "groups", groups)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if project_id and not isinstance(project_id, int):
            raise TypeError("Expected argument 'project_id' to be a int")
        pulumi.set(__self__, "project_id", project_id)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)

    @property
    @pulumi.getter
    def groups(self) -> Sequence['outputs.GetProjectSecurityGroupGroupResult']:
        """
        Security group details.
        """
        return pulumi.get(self, "groups")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="projectId")
    def project_id(self) -> Optional[int]:
        """
        project id.
        """
        return pulumi.get(self, "project_id")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")


class AwaitableGetProjectSecurityGroupResult(GetProjectSecurityGroupResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetProjectSecurityGroupResult(
            groups=self.groups,
            id=self.id,
            project_id=self.project_id,
            result_output_file=self.result_output_file)


def get_project_security_group(project_id: Optional[int] = None,
                               result_output_file: Optional[str] = None,
                               opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetProjectSecurityGroupResult:
    """
    Use this data source to query detailed information of mysql project_security_group

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    project_security_group = tencentcloud.Mysql.get_project_security_group(project_id=1250480)
    ```
    <!--End PulumiCodeChooser -->


    :param int project_id: project id.
    :param str result_output_file: Used to save results.
    """
    __args__ = dict()
    __args__['projectId'] = project_id
    __args__['resultOutputFile'] = result_output_file
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Mysql/getProjectSecurityGroup:getProjectSecurityGroup', __args__, opts=opts, typ=GetProjectSecurityGroupResult).value

    return AwaitableGetProjectSecurityGroupResult(
        groups=pulumi.get(__ret__, 'groups'),
        id=pulumi.get(__ret__, 'id'),
        project_id=pulumi.get(__ret__, 'project_id'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'))


@_utilities.lift_output_func(get_project_security_group)
def get_project_security_group_output(project_id: Optional[pulumi.Input[Optional[int]]] = None,
                                      result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                                      opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetProjectSecurityGroupResult]:
    """
    Use this data source to query detailed information of mysql project_security_group

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    project_security_group = tencentcloud.Mysql.get_project_security_group(project_id=1250480)
    ```
    <!--End PulumiCodeChooser -->


    :param int project_id: project id.
    :param str result_output_file: Used to save results.
    """
    ...
