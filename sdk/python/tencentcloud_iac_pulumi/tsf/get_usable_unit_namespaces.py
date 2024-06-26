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
    'GetUsableUnitNamespacesResult',
    'AwaitableGetUsableUnitNamespacesResult',
    'get_usable_unit_namespaces',
    'get_usable_unit_namespaces_output',
]

@pulumi.output_type
class GetUsableUnitNamespacesResult:
    """
    A collection of values returned by getUsableUnitNamespaces.
    """
    def __init__(__self__, id=None, result_output_file=None, results=None, search_word=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)
        if results and not isinstance(results, list):
            raise TypeError("Expected argument 'results' to be a list")
        pulumi.set(__self__, "results", results)
        if search_word and not isinstance(search_word, str):
            raise TypeError("Expected argument 'search_word' to be a str")
        pulumi.set(__self__, "search_word", search_word)

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

    @property
    @pulumi.getter
    def results(self) -> Sequence['outputs.GetUsableUnitNamespacesResultResult']:
        """
        namespace object list.
        """
        return pulumi.get(self, "results")

    @property
    @pulumi.getter(name="searchWord")
    def search_word(self) -> Optional[str]:
        return pulumi.get(self, "search_word")


class AwaitableGetUsableUnitNamespacesResult(GetUsableUnitNamespacesResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetUsableUnitNamespacesResult(
            id=self.id,
            result_output_file=self.result_output_file,
            results=self.results,
            search_word=self.search_word)


def get_usable_unit_namespaces(result_output_file: Optional[str] = None,
                               search_word: Optional[str] = None,
                               opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetUsableUnitNamespacesResult:
    """
    Use this data source to query detailed information of tsf usable_unit_namespaces

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    usable_unit_namespaces = tencentcloud.Tsf.get_usable_unit_namespaces(search_word="")
    ```
    <!--End PulumiCodeChooser -->


    :param str result_output_file: Used to save results.
    :param str search_word: search by namespace id or namespace Name.
    """
    __args__ = dict()
    __args__['resultOutputFile'] = result_output_file
    __args__['searchWord'] = search_word
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Tsf/getUsableUnitNamespaces:getUsableUnitNamespaces', __args__, opts=opts, typ=GetUsableUnitNamespacesResult).value

    return AwaitableGetUsableUnitNamespacesResult(
        id=pulumi.get(__ret__, 'id'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'),
        results=pulumi.get(__ret__, 'results'),
        search_word=pulumi.get(__ret__, 'search_word'))


@_utilities.lift_output_func(get_usable_unit_namespaces)
def get_usable_unit_namespaces_output(result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                                      search_word: Optional[pulumi.Input[Optional[str]]] = None,
                                      opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetUsableUnitNamespacesResult]:
    """
    Use this data source to query detailed information of tsf usable_unit_namespaces

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    usable_unit_namespaces = tencentcloud.Tsf.get_usable_unit_namespaces(search_word="")
    ```
    <!--End PulumiCodeChooser -->


    :param str result_output_file: Used to save results.
    :param str search_word: search by namespace id or namespace Name.
    """
    ...
