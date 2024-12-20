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
    'GetDiagDbInstancesResult',
    'AwaitableGetDiagDbInstancesResult',
    'get_diag_db_instances',
    'get_diag_db_instances_output',
]

@pulumi.output_type
class GetDiagDbInstancesResult:
    """
    A collection of values returned by getDiagDbInstances.
    """
    def __init__(__self__, db_scan_status=None, id=None, instance_ids=None, instance_names=None, is_supported=None, items=None, product=None, regions=None, result_output_file=None):
        if db_scan_status and not isinstance(db_scan_status, int):
            raise TypeError("Expected argument 'db_scan_status' to be a int")
        pulumi.set(__self__, "db_scan_status", db_scan_status)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if instance_ids and not isinstance(instance_ids, list):
            raise TypeError("Expected argument 'instance_ids' to be a list")
        pulumi.set(__self__, "instance_ids", instance_ids)
        if instance_names and not isinstance(instance_names, list):
            raise TypeError("Expected argument 'instance_names' to be a list")
        pulumi.set(__self__, "instance_names", instance_names)
        if is_supported and not isinstance(is_supported, bool):
            raise TypeError("Expected argument 'is_supported' to be a bool")
        pulumi.set(__self__, "is_supported", is_supported)
        if items and not isinstance(items, list):
            raise TypeError("Expected argument 'items' to be a list")
        pulumi.set(__self__, "items", items)
        if product and not isinstance(product, str):
            raise TypeError("Expected argument 'product' to be a str")
        pulumi.set(__self__, "product", product)
        if regions and not isinstance(regions, list):
            raise TypeError("Expected argument 'regions' to be a list")
        pulumi.set(__self__, "regions", regions)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)

    @property
    @pulumi.getter(name="dbScanStatus")
    def db_scan_status(self) -> int:
        """
        all-instance inspection status. `0`: All-instance inspection is enabled; `1`: All-instance inspection is not enabled.
        """
        return pulumi.get(self, "db_scan_status")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="instanceIds")
    def instance_ids(self) -> Optional[Sequence[str]]:
        return pulumi.get(self, "instance_ids")

    @property
    @pulumi.getter(name="instanceNames")
    def instance_names(self) -> Optional[Sequence[str]]:
        return pulumi.get(self, "instance_names")

    @property
    @pulumi.getter(name="isSupported")
    def is_supported(self) -> bool:
        """
        whether it is an instance supported by DBbrain.
        """
        return pulumi.get(self, "is_supported")

    @property
    @pulumi.getter
    def items(self) -> Sequence['outputs.GetDiagDbInstancesItemResult']:
        """
        information about the instance.
        """
        return pulumi.get(self, "items")

    @property
    @pulumi.getter
    def product(self) -> str:
        """
        belongs to the product.
        """
        return pulumi.get(self, "product")

    @property
    @pulumi.getter
    def regions(self) -> Optional[Sequence[str]]:
        return pulumi.get(self, "regions")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")


class AwaitableGetDiagDbInstancesResult(GetDiagDbInstancesResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetDiagDbInstancesResult(
            db_scan_status=self.db_scan_status,
            id=self.id,
            instance_ids=self.instance_ids,
            instance_names=self.instance_names,
            is_supported=self.is_supported,
            items=self.items,
            product=self.product,
            regions=self.regions,
            result_output_file=self.result_output_file)


def get_diag_db_instances(instance_ids: Optional[Sequence[str]] = None,
                          instance_names: Optional[Sequence[str]] = None,
                          is_supported: Optional[bool] = None,
                          product: Optional[str] = None,
                          regions: Optional[Sequence[str]] = None,
                          result_output_file: Optional[str] = None,
                          opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetDiagDbInstancesResult:
    """
    Use this data source to query detailed information of dbbrain diag_db_instances

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    diag_db_instances = tencentcloud.Dbbrain.get_diag_db_instances(instance_names=["keep_preset_mysql"],
        is_supported=True,
        product="mysql")
    ```
    <!--End PulumiCodeChooser -->


    :param Sequence[str] instance_ids: query based on the instance ID condition.
    :param Sequence[str] instance_names: query based on the instance name condition.
    :param bool is_supported: whether it is an instance supported by DBbrain, always pass `true`.
    :param str product: service product type, supported values include: `mysql` - cloud database MySQL, `cynosdb` - cloud database TDSQL-C for MySQL, the default is `mysql`.
    :param Sequence[str] regions: query based on geographical conditions.
    :param str result_output_file: Used to save results.
    """
    __args__ = dict()
    __args__['instanceIds'] = instance_ids
    __args__['instanceNames'] = instance_names
    __args__['isSupported'] = is_supported
    __args__['product'] = product
    __args__['regions'] = regions
    __args__['resultOutputFile'] = result_output_file
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Dbbrain/getDiagDbInstances:getDiagDbInstances', __args__, opts=opts, typ=GetDiagDbInstancesResult).value

    return AwaitableGetDiagDbInstancesResult(
        db_scan_status=pulumi.get(__ret__, 'db_scan_status'),
        id=pulumi.get(__ret__, 'id'),
        instance_ids=pulumi.get(__ret__, 'instance_ids'),
        instance_names=pulumi.get(__ret__, 'instance_names'),
        is_supported=pulumi.get(__ret__, 'is_supported'),
        items=pulumi.get(__ret__, 'items'),
        product=pulumi.get(__ret__, 'product'),
        regions=pulumi.get(__ret__, 'regions'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'))


@_utilities.lift_output_func(get_diag_db_instances)
def get_diag_db_instances_output(instance_ids: Optional[pulumi.Input[Optional[Sequence[str]]]] = None,
                                 instance_names: Optional[pulumi.Input[Optional[Sequence[str]]]] = None,
                                 is_supported: Optional[pulumi.Input[bool]] = None,
                                 product: Optional[pulumi.Input[str]] = None,
                                 regions: Optional[pulumi.Input[Optional[Sequence[str]]]] = None,
                                 result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                                 opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetDiagDbInstancesResult]:
    """
    Use this data source to query detailed information of dbbrain diag_db_instances

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    diag_db_instances = tencentcloud.Dbbrain.get_diag_db_instances(instance_names=["keep_preset_mysql"],
        is_supported=True,
        product="mysql")
    ```
    <!--End PulumiCodeChooser -->


    :param Sequence[str] instance_ids: query based on the instance ID condition.
    :param Sequence[str] instance_names: query based on the instance name condition.
    :param bool is_supported: whether it is an instance supported by DBbrain, always pass `true`.
    :param str product: service product type, supported values include: `mysql` - cloud database MySQL, `cynosdb` - cloud database TDSQL-C for MySQL, the default is `mysql`.
    :param Sequence[str] regions: query based on geographical conditions.
    :param str result_output_file: Used to save results.
    """
    ...
