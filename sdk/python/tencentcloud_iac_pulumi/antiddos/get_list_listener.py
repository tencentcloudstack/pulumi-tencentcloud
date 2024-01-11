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
    'GetListListenerResult',
    'AwaitableGetListListenerResult',
    'get_list_listener',
    'get_list_listener_output',
]

@pulumi.output_type
class GetListListenerResult:
    """
    A collection of values returned by getListListener.
    """
    def __init__(__self__, id=None, layer4_listeners=None, layer7_listeners=None, result_output_file=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if layer4_listeners and not isinstance(layer4_listeners, list):
            raise TypeError("Expected argument 'layer4_listeners' to be a list")
        pulumi.set(__self__, "layer4_listeners", layer4_listeners)
        if layer7_listeners and not isinstance(layer7_listeners, list):
            raise TypeError("Expected argument 'layer7_listeners' to be a list")
        pulumi.set(__self__, "layer7_listeners", layer7_listeners)
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
    @pulumi.getter(name="layer4Listeners")
    def layer4_listeners(self) -> Sequence['outputs.GetListListenerLayer4ListenerResult']:
        """
        L4 listener list.
        """
        return pulumi.get(self, "layer4_listeners")

    @property
    @pulumi.getter(name="layer7Listeners")
    def layer7_listeners(self) -> Sequence['outputs.GetListListenerLayer7ListenerResult']:
        """
        Layer 7 forwarding listener list.
        """
        return pulumi.get(self, "layer7_listeners")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")


class AwaitableGetListListenerResult(GetListListenerResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetListListenerResult(
            id=self.id,
            layer4_listeners=self.layer4_listeners,
            layer7_listeners=self.layer7_listeners,
            result_output_file=self.result_output_file)


def get_list_listener(result_output_file: Optional[str] = None,
                      opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetListListenerResult:
    """
    Use this data source to query detailed information of antiddos list_listener

    ## Example Usage

    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    list_listener = tencentcloud.Antiddos.get_list_listener()
    ```


    :param str result_output_file: Used to save results.
    """
    __args__ = dict()
    __args__['resultOutputFile'] = result_output_file
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
        if opts.plugin_download_url is None:
            opts.plugin_download_url = _utilities.get_plugin_download_url()
    __ret__ = pulumi.runtime.invoke('tencentcloud:Antiddos/getListListener:getListListener', __args__, opts=opts, typ=GetListListenerResult).value

    return AwaitableGetListListenerResult(
        id=__ret__.id,
        layer4_listeners=__ret__.layer4_listeners,
        layer7_listeners=__ret__.layer7_listeners,
        result_output_file=__ret__.result_output_file)


@_utilities.lift_output_func(get_list_listener)
def get_list_listener_output(result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                             opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetListListenerResult]:
    """
    Use this data source to query detailed information of antiddos list_listener

    ## Example Usage

    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    list_listener = tencentcloud.Antiddos.get_list_listener()
    ```


    :param str result_output_file: Used to save results.
    """
    ...