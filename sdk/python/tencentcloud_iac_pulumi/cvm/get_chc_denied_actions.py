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
    'GetChcDeniedActionsResult',
    'AwaitableGetChcDeniedActionsResult',
    'get_chc_denied_actions',
    'get_chc_denied_actions_output',
]

@pulumi.output_type
class GetChcDeniedActionsResult:
    """
    A collection of values returned by getChcDeniedActions.
    """
    def __init__(__self__, chc_host_denied_action_sets=None, chc_ids=None, id=None, result_output_file=None):
        if chc_host_denied_action_sets and not isinstance(chc_host_denied_action_sets, list):
            raise TypeError("Expected argument 'chc_host_denied_action_sets' to be a list")
        pulumi.set(__self__, "chc_host_denied_action_sets", chc_host_denied_action_sets)
        if chc_ids and not isinstance(chc_ids, list):
            raise TypeError("Expected argument 'chc_ids' to be a list")
        pulumi.set(__self__, "chc_ids", chc_ids)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)

    @property
    @pulumi.getter(name="chcHostDeniedActionSets")
    def chc_host_denied_action_sets(self) -> Sequence['outputs.GetChcDeniedActionsChcHostDeniedActionSetResult']:
        """
        Actions not allowed for the CHC instance.
        """
        return pulumi.get(self, "chc_host_denied_action_sets")

    @property
    @pulumi.getter(name="chcIds")
    def chc_ids(self) -> Sequence[str]:
        return pulumi.get(self, "chc_ids")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")


class AwaitableGetChcDeniedActionsResult(GetChcDeniedActionsResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetChcDeniedActionsResult(
            chc_host_denied_action_sets=self.chc_host_denied_action_sets,
            chc_ids=self.chc_ids,
            id=self.id,
            result_output_file=self.result_output_file)


def get_chc_denied_actions(chc_ids: Optional[Sequence[str]] = None,
                           result_output_file: Optional[str] = None,
                           opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetChcDeniedActionsResult:
    """
    Use this data source to query detailed information of cvm chc_denied_actions

    ## Example Usage

    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    chc_denied_actions = tencentcloud.Cvm.get_chc_denied_actions(chc_ids=["chc-xxxxx"])
    ```


    :param Sequence[str] chc_ids: CHC host IDs.
    :param str result_output_file: Used to save results.
    """
    __args__ = dict()
    __args__['chcIds'] = chc_ids
    __args__['resultOutputFile'] = result_output_file
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
        if opts.plugin_download_url is None:
            opts.plugin_download_url = _utilities.get_plugin_download_url()
    __ret__ = pulumi.runtime.invoke('tencentcloud:Cvm/getChcDeniedActions:getChcDeniedActions', __args__, opts=opts, typ=GetChcDeniedActionsResult).value

    return AwaitableGetChcDeniedActionsResult(
        chc_host_denied_action_sets=__ret__.chc_host_denied_action_sets,
        chc_ids=__ret__.chc_ids,
        id=__ret__.id,
        result_output_file=__ret__.result_output_file)


@_utilities.lift_output_func(get_chc_denied_actions)
def get_chc_denied_actions_output(chc_ids: Optional[pulumi.Input[Sequence[str]]] = None,
                                  result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                                  opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetChcDeniedActionsResult]:
    """
    Use this data source to query detailed information of cvm chc_denied_actions

    ## Example Usage

    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    chc_denied_actions = tencentcloud.Cvm.get_chc_denied_actions(chc_ids=["chc-xxxxx"])
    ```


    :param Sequence[str] chc_ids: CHC host IDs.
    :param str result_output_file: Used to save results.
    """
    ...