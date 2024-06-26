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
    'GetInstanceResult',
    'AwaitableGetInstanceResult',
    'get_instance',
    'get_instance_output',
]

@pulumi.output_type
class GetInstanceResult:
    """
    A collection of values returned by getInstance.
    """
    def __init__(__self__, id=None, image_id=None, image_name_regex=None, image_types=None, images=None, instance_type=None, os_name=None, result_output_file=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if image_id and not isinstance(image_id, str):
            raise TypeError("Expected argument 'image_id' to be a str")
        pulumi.set(__self__, "image_id", image_id)
        if image_name_regex and not isinstance(image_name_regex, str):
            raise TypeError("Expected argument 'image_name_regex' to be a str")
        pulumi.set(__self__, "image_name_regex", image_name_regex)
        if image_types and not isinstance(image_types, list):
            raise TypeError("Expected argument 'image_types' to be a list")
        pulumi.set(__self__, "image_types", image_types)
        if images and not isinstance(images, list):
            raise TypeError("Expected argument 'images' to be a list")
        pulumi.set(__self__, "images", images)
        if instance_type and not isinstance(instance_type, str):
            raise TypeError("Expected argument 'instance_type' to be a str")
        pulumi.set(__self__, "instance_type", instance_type)
        if os_name and not isinstance(os_name, str):
            raise TypeError("Expected argument 'os_name' to be a str")
        pulumi.set(__self__, "os_name", os_name)
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
    @pulumi.getter(name="imageId")
    def image_id(self) -> Optional[str]:
        """
        ID of the image.
        """
        return pulumi.get(self, "image_id")

    @property
    @pulumi.getter(name="imageNameRegex")
    def image_name_regex(self) -> Optional[str]:
        return pulumi.get(self, "image_name_regex")

    @property
    @pulumi.getter(name="imageTypes")
    def image_types(self) -> Optional[Sequence[str]]:
        """
        Type of the image.
        """
        return pulumi.get(self, "image_types")

    @property
    @pulumi.getter
    def images(self) -> Sequence['outputs.GetInstanceImageResult']:
        """
        An information list of image. Each element contains the following attributes:
        """
        return pulumi.get(self, "images")

    @property
    @pulumi.getter(name="instanceType")
    def instance_type(self) -> Optional[str]:
        return pulumi.get(self, "instance_type")

    @property
    @pulumi.getter(name="osName")
    def os_name(self) -> Optional[str]:
        """
        OS name of the image.
        """
        return pulumi.get(self, "os_name")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")


class AwaitableGetInstanceResult(GetInstanceResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetInstanceResult(
            id=self.id,
            image_id=self.image_id,
            image_name_regex=self.image_name_regex,
            image_types=self.image_types,
            images=self.images,
            instance_type=self.instance_type,
            os_name=self.os_name,
            result_output_file=self.result_output_file)


def get_instance(image_id: Optional[str] = None,
                 image_name_regex: Optional[str] = None,
                 image_types: Optional[Sequence[str]] = None,
                 instance_type: Optional[str] = None,
                 os_name: Optional[str] = None,
                 result_output_file: Optional[str] = None,
                 opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetInstanceResult:
    """
    Use this data source to query images.

    ## Example Usage

    ### Query all images

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    example = tencentcloud.Images.get_instance()
    ```
    <!--End PulumiCodeChooser -->

    ### Query images by image ID

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    example = tencentcloud.Images.get_instance(image_id="img-9qrfy1xt")
    ```
    <!--End PulumiCodeChooser -->

    ### Query images by os name

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    example = tencentcloud.Images.get_instance(os_name="TencentOS Server 3.2 (Final)")
    ```
    <!--End PulumiCodeChooser -->

    ### Query images by image name regex

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    example = tencentcloud.Images.get_instance(image_name_regex="^TencentOS")
    ```
    <!--End PulumiCodeChooser -->

    ### Query images by image type

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    example = tencentcloud.Images.get_instance(image_types=["PUBLIC_IMAGE"])
    ```
    <!--End PulumiCodeChooser -->

    ### Query images by instance type

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    example = tencentcloud.Images.get_instance(instance_type="S1.SMALL1")
    ```
    <!--End PulumiCodeChooser -->


    :param str image_id: ID of the image to be queried.
    :param str image_name_regex: A regex string to apply to the image list returned by TencentCloud, conflict with 'os_name'. **NOTE**: it is not wildcard, should look like `image_name_regex = "^CentOS\\s+6\\.8\\s+64\\w*"`.
    :param Sequence[str] image_types: A list of the image type to be queried. Valid values: 'PUBLIC_IMAGE', 'PRIVATE_IMAGE', 'SHARED_IMAGE', 'MARKET_IMAGE'.
    :param str instance_type: Instance type, such as `S1.SMALL1`.
    :param str os_name: A string to apply with fuzzy match to the os_name attribute on the image list returned by TencentCloud, conflict with 'image_name_regex'.
    :param str result_output_file: Used to save results.
    """
    __args__ = dict()
    __args__['imageId'] = image_id
    __args__['imageNameRegex'] = image_name_regex
    __args__['imageTypes'] = image_types
    __args__['instanceType'] = instance_type
    __args__['osName'] = os_name
    __args__['resultOutputFile'] = result_output_file
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Images/getInstance:getInstance', __args__, opts=opts, typ=GetInstanceResult).value

    return AwaitableGetInstanceResult(
        id=pulumi.get(__ret__, 'id'),
        image_id=pulumi.get(__ret__, 'image_id'),
        image_name_regex=pulumi.get(__ret__, 'image_name_regex'),
        image_types=pulumi.get(__ret__, 'image_types'),
        images=pulumi.get(__ret__, 'images'),
        instance_type=pulumi.get(__ret__, 'instance_type'),
        os_name=pulumi.get(__ret__, 'os_name'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'))


@_utilities.lift_output_func(get_instance)
def get_instance_output(image_id: Optional[pulumi.Input[Optional[str]]] = None,
                        image_name_regex: Optional[pulumi.Input[Optional[str]]] = None,
                        image_types: Optional[pulumi.Input[Optional[Sequence[str]]]] = None,
                        instance_type: Optional[pulumi.Input[Optional[str]]] = None,
                        os_name: Optional[pulumi.Input[Optional[str]]] = None,
                        result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                        opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetInstanceResult]:
    """
    Use this data source to query images.

    ## Example Usage

    ### Query all images

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    example = tencentcloud.Images.get_instance()
    ```
    <!--End PulumiCodeChooser -->

    ### Query images by image ID

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    example = tencentcloud.Images.get_instance(image_id="img-9qrfy1xt")
    ```
    <!--End PulumiCodeChooser -->

    ### Query images by os name

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    example = tencentcloud.Images.get_instance(os_name="TencentOS Server 3.2 (Final)")
    ```
    <!--End PulumiCodeChooser -->

    ### Query images by image name regex

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    example = tencentcloud.Images.get_instance(image_name_regex="^TencentOS")
    ```
    <!--End PulumiCodeChooser -->

    ### Query images by image type

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    example = tencentcloud.Images.get_instance(image_types=["PUBLIC_IMAGE"])
    ```
    <!--End PulumiCodeChooser -->

    ### Query images by instance type

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    example = tencentcloud.Images.get_instance(instance_type="S1.SMALL1")
    ```
    <!--End PulumiCodeChooser -->


    :param str image_id: ID of the image to be queried.
    :param str image_name_regex: A regex string to apply to the image list returned by TencentCloud, conflict with 'os_name'. **NOTE**: it is not wildcard, should look like `image_name_regex = "^CentOS\\s+6\\.8\\s+64\\w*"`.
    :param Sequence[str] image_types: A list of the image type to be queried. Valid values: 'PUBLIC_IMAGE', 'PRIVATE_IMAGE', 'SHARED_IMAGE', 'MARKET_IMAGE'.
    :param str instance_type: Instance type, such as `S1.SMALL1`.
    :param str os_name: A string to apply with fuzzy match to the os_name attribute on the image list returned by TencentCloud, conflict with 'image_name_regex'.
    :param str result_output_file: Used to save results.
    """
    ...
