# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = [
    'GetLogExportListResult',
    'AwaitableGetLogExportListResult',
    'get_log_export_list',
    'get_log_export_list_output',
]

@pulumi.output_type
class GetLogExportListResult:
    """
    A collection of values returned by getLogExportList.
    """
    def __init__(__self__, id=None, project_id=None, result=None, result_output_file=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if project_id and not isinstance(project_id, int):
            raise TypeError("Expected argument 'project_id' to be a int")
        pulumi.set(__self__, "project_id", project_id)
        if result and not isinstance(result, str):
            raise TypeError("Expected argument 'result' to be a str")
        pulumi.set(__self__, "result", result)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="projectId")
    def project_id(self) -> int:
        return pulumi.get(self, "project_id")

    @property
    @pulumi.getter
    def result(self) -> str:
        """
        Return result.
        """
        return pulumi.get(self, "result")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")


class AwaitableGetLogExportListResult(GetLogExportListResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetLogExportListResult(
            id=self.id,
            project_id=self.project_id,
            result=self.result,
            result_output_file=self.result_output_file)


def get_log_export_list(project_id: Optional[int] = None,
                        result_output_file: Optional[str] = None,
                        opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetLogExportListResult:
    """
    Use this data source to query detailed information of rum log_export_list

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    log_export_list = tencentcloud.Rum.get_log_export_list(project_id=1)
    ```
    <!--End PulumiCodeChooser -->


    :param int project_id: Project ID.
    :param str result_output_file: Used to save results.
    """
    __args__ = dict()
    __args__['projectId'] = project_id
    __args__['resultOutputFile'] = result_output_file
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Rum/getLogExportList:getLogExportList', __args__, opts=opts, typ=GetLogExportListResult).value

    return AwaitableGetLogExportListResult(
        id=pulumi.get(__ret__, 'id'),
        project_id=pulumi.get(__ret__, 'project_id'),
        result=pulumi.get(__ret__, 'result'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'))


@_utilities.lift_output_func(get_log_export_list)
def get_log_export_list_output(project_id: Optional[pulumi.Input[int]] = None,
                               result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                               opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetLogExportListResult]:
    """
    Use this data source to query detailed information of rum log_export_list

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    log_export_list = tencentcloud.Rum.get_log_export_list(project_id=1)
    ```
    <!--End PulumiCodeChooser -->


    :param int project_id: Project ID.
    :param str result_output_file: Used to save results.
    """
    ...
