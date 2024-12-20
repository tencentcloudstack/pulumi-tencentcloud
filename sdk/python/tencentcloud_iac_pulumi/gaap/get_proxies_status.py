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
    'GetProxiesStatusResult',
    'AwaitableGetProxiesStatusResult',
    'get_proxies_status',
    'get_proxies_status_output',
]

@pulumi.output_type
class GetProxiesStatusResult:
    """
    A collection of values returned by getProxiesStatus.
    """
    def __init__(__self__, id=None, instance_status_sets=None, proxy_ids=None, result_output_file=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if instance_status_sets and not isinstance(instance_status_sets, list):
            raise TypeError("Expected argument 'instance_status_sets' to be a list")
        pulumi.set(__self__, "instance_status_sets", instance_status_sets)
        if proxy_ids and not isinstance(proxy_ids, list):
            raise TypeError("Expected argument 'proxy_ids' to be a list")
        pulumi.set(__self__, "proxy_ids", proxy_ids)
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
    @pulumi.getter(name="instanceStatusSets")
    def instance_status_sets(self) -> Sequence['outputs.GetProxiesStatusInstanceStatusSetResult']:
        """
        Proxy status list.
        """
        return pulumi.get(self, "instance_status_sets")

    @property
    @pulumi.getter(name="proxyIds")
    def proxy_ids(self) -> Optional[Sequence[str]]:
        return pulumi.get(self, "proxy_ids")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")


class AwaitableGetProxiesStatusResult(GetProxiesStatusResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetProxiesStatusResult(
            id=self.id,
            instance_status_sets=self.instance_status_sets,
            proxy_ids=self.proxy_ids,
            result_output_file=self.result_output_file)


def get_proxies_status(proxy_ids: Optional[Sequence[str]] = None,
                       result_output_file: Optional[str] = None,
                       opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetProxiesStatusResult:
    """
    Use this data source to query detailed information of gaap proxies status

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    proxies_status = tencentcloud.Gaap.get_proxies_status(proxy_ids=["link-xxxxxx"])
    ```
    <!--End PulumiCodeChooser -->


    :param Sequence[str] proxy_ids: List of Proxy IDs.
    :param str result_output_file: Used to save results.
    """
    __args__ = dict()
    __args__['proxyIds'] = proxy_ids
    __args__['resultOutputFile'] = result_output_file
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Gaap/getProxiesStatus:getProxiesStatus', __args__, opts=opts, typ=GetProxiesStatusResult).value

    return AwaitableGetProxiesStatusResult(
        id=pulumi.get(__ret__, 'id'),
        instance_status_sets=pulumi.get(__ret__, 'instance_status_sets'),
        proxy_ids=pulumi.get(__ret__, 'proxy_ids'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'))


@_utilities.lift_output_func(get_proxies_status)
def get_proxies_status_output(proxy_ids: Optional[pulumi.Input[Optional[Sequence[str]]]] = None,
                              result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                              opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetProxiesStatusResult]:
    """
    Use this data source to query detailed information of gaap proxies status

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    proxies_status = tencentcloud.Gaap.get_proxies_status(proxy_ids=["link-xxxxxx"])
    ```
    <!--End PulumiCodeChooser -->


    :param Sequence[str] proxy_ids: List of Proxy IDs.
    :param str result_output_file: Used to save results.
    """
    ...
