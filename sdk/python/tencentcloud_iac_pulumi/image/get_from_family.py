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
    'GetFromFamilyResult',
    'AwaitableGetFromFamilyResult',
    'get_from_family',
    'get_from_family_output',
]

@pulumi.output_type
class GetFromFamilyResult:
    """
    A collection of values returned by getFromFamily.
    """
    def __init__(__self__, id=None, image_family=None, images=None, result_output_file=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if image_family and not isinstance(image_family, str):
            raise TypeError("Expected argument 'image_family' to be a str")
        pulumi.set(__self__, "image_family", image_family)
        if images and not isinstance(images, list):
            raise TypeError("Expected argument 'images' to be a list")
        pulumi.set(__self__, "images", images)
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
    @pulumi.getter(name="imageFamily")
    def image_family(self) -> str:
        return pulumi.get(self, "image_family")

    @property
    @pulumi.getter
    def images(self) -> Sequence['outputs.GetFromFamilyImageResult']:
        """
        Information of Image.
        """
        return pulumi.get(self, "images")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")


class AwaitableGetFromFamilyResult(GetFromFamilyResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetFromFamilyResult(
            id=self.id,
            image_family=self.image_family,
            images=self.images,
            result_output_file=self.result_output_file)


def get_from_family(image_family: Optional[str] = None,
                    result_output_file: Optional[str] = None,
                    opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetFromFamilyResult:
    """
    Provides query image from family.

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    example = tencentcloud.Image.get_from_family(image_family="business-daily-update")
    ```
    <!--End PulumiCodeChooser -->


    :param str image_family: Image family name.
    :param str result_output_file: Used to save results.
    """
    __args__ = dict()
    __args__['imageFamily'] = image_family
    __args__['resultOutputFile'] = result_output_file
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Image/getFromFamily:getFromFamily', __args__, opts=opts, typ=GetFromFamilyResult).value

    return AwaitableGetFromFamilyResult(
        id=pulumi.get(__ret__, 'id'),
        image_family=pulumi.get(__ret__, 'image_family'),
        images=pulumi.get(__ret__, 'images'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'))


@_utilities.lift_output_func(get_from_family)
def get_from_family_output(image_family: Optional[pulumi.Input[str]] = None,
                           result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                           opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetFromFamilyResult]:
    """
    Provides query image from family.

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    example = tencentcloud.Image.get_from_family(image_family="business-daily-update")
    ```
    <!--End PulumiCodeChooser -->


    :param str image_family: Image family name.
    :param str result_output_file: Used to save results.
    """
    ...