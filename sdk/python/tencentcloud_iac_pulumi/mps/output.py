# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs
from ._inputs import *

__all__ = ['OutputArgs', 'Output']

@pulumi.input_type
class OutputArgs:
    def __init__(__self__, *,
                 flow_id: pulumi.Input[str],
                 output: pulumi.Input['OutputOutputArgs']):
        """
        The set of arguments for constructing a Output resource.
        :param pulumi.Input[str] flow_id: Flow ID.
        :param pulumi.Input['OutputOutputArgs'] output: Output configuration of the transport stream.
        """
        pulumi.set(__self__, "flow_id", flow_id)
        pulumi.set(__self__, "output", output)

    @property
    @pulumi.getter(name="flowId")
    def flow_id(self) -> pulumi.Input[str]:
        """
        Flow ID.
        """
        return pulumi.get(self, "flow_id")

    @flow_id.setter
    def flow_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "flow_id", value)

    @property
    @pulumi.getter
    def output(self) -> pulumi.Input['OutputOutputArgs']:
        """
        Output configuration of the transport stream.
        """
        return pulumi.get(self, "output")

    @output.setter
    def output(self, value: pulumi.Input['OutputOutputArgs']):
        pulumi.set(self, "output", value)


@pulumi.input_type
class _OutputState:
    def __init__(__self__, *,
                 flow_id: Optional[pulumi.Input[str]] = None,
                 output: Optional[pulumi.Input['OutputOutputArgs']] = None):
        """
        Input properties used for looking up and filtering Output resources.
        :param pulumi.Input[str] flow_id: Flow ID.
        :param pulumi.Input['OutputOutputArgs'] output: Output configuration of the transport stream.
        """
        if flow_id is not None:
            pulumi.set(__self__, "flow_id", flow_id)
        if output is not None:
            pulumi.set(__self__, "output", output)

    @property
    @pulumi.getter(name="flowId")
    def flow_id(self) -> Optional[pulumi.Input[str]]:
        """
        Flow ID.
        """
        return pulumi.get(self, "flow_id")

    @flow_id.setter
    def flow_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "flow_id", value)

    @property
    @pulumi.getter
    def output(self) -> Optional[pulumi.Input['OutputOutputArgs']]:
        """
        Output configuration of the transport stream.
        """
        return pulumi.get(self, "output")

    @output.setter
    def output(self, value: Optional[pulumi.Input['OutputOutputArgs']]):
        pulumi.set(self, "output", value)


class Output(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 flow_id: Optional[pulumi.Input[str]] = None,
                 output: Optional[pulumi.Input[pulumi.InputType['OutputOutputArgs']]] = None,
                 __props__=None):
        """
        Provides a resource to create a mps output

        ## Example Usage
        ### Create a output group with RTP

        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        output = tencentcloud.mps.Output("output",
            flow_id="your_flow_id",
            output=tencentcloud.mps.OutputOutputArgs(
                description="tf mps output group",
                output_name="your_output_name",
                output_region="ap-guangzhou",
                protocol="RTP",
                rtp_settings=tencentcloud.mps.OutputOutputRtpSettingsArgs(
                    destinations=[tencentcloud.mps.OutputOutputRtpSettingsDestinationArgs(
                        ip="203.205.141.84",
                        port=65535,
                    )],
                    fec="none",
                    idle_timeout=1000,
                ),
            ))
        ```

        ## Import

        mps output can be imported using the id, e.g.

        ```sh
         $ pulumi import tencentcloud:Mps/output:Output output flow_id#output_id
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] flow_id: Flow ID.
        :param pulumi.Input[pulumi.InputType['OutputOutputArgs']] output: Output configuration of the transport stream.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: OutputArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a mps output

        ## Example Usage
        ### Create a output group with RTP

        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        output = tencentcloud.mps.Output("output",
            flow_id="your_flow_id",
            output=tencentcloud.mps.OutputOutputArgs(
                description="tf mps output group",
                output_name="your_output_name",
                output_region="ap-guangzhou",
                protocol="RTP",
                rtp_settings=tencentcloud.mps.OutputOutputRtpSettingsArgs(
                    destinations=[tencentcloud.mps.OutputOutputRtpSettingsDestinationArgs(
                        ip="203.205.141.84",
                        port=65535,
                    )],
                    fec="none",
                    idle_timeout=1000,
                ),
            ))
        ```

        ## Import

        mps output can be imported using the id, e.g.

        ```sh
         $ pulumi import tencentcloud:Mps/output:Output output flow_id#output_id
        ```

        :param str resource_name: The name of the resource.
        :param OutputArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(OutputArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 flow_id: Optional[pulumi.Input[str]] = None,
                 output: Optional[pulumi.Input[pulumi.InputType['OutputOutputArgs']]] = None,
                 __props__=None):
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.plugin_download_url is None:
            opts.plugin_download_url = _utilities.get_plugin_download_url()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = OutputArgs.__new__(OutputArgs)

            if flow_id is None and not opts.urn:
                raise TypeError("Missing required property 'flow_id'")
            __props__.__dict__["flow_id"] = flow_id
            if output is None and not opts.urn:
                raise TypeError("Missing required property 'output'")
            __props__.__dict__["output"] = output
        super(Output, __self__).__init__(
            'tencentcloud:Mps/output:Output',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            flow_id: Optional[pulumi.Input[str]] = None,
            output: Optional[pulumi.Input[pulumi.InputType['OutputOutputArgs']]] = None) -> 'Output':
        """
        Get an existing Output resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] flow_id: Flow ID.
        :param pulumi.Input[pulumi.InputType['OutputOutputArgs']] output: Output configuration of the transport stream.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _OutputState.__new__(_OutputState)

        __props__.__dict__["flow_id"] = flow_id
        __props__.__dict__["output"] = output
        return Output(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="flowId")
    def flow_id(self) -> pulumi.Output[str]:
        """
        Flow ID.
        """
        return pulumi.get(self, "flow_id")

    @property
    @pulumi.getter
    def output(self) -> pulumi.Output['outputs.OutputOutput']:
        """
        Output configuration of the transport stream.
        """
        return pulumi.get(self, "output")
