# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs

__all__ = [
    'GetResourceRelatedJobResult',
    'AwaitableGetResourceRelatedJobResult',
    'get_resource_related_job',
    'get_resource_related_job_output',
]

@pulumi.output_type
class GetResourceRelatedJobResult:
    """
    A collection of values returned by getResourceRelatedJob.
    """
    def __init__(__self__, desc_by_job_config_create_time=None, id=None, ref_job_infos=None, resource_config_version=None, resource_id=None, result_output_file=None, work_space_id=None):
        if desc_by_job_config_create_time and not isinstance(desc_by_job_config_create_time, int):
            raise TypeError("Expected argument 'desc_by_job_config_create_time' to be a int")
        pulumi.set(__self__, "desc_by_job_config_create_time", desc_by_job_config_create_time)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if ref_job_infos and not isinstance(ref_job_infos, list):
            raise TypeError("Expected argument 'ref_job_infos' to be a list")
        pulumi.set(__self__, "ref_job_infos", ref_job_infos)
        if resource_config_version and not isinstance(resource_config_version, int):
            raise TypeError("Expected argument 'resource_config_version' to be a int")
        pulumi.set(__self__, "resource_config_version", resource_config_version)
        if resource_id and not isinstance(resource_id, str):
            raise TypeError("Expected argument 'resource_id' to be a str")
        pulumi.set(__self__, "resource_id", resource_id)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)
        if work_space_id and not isinstance(work_space_id, str):
            raise TypeError("Expected argument 'work_space_id' to be a str")
        pulumi.set(__self__, "work_space_id", work_space_id)

    @property
    @pulumi.getter(name="descByJobConfigCreateTime")
    def desc_by_job_config_create_time(self) -> Optional[int]:
        return pulumi.get(self, "desc_by_job_config_create_time")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="refJobInfos")
    def ref_job_infos(self) -> Sequence['outputs.GetResourceRelatedJobRefJobInfoResult']:
        """
        Associated job information.
        """
        return pulumi.get(self, "ref_job_infos")

    @property
    @pulumi.getter(name="resourceConfigVersion")
    def resource_config_version(self) -> Optional[int]:
        return pulumi.get(self, "resource_config_version")

    @property
    @pulumi.getter(name="resourceId")
    def resource_id(self) -> str:
        return pulumi.get(self, "resource_id")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")

    @property
    @pulumi.getter(name="workSpaceId")
    def work_space_id(self) -> Optional[str]:
        return pulumi.get(self, "work_space_id")


class AwaitableGetResourceRelatedJobResult(GetResourceRelatedJobResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetResourceRelatedJobResult(
            desc_by_job_config_create_time=self.desc_by_job_config_create_time,
            id=self.id,
            ref_job_infos=self.ref_job_infos,
            resource_config_version=self.resource_config_version,
            resource_id=self.resource_id,
            result_output_file=self.result_output_file,
            work_space_id=self.work_space_id)


def get_resource_related_job(desc_by_job_config_create_time: Optional[int] = None,
                             resource_config_version: Optional[int] = None,
                             resource_id: Optional[str] = None,
                             result_output_file: Optional[str] = None,
                             work_space_id: Optional[str] = None,
                             opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetResourceRelatedJobResult:
    """
    Use this data source to query detailed information of oceanus resource_related_job

    ## Example Usage

    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    example = tencentcloud.Oceanus.get_resource_related_job(desc_by_job_config_create_time=0,
        resource_config_version=1,
        resource_id="resource-8y9lzcuz",
        work_space_id="space-2idq8wbr")
    ```


    :param int desc_by_job_config_create_time: Default:0; 1:sort by job version creation time in descending order.
    :param int resource_config_version: Resource version number.
    :param str resource_id: Resource ID.
    :param str result_output_file: Used to save results.
    :param str work_space_id: Workspace SerialId.
    """
    __args__ = dict()
    __args__['descByJobConfigCreateTime'] = desc_by_job_config_create_time
    __args__['resourceConfigVersion'] = resource_config_version
    __args__['resourceId'] = resource_id
    __args__['resultOutputFile'] = result_output_file
    __args__['workSpaceId'] = work_space_id
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
        if opts.plugin_download_url is None:
            opts.plugin_download_url = _utilities.get_plugin_download_url()
    __ret__ = pulumi.runtime.invoke('tencentcloud:Oceanus/getResourceRelatedJob:getResourceRelatedJob', __args__, opts=opts, typ=GetResourceRelatedJobResult).value

    return AwaitableGetResourceRelatedJobResult(
        desc_by_job_config_create_time=__ret__.desc_by_job_config_create_time,
        id=__ret__.id,
        ref_job_infos=__ret__.ref_job_infos,
        resource_config_version=__ret__.resource_config_version,
        resource_id=__ret__.resource_id,
        result_output_file=__ret__.result_output_file,
        work_space_id=__ret__.work_space_id)


@_utilities.lift_output_func(get_resource_related_job)
def get_resource_related_job_output(desc_by_job_config_create_time: Optional[pulumi.Input[Optional[int]]] = None,
                                    resource_config_version: Optional[pulumi.Input[Optional[int]]] = None,
                                    resource_id: Optional[pulumi.Input[str]] = None,
                                    result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                                    work_space_id: Optional[pulumi.Input[Optional[str]]] = None,
                                    opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetResourceRelatedJobResult]:
    """
    Use this data source to query detailed information of oceanus resource_related_job

    ## Example Usage

    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    example = tencentcloud.Oceanus.get_resource_related_job(desc_by_job_config_create_time=0,
        resource_config_version=1,
        resource_id="resource-8y9lzcuz",
        work_space_id="space-2idq8wbr")
    ```


    :param int desc_by_job_config_create_time: Default:0; 1:sort by job version creation time in descending order.
    :param int resource_config_version: Resource version number.
    :param str resource_id: Resource ID.
    :param str result_output_file: Used to save results.
    :param str work_space_id: Workspace SerialId.
    """
    ...