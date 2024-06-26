# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['BindDeviceAccountPrivateKeyArgs', 'BindDeviceAccountPrivateKey']

@pulumi.input_type
class BindDeviceAccountPrivateKeyArgs:
    def __init__(__self__, *,
                 device_account_id: pulumi.Input[int],
                 private_key: pulumi.Input[str],
                 private_key_password: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a BindDeviceAccountPrivateKey resource.
        :param pulumi.Input[int] device_account_id: Host account ID.
        :param pulumi.Input[str] private_key: Host account private key, the latest length is 128 bytes, the maximum length is 8192 bytes.
        :param pulumi.Input[str] private_key_password: Host account private key password, maximum length 256 bytes.
        """
        pulumi.set(__self__, "device_account_id", device_account_id)
        pulumi.set(__self__, "private_key", private_key)
        if private_key_password is not None:
            pulumi.set(__self__, "private_key_password", private_key_password)

    @property
    @pulumi.getter(name="deviceAccountId")
    def device_account_id(self) -> pulumi.Input[int]:
        """
        Host account ID.
        """
        return pulumi.get(self, "device_account_id")

    @device_account_id.setter
    def device_account_id(self, value: pulumi.Input[int]):
        pulumi.set(self, "device_account_id", value)

    @property
    @pulumi.getter(name="privateKey")
    def private_key(self) -> pulumi.Input[str]:
        """
        Host account private key, the latest length is 128 bytes, the maximum length is 8192 bytes.
        """
        return pulumi.get(self, "private_key")

    @private_key.setter
    def private_key(self, value: pulumi.Input[str]):
        pulumi.set(self, "private_key", value)

    @property
    @pulumi.getter(name="privateKeyPassword")
    def private_key_password(self) -> Optional[pulumi.Input[str]]:
        """
        Host account private key password, maximum length 256 bytes.
        """
        return pulumi.get(self, "private_key_password")

    @private_key_password.setter
    def private_key_password(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "private_key_password", value)


@pulumi.input_type
class _BindDeviceAccountPrivateKeyState:
    def __init__(__self__, *,
                 device_account_id: Optional[pulumi.Input[int]] = None,
                 private_key: Optional[pulumi.Input[str]] = None,
                 private_key_password: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering BindDeviceAccountPrivateKey resources.
        :param pulumi.Input[int] device_account_id: Host account ID.
        :param pulumi.Input[str] private_key: Host account private key, the latest length is 128 bytes, the maximum length is 8192 bytes.
        :param pulumi.Input[str] private_key_password: Host account private key password, maximum length 256 bytes.
        """
        if device_account_id is not None:
            pulumi.set(__self__, "device_account_id", device_account_id)
        if private_key is not None:
            pulumi.set(__self__, "private_key", private_key)
        if private_key_password is not None:
            pulumi.set(__self__, "private_key_password", private_key_password)

    @property
    @pulumi.getter(name="deviceAccountId")
    def device_account_id(self) -> Optional[pulumi.Input[int]]:
        """
        Host account ID.
        """
        return pulumi.get(self, "device_account_id")

    @device_account_id.setter
    def device_account_id(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "device_account_id", value)

    @property
    @pulumi.getter(name="privateKey")
    def private_key(self) -> Optional[pulumi.Input[str]]:
        """
        Host account private key, the latest length is 128 bytes, the maximum length is 8192 bytes.
        """
        return pulumi.get(self, "private_key")

    @private_key.setter
    def private_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "private_key", value)

    @property
    @pulumi.getter(name="privateKeyPassword")
    def private_key_password(self) -> Optional[pulumi.Input[str]]:
        """
        Host account private key password, maximum length 256 bytes.
        """
        return pulumi.get(self, "private_key_password")

    @private_key_password.setter
    def private_key_password(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "private_key_password", value)


class BindDeviceAccountPrivateKey(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 device_account_id: Optional[pulumi.Input[int]] = None,
                 private_key: Optional[pulumi.Input[str]] = None,
                 private_key_password: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a resource to create a dasb bind_device_account_private_key

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        example_device = tencentcloud.dasb.Device("exampleDevice",
            os_name="Linux",
            ip="192.168.0.1",
            port=80)
        example_device_account = tencentcloud.dasb.DeviceAccount("exampleDeviceAccount",
            device_id=example_device.id,
            account="root")
        example_bind_device_account_private_key = tencentcloud.dasb.BindDeviceAccountPrivateKey("exampleBindDeviceAccountPrivateKey",
            device_account_id=example_device_account.id,
            private_key="MIICXAIBAAKBgQCqGKukO1De7zhZj6+H0qtjTkVxwTCpvKe4eCZ0FPqri0cb2JZfXJ/DgYSF6vUpwmJG8wVQZKjeGcjDOL5UlsuusFncCzWBQ7RKNUSesmQRMSGkVb1/3j+skZ6UtW+5u09lHNsj6tQ51s1SPrCBkedbNf0Tp0GbMJDyR4e9T04ZZwIDAQABAoGAFijko56+qGyN8M0RVyaRAXz++xTqHBLh",
            private_key_password="TerraformPassword")
        ```
        <!--End PulumiCodeChooser -->

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[int] device_account_id: Host account ID.
        :param pulumi.Input[str] private_key: Host account private key, the latest length is 128 bytes, the maximum length is 8192 bytes.
        :param pulumi.Input[str] private_key_password: Host account private key password, maximum length 256 bytes.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: BindDeviceAccountPrivateKeyArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a dasb bind_device_account_private_key

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        example_device = tencentcloud.dasb.Device("exampleDevice",
            os_name="Linux",
            ip="192.168.0.1",
            port=80)
        example_device_account = tencentcloud.dasb.DeviceAccount("exampleDeviceAccount",
            device_id=example_device.id,
            account="root")
        example_bind_device_account_private_key = tencentcloud.dasb.BindDeviceAccountPrivateKey("exampleBindDeviceAccountPrivateKey",
            device_account_id=example_device_account.id,
            private_key="MIICXAIBAAKBgQCqGKukO1De7zhZj6+H0qtjTkVxwTCpvKe4eCZ0FPqri0cb2JZfXJ/DgYSF6vUpwmJG8wVQZKjeGcjDOL5UlsuusFncCzWBQ7RKNUSesmQRMSGkVb1/3j+skZ6UtW+5u09lHNsj6tQ51s1SPrCBkedbNf0Tp0GbMJDyR4e9T04ZZwIDAQABAoGAFijko56+qGyN8M0RVyaRAXz++xTqHBLh",
            private_key_password="TerraformPassword")
        ```
        <!--End PulumiCodeChooser -->

        :param str resource_name: The name of the resource.
        :param BindDeviceAccountPrivateKeyArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(BindDeviceAccountPrivateKeyArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 device_account_id: Optional[pulumi.Input[int]] = None,
                 private_key: Optional[pulumi.Input[str]] = None,
                 private_key_password: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = BindDeviceAccountPrivateKeyArgs.__new__(BindDeviceAccountPrivateKeyArgs)

            if device_account_id is None and not opts.urn:
                raise TypeError("Missing required property 'device_account_id'")
            __props__.__dict__["device_account_id"] = device_account_id
            if private_key is None and not opts.urn:
                raise TypeError("Missing required property 'private_key'")
            __props__.__dict__["private_key"] = private_key
            __props__.__dict__["private_key_password"] = private_key_password
        super(BindDeviceAccountPrivateKey, __self__).__init__(
            'tencentcloud:Dasb/bindDeviceAccountPrivateKey:BindDeviceAccountPrivateKey',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            device_account_id: Optional[pulumi.Input[int]] = None,
            private_key: Optional[pulumi.Input[str]] = None,
            private_key_password: Optional[pulumi.Input[str]] = None) -> 'BindDeviceAccountPrivateKey':
        """
        Get an existing BindDeviceAccountPrivateKey resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[int] device_account_id: Host account ID.
        :param pulumi.Input[str] private_key: Host account private key, the latest length is 128 bytes, the maximum length is 8192 bytes.
        :param pulumi.Input[str] private_key_password: Host account private key password, maximum length 256 bytes.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _BindDeviceAccountPrivateKeyState.__new__(_BindDeviceAccountPrivateKeyState)

        __props__.__dict__["device_account_id"] = device_account_id
        __props__.__dict__["private_key"] = private_key
        __props__.__dict__["private_key_password"] = private_key_password
        return BindDeviceAccountPrivateKey(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="deviceAccountId")
    def device_account_id(self) -> pulumi.Output[int]:
        """
        Host account ID.
        """
        return pulumi.get(self, "device_account_id")

    @property
    @pulumi.getter(name="privateKey")
    def private_key(self) -> pulumi.Output[str]:
        """
        Host account private key, the latest length is 128 bytes, the maximum length is 8192 bytes.
        """
        return pulumi.get(self, "private_key")

    @property
    @pulumi.getter(name="privateKeyPassword")
    def private_key_password(self) -> pulumi.Output[Optional[str]]:
        """
        Host account private key password, maximum length 256 bytes.
        """
        return pulumi.get(self, "private_key_password")

