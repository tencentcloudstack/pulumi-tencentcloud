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
    'GetTopSpaceTablesResult',
    'AwaitableGetTopSpaceTablesResult',
    'get_top_space_tables',
    'get_top_space_tables_output',
]

@pulumi.output_type
class GetTopSpaceTablesResult:
    """
    A collection of values returned by getTopSpaceTables.
    """
    def __init__(__self__, id=None, instance_id=None, limit=None, product=None, result_output_file=None, sort_by=None, timestamp=None, top_space_tables=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if instance_id and not isinstance(instance_id, str):
            raise TypeError("Expected argument 'instance_id' to be a str")
        pulumi.set(__self__, "instance_id", instance_id)
        if limit and not isinstance(limit, int):
            raise TypeError("Expected argument 'limit' to be a int")
        pulumi.set(__self__, "limit", limit)
        if product and not isinstance(product, str):
            raise TypeError("Expected argument 'product' to be a str")
        pulumi.set(__self__, "product", product)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)
        if sort_by and not isinstance(sort_by, str):
            raise TypeError("Expected argument 'sort_by' to be a str")
        pulumi.set(__self__, "sort_by", sort_by)
        if timestamp and not isinstance(timestamp, int):
            raise TypeError("Expected argument 'timestamp' to be a int")
        pulumi.set(__self__, "timestamp", timestamp)
        if top_space_tables and not isinstance(top_space_tables, list):
            raise TypeError("Expected argument 'top_space_tables' to be a list")
        pulumi.set(__self__, "top_space_tables", top_space_tables)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> str:
        return pulumi.get(self, "instance_id")

    @property
    @pulumi.getter
    def limit(self) -> Optional[int]:
        return pulumi.get(self, "limit")

    @property
    @pulumi.getter
    def product(self) -> Optional[str]:
        return pulumi.get(self, "product")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")

    @property
    @pulumi.getter(name="sortBy")
    def sort_by(self) -> Optional[str]:
        return pulumi.get(self, "sort_by")

    @property
    @pulumi.getter
    def timestamp(self) -> int:
        """
        The timestamp (in seconds) of collecting tablespace data.
        """
        return pulumi.get(self, "timestamp")

    @property
    @pulumi.getter(name="topSpaceTables")
    def top_space_tables(self) -> Sequence['outputs.GetTopSpaceTablesTopSpaceTableResult']:
        """
        The list of Top tablespace statistics returned.
        """
        return pulumi.get(self, "top_space_tables")


class AwaitableGetTopSpaceTablesResult(GetTopSpaceTablesResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetTopSpaceTablesResult(
            id=self.id,
            instance_id=self.instance_id,
            limit=self.limit,
            product=self.product,
            result_output_file=self.result_output_file,
            sort_by=self.sort_by,
            timestamp=self.timestamp,
            top_space_tables=self.top_space_tables)


def get_top_space_tables(instance_id: Optional[str] = None,
                         limit: Optional[int] = None,
                         product: Optional[str] = None,
                         result_output_file: Optional[str] = None,
                         sort_by: Optional[str] = None,
                         opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetTopSpaceTablesResult:
    """
    Use this data source to query detailed information of dbbrain top_space_tables

    ## Example Usage

    ### Sort by PhysicalFileSize

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    top_space_tables = tencentcloud.Dbbrain.get_top_space_tables(instance_id="%s",
        product="mysql",
        sort_by="PhysicalFileSize")
    ```
    <!--End PulumiCodeChooser -->

    ### Sort by TotalLength

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    top_space_tables = tencentcloud.Dbbrain.get_top_space_tables(instance_id="%s",
        product="mysql",
        sort_by="PhysicalFileSize")
    ```
    <!--End PulumiCodeChooser -->


    :param str instance_id: instance id.
    :param int limit: The number of Top tables returned, the maximum value is 100, and the default is 20.
    :param str product: Service product type, supported values include: mysql - cloud database MySQL, cynosdb - cloud database CynosDB for MySQL, the default is mysql.
    :param str result_output_file: Used to save results.
    :param str sort_by: The sorting field used to filter the Top table. The optional fields include DataLength, IndexLength, TotalLength, DataFree, FragRatio, TableRows, and PhysicalFileSize (only supported by ApsaraDB for MySQL instances). The default for ApsaraDB for MySQL instances is PhysicalFileSize, and the default for other product instances is TotalLength.
    """
    __args__ = dict()
    __args__['instanceId'] = instance_id
    __args__['limit'] = limit
    __args__['product'] = product
    __args__['resultOutputFile'] = result_output_file
    __args__['sortBy'] = sort_by
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Dbbrain/getTopSpaceTables:getTopSpaceTables', __args__, opts=opts, typ=GetTopSpaceTablesResult).value

    return AwaitableGetTopSpaceTablesResult(
        id=pulumi.get(__ret__, 'id'),
        instance_id=pulumi.get(__ret__, 'instance_id'),
        limit=pulumi.get(__ret__, 'limit'),
        product=pulumi.get(__ret__, 'product'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'),
        sort_by=pulumi.get(__ret__, 'sort_by'),
        timestamp=pulumi.get(__ret__, 'timestamp'),
        top_space_tables=pulumi.get(__ret__, 'top_space_tables'))


@_utilities.lift_output_func(get_top_space_tables)
def get_top_space_tables_output(instance_id: Optional[pulumi.Input[str]] = None,
                                limit: Optional[pulumi.Input[Optional[int]]] = None,
                                product: Optional[pulumi.Input[Optional[str]]] = None,
                                result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                                sort_by: Optional[pulumi.Input[Optional[str]]] = None,
                                opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetTopSpaceTablesResult]:
    """
    Use this data source to query detailed information of dbbrain top_space_tables

    ## Example Usage

    ### Sort by PhysicalFileSize

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    top_space_tables = tencentcloud.Dbbrain.get_top_space_tables(instance_id="%s",
        product="mysql",
        sort_by="PhysicalFileSize")
    ```
    <!--End PulumiCodeChooser -->

    ### Sort by TotalLength

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    top_space_tables = tencentcloud.Dbbrain.get_top_space_tables(instance_id="%s",
        product="mysql",
        sort_by="PhysicalFileSize")
    ```
    <!--End PulumiCodeChooser -->


    :param str instance_id: instance id.
    :param int limit: The number of Top tables returned, the maximum value is 100, and the default is 20.
    :param str product: Service product type, supported values include: mysql - cloud database MySQL, cynosdb - cloud database CynosDB for MySQL, the default is mysql.
    :param str result_output_file: Used to save results.
    :param str sort_by: The sorting field used to filter the Top table. The optional fields include DataLength, IndexLength, TotalLength, DataFree, FragRatio, TableRows, and PhysicalFileSize (only supported by ApsaraDB for MySQL instances). The default for ApsaraDB for MySQL instances is PhysicalFileSize, and the default for other product instances is TotalLength.
    """
    ...
