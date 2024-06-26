# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['RestartDbInstanceOperationArgs', 'RestartDbInstanceOperation']

@pulumi.input_type
class RestartDbInstanceOperationArgs:
    def __init__(__self__, *,
                 db_instance_id: pulumi.Input[str]):
        """
        The set of arguments for constructing a RestartDbInstanceOperation resource.
        :param pulumi.Input[str] db_instance_id: dbInstance ID.
        """
        pulumi.set(__self__, "db_instance_id", db_instance_id)

    @property
    @pulumi.getter(name="dbInstanceId")
    def db_instance_id(self) -> pulumi.Input[str]:
        """
        dbInstance ID.
        """
        return pulumi.get(self, "db_instance_id")

    @db_instance_id.setter
    def db_instance_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "db_instance_id", value)


@pulumi.input_type
class _RestartDbInstanceOperationState:
    def __init__(__self__, *,
                 db_instance_id: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering RestartDbInstanceOperation resources.
        :param pulumi.Input[str] db_instance_id: dbInstance ID.
        """
        if db_instance_id is not None:
            pulumi.set(__self__, "db_instance_id", db_instance_id)

    @property
    @pulumi.getter(name="dbInstanceId")
    def db_instance_id(self) -> Optional[pulumi.Input[str]]:
        """
        dbInstance ID.
        """
        return pulumi.get(self, "db_instance_id")

    @db_instance_id.setter
    def db_instance_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "db_instance_id", value)


class RestartDbInstanceOperation(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 db_instance_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a resource to create a postgresql restart_db_instance_operation

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        restart_db_instance_operation = tencentcloud.postgresql.RestartDbInstanceOperation("restartDbInstanceOperation", db_instance_id=local["pgsql_id"])
        ```
        <!--End PulumiCodeChooser -->

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] db_instance_id: dbInstance ID.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: RestartDbInstanceOperationArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a postgresql restart_db_instance_operation

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        restart_db_instance_operation = tencentcloud.postgresql.RestartDbInstanceOperation("restartDbInstanceOperation", db_instance_id=local["pgsql_id"])
        ```
        <!--End PulumiCodeChooser -->

        :param str resource_name: The name of the resource.
        :param RestartDbInstanceOperationArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(RestartDbInstanceOperationArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 db_instance_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = RestartDbInstanceOperationArgs.__new__(RestartDbInstanceOperationArgs)

            if db_instance_id is None and not opts.urn:
                raise TypeError("Missing required property 'db_instance_id'")
            __props__.__dict__["db_instance_id"] = db_instance_id
        super(RestartDbInstanceOperation, __self__).__init__(
            'tencentcloud:Postgresql/restartDbInstanceOperation:RestartDbInstanceOperation',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            db_instance_id: Optional[pulumi.Input[str]] = None) -> 'RestartDbInstanceOperation':
        """
        Get an existing RestartDbInstanceOperation resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] db_instance_id: dbInstance ID.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _RestartDbInstanceOperationState.__new__(_RestartDbInstanceOperationState)

        __props__.__dict__["db_instance_id"] = db_instance_id
        return RestartDbInstanceOperation(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="dbInstanceId")
    def db_instance_id(self) -> pulumi.Output[str]:
        """
        dbInstance ID.
        """
        return pulumi.get(self, "db_instance_id")

