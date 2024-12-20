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
    'GetUserDomainsResult',
    'AwaitableGetUserDomainsResult',
    'get_user_domains',
    'get_user_domains_output',
]

@pulumi.output_type
class GetUserDomainsResult:
    """
    A collection of values returned by getUserDomains.
    """
    def __init__(__self__, id=None, result_output_file=None, users_infos=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)
        if users_infos and not isinstance(users_infos, list):
            raise TypeError("Expected argument 'users_infos' to be a list")
        pulumi.set(__self__, "users_infos", users_infos)

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
    @pulumi.getter(name="usersInfos")
    def users_infos(self) -> Sequence['outputs.GetUserDomainsUsersInfoResult']:
        """
        Domain infos.
        """
        return pulumi.get(self, "users_infos")


class AwaitableGetUserDomainsResult(GetUserDomainsResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetUserDomainsResult(
            id=self.id,
            result_output_file=self.result_output_file,
            users_infos=self.users_infos)


def get_user_domains(result_output_file: Optional[str] = None,
                     opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetUserDomainsResult:
    """
    Use this data source to query detailed information of waf user_domains

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    user_domains = tencentcloud.Waf.get_user_domains()
    ```
    <!--End PulumiCodeChooser -->


    :param str result_output_file: Used to save results.
    """
    __args__ = dict()
    __args__['resultOutputFile'] = result_output_file
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Waf/getUserDomains:getUserDomains', __args__, opts=opts, typ=GetUserDomainsResult).value

    return AwaitableGetUserDomainsResult(
        id=pulumi.get(__ret__, 'id'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'),
        users_infos=pulumi.get(__ret__, 'users_infos'))


@_utilities.lift_output_func(get_user_domains)
def get_user_domains_output(result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                            opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetUserDomainsResult]:
    """
    Use this data source to query detailed information of waf user_domains

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    user_domains = tencentcloud.Waf.get_user_domains()
    ```
    <!--End PulumiCodeChooser -->


    :param str result_output_file: Used to save results.
    """
    ...
