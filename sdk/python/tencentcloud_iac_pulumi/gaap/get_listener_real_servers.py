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
    'GetListenerRealServersResult',
    'AwaitableGetListenerRealServersResult',
    'get_listener_real_servers',
    'get_listener_real_servers_output',
]

@pulumi.output_type
class GetListenerRealServersResult:
    """
    A collection of values returned by getListenerRealServers.
    """
    def __init__(__self__, bind_real_server_sets=None, id=None, listener_id=None, real_server_sets=None, result_output_file=None):
        if bind_real_server_sets and not isinstance(bind_real_server_sets, list):
            raise TypeError("Expected argument 'bind_real_server_sets' to be a list")
        pulumi.set(__self__, "bind_real_server_sets", bind_real_server_sets)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if listener_id and not isinstance(listener_id, str):
            raise TypeError("Expected argument 'listener_id' to be a str")
        pulumi.set(__self__, "listener_id", listener_id)
        if real_server_sets and not isinstance(real_server_sets, list):
            raise TypeError("Expected argument 'real_server_sets' to be a list")
        pulumi.set(__self__, "real_server_sets", real_server_sets)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)

    @property
    @pulumi.getter(name="bindRealServerSets")
    def bind_real_server_sets(self) -> Sequence['outputs.GetListenerRealServersBindRealServerSetResult']:
        """
        Bound real server Information List.
        """
        return pulumi.get(self, "bind_real_server_sets")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="listenerId")
    def listener_id(self) -> str:
        return pulumi.get(self, "listener_id")

    @property
    @pulumi.getter(name="realServerSets")
    def real_server_sets(self) -> Sequence['outputs.GetListenerRealServersRealServerSetResult']:
        """
        Real Server Set.
        """
        return pulumi.get(self, "real_server_sets")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")


class AwaitableGetListenerRealServersResult(GetListenerRealServersResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetListenerRealServersResult(
            bind_real_server_sets=self.bind_real_server_sets,
            id=self.id,
            listener_id=self.listener_id,
            real_server_sets=self.real_server_sets,
            result_output_file=self.result_output_file)


def get_listener_real_servers(listener_id: Optional[str] = None,
                              result_output_file: Optional[str] = None,
                              opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetListenerRealServersResult:
    """
    Use this data source to query detailed information of gaap listener real servers

    ## Example Usage

    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    listener_real_servers = tencentcloud.Gaap.get_listener_real_servers(listener_id="listener-xxxxxx")
    ```


    :param str listener_id: listener ID.
    :param str result_output_file: Used to save results.
    """
    __args__ = dict()
    __args__['listenerId'] = listener_id
    __args__['resultOutputFile'] = result_output_file
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
        if opts.plugin_download_url is None:
            opts.plugin_download_url = _utilities.get_plugin_download_url()
    __ret__ = pulumi.runtime.invoke('tencentcloud:Gaap/getListenerRealServers:getListenerRealServers', __args__, opts=opts, typ=GetListenerRealServersResult).value

    return AwaitableGetListenerRealServersResult(
        bind_real_server_sets=__ret__.bind_real_server_sets,
        id=__ret__.id,
        listener_id=__ret__.listener_id,
        real_server_sets=__ret__.real_server_sets,
        result_output_file=__ret__.result_output_file)


@_utilities.lift_output_func(get_listener_real_servers)
def get_listener_real_servers_output(listener_id: Optional[pulumi.Input[str]] = None,
                                     result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                                     opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetListenerRealServersResult]:
    """
    Use this data source to query detailed information of gaap listener real servers

    ## Example Usage

    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    listener_real_servers = tencentcloud.Gaap.get_listener_real_servers(listener_id="listener-xxxxxx")
    ```


    :param str listener_id: listener ID.
    :param str result_output_file: Used to save results.
    """
    ...