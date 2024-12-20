# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = [
    'AssumeRole',
    'AssumeRoleWithSaml',
    'AssumeRoleWithWebIdentity',
]

@pulumi.output_type
class AssumeRole(dict):
    def __init__(__self__, *,
                 role_arn: str,
                 session_duration: int,
                 session_name: str,
                 external_id: Optional[str] = None,
                 policy: Optional[str] = None):
        """
        :param str role_arn: The ARN of the role to assume. It can be sourced from the `TENCENTCLOUD_ASSUME_ROLE_ARN`.
        :param int session_duration: The duration of the session when making the AssumeRole call. Its value ranges from 0 to 43200(seconds), and default is 7200 seconds. It can be sourced from the `TENCENTCLOUD_ASSUME_ROLE_SESSION_DURATION`.
        :param str session_name: The session name to use when making the AssumeRole call. It can be sourced from the `TENCENTCLOUD_ASSUME_ROLE_SESSION_NAME`.
        :param str external_id: External role ID, which can be obtained by clicking the role name in the CAM console. It can contain 2-128 letters, digits, and symbols (=,.@:/-). Regex: [\\w+=,.@:/-]*. It can be sourced from the `TENCENTCLOUD_ASSUME_ROLE_EXTERNAL_ID`.
        :param str policy: A more restrictive policy when making the AssumeRole call. Its content must not contains `principal` elements. Notice: more syntax references, please refer to: [policies syntax logic](https://intl.cloud.tencent.com/document/product/598/10603).
        """
        pulumi.set(__self__, "role_arn", role_arn)
        pulumi.set(__self__, "session_duration", session_duration)
        pulumi.set(__self__, "session_name", session_name)
        if external_id is not None:
            pulumi.set(__self__, "external_id", external_id)
        if policy is not None:
            pulumi.set(__self__, "policy", policy)

    @property
    @pulumi.getter(name="roleArn")
    def role_arn(self) -> str:
        """
        The ARN of the role to assume. It can be sourced from the `TENCENTCLOUD_ASSUME_ROLE_ARN`.
        """
        return pulumi.get(self, "role_arn")

    @property
    @pulumi.getter(name="sessionDuration")
    def session_duration(self) -> int:
        """
        The duration of the session when making the AssumeRole call. Its value ranges from 0 to 43200(seconds), and default is 7200 seconds. It can be sourced from the `TENCENTCLOUD_ASSUME_ROLE_SESSION_DURATION`.
        """
        return pulumi.get(self, "session_duration")

    @property
    @pulumi.getter(name="sessionName")
    def session_name(self) -> str:
        """
        The session name to use when making the AssumeRole call. It can be sourced from the `TENCENTCLOUD_ASSUME_ROLE_SESSION_NAME`.
        """
        return pulumi.get(self, "session_name")

    @property
    @pulumi.getter(name="externalId")
    def external_id(self) -> Optional[str]:
        """
        External role ID, which can be obtained by clicking the role name in the CAM console. It can contain 2-128 letters, digits, and symbols (=,.@:/-). Regex: [\\w+=,.@:/-]*. It can be sourced from the `TENCENTCLOUD_ASSUME_ROLE_EXTERNAL_ID`.
        """
        return pulumi.get(self, "external_id")

    @property
    @pulumi.getter
    def policy(self) -> Optional[str]:
        """
        A more restrictive policy when making the AssumeRole call. Its content must not contains `principal` elements. Notice: more syntax references, please refer to: [policies syntax logic](https://intl.cloud.tencent.com/document/product/598/10603).
        """
        return pulumi.get(self, "policy")


@pulumi.output_type
class AssumeRoleWithSaml(dict):
    def __init__(__self__, *,
                 principal_arn: str,
                 role_arn: str,
                 saml_assertion: str,
                 session_duration: int,
                 session_name: str):
        """
        :param str principal_arn: Player Access Description Name. It can be sourced from the `PROVIDER_ASSUME_ROLE_PRINCIPAL_ARN`.
        :param str role_arn: The ARN of the role to assume. It can be sourced from the `TENCENTCLOUD_ASSUME_ROLE_ARN`.
        :param str saml_assertion: SAML assertion information encoded in base64. It can be sourced from the `PROVIDER_ASSUME_ROLE_SAML_ASSERTION`.
        :param int session_duration: The duration of the session when making the AssumeRoleWithSAML call. Its value ranges from 0 to 43200(seconds), and default is 7200 seconds. It can be sourced from the `TENCENTCLOUD_ASSUME_ROLE_SESSION_DURATION`.
        :param str session_name: The session name to use when making the AssumeRole call. It can be sourced from the `TENCENTCLOUD_ASSUME_ROLE_SESSION_NAME`.
        """
        pulumi.set(__self__, "principal_arn", principal_arn)
        pulumi.set(__self__, "role_arn", role_arn)
        pulumi.set(__self__, "saml_assertion", saml_assertion)
        pulumi.set(__self__, "session_duration", session_duration)
        pulumi.set(__self__, "session_name", session_name)

    @property
    @pulumi.getter(name="principalArn")
    def principal_arn(self) -> str:
        """
        Player Access Description Name. It can be sourced from the `PROVIDER_ASSUME_ROLE_PRINCIPAL_ARN`.
        """
        return pulumi.get(self, "principal_arn")

    @property
    @pulumi.getter(name="roleArn")
    def role_arn(self) -> str:
        """
        The ARN of the role to assume. It can be sourced from the `TENCENTCLOUD_ASSUME_ROLE_ARN`.
        """
        return pulumi.get(self, "role_arn")

    @property
    @pulumi.getter(name="samlAssertion")
    def saml_assertion(self) -> str:
        """
        SAML assertion information encoded in base64. It can be sourced from the `PROVIDER_ASSUME_ROLE_SAML_ASSERTION`.
        """
        return pulumi.get(self, "saml_assertion")

    @property
    @pulumi.getter(name="sessionDuration")
    def session_duration(self) -> int:
        """
        The duration of the session when making the AssumeRoleWithSAML call. Its value ranges from 0 to 43200(seconds), and default is 7200 seconds. It can be sourced from the `TENCENTCLOUD_ASSUME_ROLE_SESSION_DURATION`.
        """
        return pulumi.get(self, "session_duration")

    @property
    @pulumi.getter(name="sessionName")
    def session_name(self) -> str:
        """
        The session name to use when making the AssumeRole call. It can be sourced from the `TENCENTCLOUD_ASSUME_ROLE_SESSION_NAME`.
        """
        return pulumi.get(self, "session_name")


@pulumi.output_type
class AssumeRoleWithWebIdentity(dict):
    def __init__(__self__, *,
                 role_arn: str,
                 session_duration: int,
                 session_name: str,
                 web_identity_token: str):
        """
        :param str role_arn: The ARN of the role to assume. It can be sourced from the `TENCENTCLOUD_ASSUME_ROLE_ARN`.
        :param int session_duration: The duration of the session when making the AssumeRoleWithWebIdentity call. Its value ranges from 0 to 43200(seconds), and default is 7200 seconds. It can be sourced from the `TENCENTCLOUD_ASSUME_ROLE_SESSION_DURATION`.
        :param str session_name: The session name to use when making the AssumeRole call. It can be sourced from the `TENCENTCLOUD_ASSUME_ROLE_SESSION_NAME`.
        :param str web_identity_token: OIDC token issued by IdP. It can be sourced from the `PROVIDER_ASSUME_ROLE_WEB_IDENTITY_TOKEN`.
        """
        pulumi.set(__self__, "role_arn", role_arn)
        pulumi.set(__self__, "session_duration", session_duration)
        pulumi.set(__self__, "session_name", session_name)
        pulumi.set(__self__, "web_identity_token", web_identity_token)

    @property
    @pulumi.getter(name="roleArn")
    def role_arn(self) -> str:
        """
        The ARN of the role to assume. It can be sourced from the `TENCENTCLOUD_ASSUME_ROLE_ARN`.
        """
        return pulumi.get(self, "role_arn")

    @property
    @pulumi.getter(name="sessionDuration")
    def session_duration(self) -> int:
        """
        The duration of the session when making the AssumeRoleWithWebIdentity call. Its value ranges from 0 to 43200(seconds), and default is 7200 seconds. It can be sourced from the `TENCENTCLOUD_ASSUME_ROLE_SESSION_DURATION`.
        """
        return pulumi.get(self, "session_duration")

    @property
    @pulumi.getter(name="sessionName")
    def session_name(self) -> str:
        """
        The session name to use when making the AssumeRole call. It can be sourced from the `TENCENTCLOUD_ASSUME_ROLE_SESSION_NAME`.
        """
        return pulumi.get(self, "session_name")

    @property
    @pulumi.getter(name="webIdentityToken")
    def web_identity_token(self) -> str:
        """
        OIDC token issued by IdP. It can be sourced from the `PROVIDER_ASSUME_ROLE_WEB_IDENTITY_TOKEN`.
        """
        return pulumi.get(self, "web_identity_token")


