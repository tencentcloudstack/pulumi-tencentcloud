# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['ExportArgs', 'Export']

@pulumi.input_type
class ExportArgs:
    def __init__(__self__, *,
                 from_: pulumi.Input[int],
                 log_count: pulumi.Input[int],
                 query: pulumi.Input[str],
                 to: pulumi.Input[int],
                 topic_id: pulumi.Input[str],
                 format: Optional[pulumi.Input[str]] = None,
                 order: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a Export resource.
        :param pulumi.Input[int] from_: export start time.
        :param pulumi.Input[int] log_count: export amount of log.
        :param pulumi.Input[str] query: export query rules.
        :param pulumi.Input[int] to: export end time.
        :param pulumi.Input[str] topic_id: topic id.
        :param pulumi.Input[str] format: log export format.
        :param pulumi.Input[str] order: log export time sorting. desc or asc.
        """
        pulumi.set(__self__, "from_", from_)
        pulumi.set(__self__, "log_count", log_count)
        pulumi.set(__self__, "query", query)
        pulumi.set(__self__, "to", to)
        pulumi.set(__self__, "topic_id", topic_id)
        if format is not None:
            pulumi.set(__self__, "format", format)
        if order is not None:
            pulumi.set(__self__, "order", order)

    @property
    @pulumi.getter(name="from")
    def from_(self) -> pulumi.Input[int]:
        """
        export start time.
        """
        return pulumi.get(self, "from_")

    @from_.setter
    def from_(self, value: pulumi.Input[int]):
        pulumi.set(self, "from_", value)

    @property
    @pulumi.getter(name="logCount")
    def log_count(self) -> pulumi.Input[int]:
        """
        export amount of log.
        """
        return pulumi.get(self, "log_count")

    @log_count.setter
    def log_count(self, value: pulumi.Input[int]):
        pulumi.set(self, "log_count", value)

    @property
    @pulumi.getter
    def query(self) -> pulumi.Input[str]:
        """
        export query rules.
        """
        return pulumi.get(self, "query")

    @query.setter
    def query(self, value: pulumi.Input[str]):
        pulumi.set(self, "query", value)

    @property
    @pulumi.getter
    def to(self) -> pulumi.Input[int]:
        """
        export end time.
        """
        return pulumi.get(self, "to")

    @to.setter
    def to(self, value: pulumi.Input[int]):
        pulumi.set(self, "to", value)

    @property
    @pulumi.getter(name="topicId")
    def topic_id(self) -> pulumi.Input[str]:
        """
        topic id.
        """
        return pulumi.get(self, "topic_id")

    @topic_id.setter
    def topic_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "topic_id", value)

    @property
    @pulumi.getter
    def format(self) -> Optional[pulumi.Input[str]]:
        """
        log export format.
        """
        return pulumi.get(self, "format")

    @format.setter
    def format(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "format", value)

    @property
    @pulumi.getter
    def order(self) -> Optional[pulumi.Input[str]]:
        """
        log export time sorting. desc or asc.
        """
        return pulumi.get(self, "order")

    @order.setter
    def order(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "order", value)


@pulumi.input_type
class _ExportState:
    def __init__(__self__, *,
                 format: Optional[pulumi.Input[str]] = None,
                 from_: Optional[pulumi.Input[int]] = None,
                 log_count: Optional[pulumi.Input[int]] = None,
                 order: Optional[pulumi.Input[str]] = None,
                 query: Optional[pulumi.Input[str]] = None,
                 to: Optional[pulumi.Input[int]] = None,
                 topic_id: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering Export resources.
        :param pulumi.Input[str] format: log export format.
        :param pulumi.Input[int] from_: export start time.
        :param pulumi.Input[int] log_count: export amount of log.
        :param pulumi.Input[str] order: log export time sorting. desc or asc.
        :param pulumi.Input[str] query: export query rules.
        :param pulumi.Input[int] to: export end time.
        :param pulumi.Input[str] topic_id: topic id.
        """
        if format is not None:
            pulumi.set(__self__, "format", format)
        if from_ is not None:
            pulumi.set(__self__, "from_", from_)
        if log_count is not None:
            pulumi.set(__self__, "log_count", log_count)
        if order is not None:
            pulumi.set(__self__, "order", order)
        if query is not None:
            pulumi.set(__self__, "query", query)
        if to is not None:
            pulumi.set(__self__, "to", to)
        if topic_id is not None:
            pulumi.set(__self__, "topic_id", topic_id)

    @property
    @pulumi.getter
    def format(self) -> Optional[pulumi.Input[str]]:
        """
        log export format.
        """
        return pulumi.get(self, "format")

    @format.setter
    def format(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "format", value)

    @property
    @pulumi.getter(name="from")
    def from_(self) -> Optional[pulumi.Input[int]]:
        """
        export start time.
        """
        return pulumi.get(self, "from_")

    @from_.setter
    def from_(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "from_", value)

    @property
    @pulumi.getter(name="logCount")
    def log_count(self) -> Optional[pulumi.Input[int]]:
        """
        export amount of log.
        """
        return pulumi.get(self, "log_count")

    @log_count.setter
    def log_count(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "log_count", value)

    @property
    @pulumi.getter
    def order(self) -> Optional[pulumi.Input[str]]:
        """
        log export time sorting. desc or asc.
        """
        return pulumi.get(self, "order")

    @order.setter
    def order(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "order", value)

    @property
    @pulumi.getter
    def query(self) -> Optional[pulumi.Input[str]]:
        """
        export query rules.
        """
        return pulumi.get(self, "query")

    @query.setter
    def query(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "query", value)

    @property
    @pulumi.getter
    def to(self) -> Optional[pulumi.Input[int]]:
        """
        export end time.
        """
        return pulumi.get(self, "to")

    @to.setter
    def to(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "to", value)

    @property
    @pulumi.getter(name="topicId")
    def topic_id(self) -> Optional[pulumi.Input[str]]:
        """
        topic id.
        """
        return pulumi.get(self, "topic_id")

    @topic_id.setter
    def topic_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "topic_id", value)


class Export(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 format: Optional[pulumi.Input[str]] = None,
                 from_: Optional[pulumi.Input[int]] = None,
                 log_count: Optional[pulumi.Input[int]] = None,
                 order: Optional[pulumi.Input[str]] = None,
                 query: Optional[pulumi.Input[str]] = None,
                 to: Optional[pulumi.Input[int]] = None,
                 topic_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a resource to create a cls export

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        export = tencentcloud.cls.Export("export",
            format="json",
            from_=1607499107000,
            log_count=2,
            order="desc",
            query="select count(*) as count",
            to=1607499108000,
            topic_id="7e34a3a7-635e-4da8-9005-88106c1fde69")
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        cls export can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Cls/export:Export export topic_id#export_id
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] format: log export format.
        :param pulumi.Input[int] from_: export start time.
        :param pulumi.Input[int] log_count: export amount of log.
        :param pulumi.Input[str] order: log export time sorting. desc or asc.
        :param pulumi.Input[str] query: export query rules.
        :param pulumi.Input[int] to: export end time.
        :param pulumi.Input[str] topic_id: topic id.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ExportArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a cls export

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        export = tencentcloud.cls.Export("export",
            format="json",
            from_=1607499107000,
            log_count=2,
            order="desc",
            query="select count(*) as count",
            to=1607499108000,
            topic_id="7e34a3a7-635e-4da8-9005-88106c1fde69")
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        cls export can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Cls/export:Export export topic_id#export_id
        ```

        :param str resource_name: The name of the resource.
        :param ExportArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ExportArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 format: Optional[pulumi.Input[str]] = None,
                 from_: Optional[pulumi.Input[int]] = None,
                 log_count: Optional[pulumi.Input[int]] = None,
                 order: Optional[pulumi.Input[str]] = None,
                 query: Optional[pulumi.Input[str]] = None,
                 to: Optional[pulumi.Input[int]] = None,
                 topic_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ExportArgs.__new__(ExportArgs)

            __props__.__dict__["format"] = format
            if from_ is None and not opts.urn:
                raise TypeError("Missing required property 'from_'")
            __props__.__dict__["from_"] = from_
            if log_count is None and not opts.urn:
                raise TypeError("Missing required property 'log_count'")
            __props__.__dict__["log_count"] = log_count
            __props__.__dict__["order"] = order
            if query is None and not opts.urn:
                raise TypeError("Missing required property 'query'")
            __props__.__dict__["query"] = query
            if to is None and not opts.urn:
                raise TypeError("Missing required property 'to'")
            __props__.__dict__["to"] = to
            if topic_id is None and not opts.urn:
                raise TypeError("Missing required property 'topic_id'")
            __props__.__dict__["topic_id"] = topic_id
        super(Export, __self__).__init__(
            'tencentcloud:Cls/export:Export',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            format: Optional[pulumi.Input[str]] = None,
            from_: Optional[pulumi.Input[int]] = None,
            log_count: Optional[pulumi.Input[int]] = None,
            order: Optional[pulumi.Input[str]] = None,
            query: Optional[pulumi.Input[str]] = None,
            to: Optional[pulumi.Input[int]] = None,
            topic_id: Optional[pulumi.Input[str]] = None) -> 'Export':
        """
        Get an existing Export resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] format: log export format.
        :param pulumi.Input[int] from_: export start time.
        :param pulumi.Input[int] log_count: export amount of log.
        :param pulumi.Input[str] order: log export time sorting. desc or asc.
        :param pulumi.Input[str] query: export query rules.
        :param pulumi.Input[int] to: export end time.
        :param pulumi.Input[str] topic_id: topic id.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ExportState.__new__(_ExportState)

        __props__.__dict__["format"] = format
        __props__.__dict__["from_"] = from_
        __props__.__dict__["log_count"] = log_count
        __props__.__dict__["order"] = order
        __props__.__dict__["query"] = query
        __props__.__dict__["to"] = to
        __props__.__dict__["topic_id"] = topic_id
        return Export(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def format(self) -> pulumi.Output[Optional[str]]:
        """
        log export format.
        """
        return pulumi.get(self, "format")

    @property
    @pulumi.getter(name="from")
    def from_(self) -> pulumi.Output[int]:
        """
        export start time.
        """
        return pulumi.get(self, "from_")

    @property
    @pulumi.getter(name="logCount")
    def log_count(self) -> pulumi.Output[int]:
        """
        export amount of log.
        """
        return pulumi.get(self, "log_count")

    @property
    @pulumi.getter
    def order(self) -> pulumi.Output[Optional[str]]:
        """
        log export time sorting. desc or asc.
        """
        return pulumi.get(self, "order")

    @property
    @pulumi.getter
    def query(self) -> pulumi.Output[str]:
        """
        export query rules.
        """
        return pulumi.get(self, "query")

    @property
    @pulumi.getter
    def to(self) -> pulumi.Output[int]:
        """
        export end time.
        """
        return pulumi.get(self, "to")

    @property
    @pulumi.getter(name="topicId")
    def topic_id(self) -> pulumi.Output[str]:
        """
        topic id.
        """
        return pulumi.get(self, "topic_id")

