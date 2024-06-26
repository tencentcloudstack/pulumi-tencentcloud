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
    'GetRuleRealServersResult',
    'AwaitableGetRuleRealServersResult',
    'get_rule_real_servers',
    'get_rule_real_servers_output',
]

@pulumi.output_type
class GetRuleRealServersResult:
    """
    A collection of values returned by getRuleRealServers.
    """
    def __init__(__self__, bind_real_server_sets=None, id=None, real_server_sets=None, result_output_file=None, rule_id=None):
        if bind_real_server_sets and not isinstance(bind_real_server_sets, list):
            raise TypeError("Expected argument 'bind_real_server_sets' to be a list")
        pulumi.set(__self__, "bind_real_server_sets", bind_real_server_sets)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if real_server_sets and not isinstance(real_server_sets, list):
            raise TypeError("Expected argument 'real_server_sets' to be a list")
        pulumi.set(__self__, "real_server_sets", real_server_sets)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)
        if rule_id and not isinstance(rule_id, str):
            raise TypeError("Expected argument 'rule_id' to be a str")
        pulumi.set(__self__, "rule_id", rule_id)

    @property
    @pulumi.getter(name="bindRealServerSets")
    def bind_real_server_sets(self) -> Sequence['outputs.GetRuleRealServersBindRealServerSetResult']:
        """
        Bind Real Server info.
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
    @pulumi.getter(name="realServerSets")
    def real_server_sets(self) -> Sequence['outputs.GetRuleRealServersRealServerSetResult']:
        """
        Real Server Set.
        """
        return pulumi.get(self, "real_server_sets")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")

    @property
    @pulumi.getter(name="ruleId")
    def rule_id(self) -> str:
        return pulumi.get(self, "rule_id")


class AwaitableGetRuleRealServersResult(GetRuleRealServersResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetRuleRealServersResult(
            bind_real_server_sets=self.bind_real_server_sets,
            id=self.id,
            real_server_sets=self.real_server_sets,
            result_output_file=self.result_output_file,
            rule_id=self.rule_id)


def get_rule_real_servers(result_output_file: Optional[str] = None,
                          rule_id: Optional[str] = None,
                          opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetRuleRealServersResult:
    """
    Use this data source to query detailed information of gaap rule real servers

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    rule_real_servers = tencentcloud.Gaap.get_rule_real_servers(rule_id="rule-xxxxxx")
    ```
    <!--End PulumiCodeChooser -->


    :param str result_output_file: Used to save results.
    :param str rule_id: Rule Id.
    """
    __args__ = dict()
    __args__['resultOutputFile'] = result_output_file
    __args__['ruleId'] = rule_id
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Gaap/getRuleRealServers:getRuleRealServers', __args__, opts=opts, typ=GetRuleRealServersResult).value

    return AwaitableGetRuleRealServersResult(
        bind_real_server_sets=pulumi.get(__ret__, 'bind_real_server_sets'),
        id=pulumi.get(__ret__, 'id'),
        real_server_sets=pulumi.get(__ret__, 'real_server_sets'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'),
        rule_id=pulumi.get(__ret__, 'rule_id'))


@_utilities.lift_output_func(get_rule_real_servers)
def get_rule_real_servers_output(result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                                 rule_id: Optional[pulumi.Input[str]] = None,
                                 opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetRuleRealServersResult]:
    """
    Use this data source to query detailed information of gaap rule real servers

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    rule_real_servers = tencentcloud.Gaap.get_rule_real_servers(rule_id="rule-xxxxxx")
    ```
    <!--End PulumiCodeChooser -->


    :param str result_output_file: Used to save results.
    :param str rule_id: Rule Id.
    """
    ...
