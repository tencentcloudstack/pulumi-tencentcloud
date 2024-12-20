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

import types

__config__ = pulumi.Config('tencentcloud')


class _ExportableConfig(types.ModuleType):
    @property
    def assume_role(self) -> Optional[str]:
        return __config__.get('assumeRole')

    @property
    def assume_role_with_saml(self) -> Optional[str]:
        return __config__.get('assumeRoleWithSaml')

    @property
    def assume_role_with_web_identity(self) -> Optional[str]:
        return __config__.get('assumeRoleWithWebIdentity')

    @property
    def cam_role_name(self) -> Optional[str]:
        """
        The name of the CVM instance CAM role. It can be sourced from the `TENCENTCLOUD_CAM_ROLE_NAME` environment variable.
        """
        return __config__.get('camRoleName')

    @property
    def cos_domain(self) -> Optional[str]:
        """
        The cos domain of the API request, Default is `https://cos.{region}.myqcloud.com`, Other Examples:
        `https://cluster-123456.cos-cdc.ap-guangzhou.myqcloud.com`.
        """
        return __config__.get('cosDomain')

    @property
    def domain(self) -> Optional[str]:
        """
        The root domain of the API request, Default is `tencentcloudapi.com`.
        """
        return __config__.get('domain')

    @property
    def enable_pod_oidc(self) -> Optional[bool]:
        """
        Whether to enable pod oidc.
        """
        return __config__.get_bool('enablePodOidc')

    @property
    def profile(self) -> Optional[str]:
        """
        The profile name as set in the shared credentials. It can also be sourced from the `TENCENTCLOUD_PROFILE` environment
        variable. If not set, the default profile created with `tccli configure` will be used.
        """
        return __config__.get('profile')

    @property
    def protocol(self) -> Optional[str]:
        """
        The protocol of the API request. Valid values: `HTTP` and `HTTPS`. Default is `HTTPS`.
        """
        return __config__.get('protocol')

    @property
    def region(self) -> Optional[str]:
        """
        This is the TencentCloud region. It can also be sourced from the `TENCENTCLOUD_REGION` environment variables. The
        default input value is ap-guangzhou.
        """
        return __config__.get('region') or _utilities.get_env('TENCENTCLOUD_REGION')

    @property
    def secret_id(self) -> Optional[str]:
        """
        This is the TencentCloud access key. It can also be sourced from the `TENCENTCLOUD_SECRET_ID` environment variable.
        """
        return __config__.get('secretId') or _utilities.get_env('TENCENTCLOUD_SECRET_ID')

    @property
    def secret_key(self) -> Optional[str]:
        """
        This is the TencentCloud secret key. It can also be sourced from the `TENCENTCLOUD_SECRET_KEY` environment variable.
        """
        return __config__.get('secretKey') or _utilities.get_env('TENCENTCLOUD_SECRET_KEY')

    @property
    def security_token(self) -> Optional[str]:
        """
        TencentCloud Security Token of temporary access credentials. It can be sourced from the `TENCENTCLOUD_SECURITY_TOKEN`
        environment variable. Notice: for supported products, please refer to: [temporary key supported
        products](https://intl.cloud.tencent.com/document/product/598/10588).
        """
        return __config__.get('securityToken') or _utilities.get_env('TENCENTCLOUD_SECURITY_TOKEN')

    @property
    def shared_credentials_dir(self) -> Optional[str]:
        """
        The directory of the shared credentials. It can also be sourced from the `TENCENTCLOUD_SHARED_CREDENTIALS_DIR`
        environment variable. If not set this defaults to ~/.tccli.
        """
        return __config__.get('sharedCredentialsDir')

