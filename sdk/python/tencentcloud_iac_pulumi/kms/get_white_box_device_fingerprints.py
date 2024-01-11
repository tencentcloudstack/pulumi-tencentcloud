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
    'GetWhiteBoxDeviceFingerprintsResult',
    'AwaitableGetWhiteBoxDeviceFingerprintsResult',
    'get_white_box_device_fingerprints',
    'get_white_box_device_fingerprints_output',
]

@pulumi.output_type
class GetWhiteBoxDeviceFingerprintsResult:
    """
    A collection of values returned by getWhiteBoxDeviceFingerprints.
    """
    def __init__(__self__, id=None, key_id=None, lists=None, result_output_file=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if key_id and not isinstance(key_id, str):
            raise TypeError("Expected argument 'key_id' to be a str")
        pulumi.set(__self__, "key_id", key_id)
        if lists and not isinstance(lists, list):
            raise TypeError("Expected argument 'lists' to be a list")
        pulumi.set(__self__, "lists", lists)
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
    @pulumi.getter(name="keyId")
    def key_id(self) -> str:
        return pulumi.get(self, "key_id")

    @property
    @pulumi.getter
    def lists(self) -> Sequence['outputs.GetWhiteBoxDeviceFingerprintsListResult']:
        """
        Device fingerprint list.
        """
        return pulumi.get(self, "lists")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")


class AwaitableGetWhiteBoxDeviceFingerprintsResult(GetWhiteBoxDeviceFingerprintsResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetWhiteBoxDeviceFingerprintsResult(
            id=self.id,
            key_id=self.key_id,
            lists=self.lists,
            result_output_file=self.result_output_file)


def get_white_box_device_fingerprints(key_id: Optional[str] = None,
                                      result_output_file: Optional[str] = None,
                                      opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetWhiteBoxDeviceFingerprintsResult:
    """
    Use this data source to query detailed information of kms white_box_device_fingerprints

    ## Example Usage

    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    example = tencentcloud.Kms.get_white_box_device_fingerprints(key_id="244dab8c-6dad-11ea-80c6-5254006d0810")
    ```


    :param str key_id: Globally unique identifier for the white box key.
    :param str result_output_file: Used to save results.
    """
    __args__ = dict()
    __args__['keyId'] = key_id
    __args__['resultOutputFile'] = result_output_file
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
        if opts.plugin_download_url is None:
            opts.plugin_download_url = _utilities.get_plugin_download_url()
    __ret__ = pulumi.runtime.invoke('tencentcloud:Kms/getWhiteBoxDeviceFingerprints:getWhiteBoxDeviceFingerprints', __args__, opts=opts, typ=GetWhiteBoxDeviceFingerprintsResult).value

    return AwaitableGetWhiteBoxDeviceFingerprintsResult(
        id=__ret__.id,
        key_id=__ret__.key_id,
        lists=__ret__.lists,
        result_output_file=__ret__.result_output_file)


@_utilities.lift_output_func(get_white_box_device_fingerprints)
def get_white_box_device_fingerprints_output(key_id: Optional[pulumi.Input[str]] = None,
                                             result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                                             opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetWhiteBoxDeviceFingerprintsResult]:
    """
    Use this data source to query detailed information of kms white_box_device_fingerprints

    ## Example Usage

    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    example = tencentcloud.Kms.get_white_box_device_fingerprints(key_id="244dab8c-6dad-11ea-80c6-5254006d0810")
    ```


    :param str key_id: Globally unique identifier for the white box key.
    :param str result_output_file: Used to save results.
    """
    ...