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

__all__ = ['BucketDomainCertificateAttachmentArgs', 'BucketDomainCertificateAttachment']

@pulumi.input_type
class BucketDomainCertificateAttachmentArgs:
    def __init__(__self__, *,
                 bucket: pulumi.Input[str],
                 domain_certificate: pulumi.Input['BucketDomainCertificateAttachmentDomainCertificateArgs']):
        """
        The set of arguments for constructing a BucketDomainCertificateAttachment resource.
        :param pulumi.Input[str] bucket: Bucket name.
        :param pulumi.Input['BucketDomainCertificateAttachmentDomainCertificateArgs'] domain_certificate: The certificate of specified doamin.
        """
        pulumi.set(__self__, "bucket", bucket)
        pulumi.set(__self__, "domain_certificate", domain_certificate)

    @property
    @pulumi.getter
    def bucket(self) -> pulumi.Input[str]:
        """
        Bucket name.
        """
        return pulumi.get(self, "bucket")

    @bucket.setter
    def bucket(self, value: pulumi.Input[str]):
        pulumi.set(self, "bucket", value)

    @property
    @pulumi.getter(name="domainCertificate")
    def domain_certificate(self) -> pulumi.Input['BucketDomainCertificateAttachmentDomainCertificateArgs']:
        """
        The certificate of specified doamin.
        """
        return pulumi.get(self, "domain_certificate")

    @domain_certificate.setter
    def domain_certificate(self, value: pulumi.Input['BucketDomainCertificateAttachmentDomainCertificateArgs']):
        pulumi.set(self, "domain_certificate", value)


@pulumi.input_type
class _BucketDomainCertificateAttachmentState:
    def __init__(__self__, *,
                 bucket: Optional[pulumi.Input[str]] = None,
                 domain_certificate: Optional[pulumi.Input['BucketDomainCertificateAttachmentDomainCertificateArgs']] = None):
        """
        Input properties used for looking up and filtering BucketDomainCertificateAttachment resources.
        :param pulumi.Input[str] bucket: Bucket name.
        :param pulumi.Input['BucketDomainCertificateAttachmentDomainCertificateArgs'] domain_certificate: The certificate of specified doamin.
        """
        if bucket is not None:
            pulumi.set(__self__, "bucket", bucket)
        if domain_certificate is not None:
            pulumi.set(__self__, "domain_certificate", domain_certificate)

    @property
    @pulumi.getter
    def bucket(self) -> Optional[pulumi.Input[str]]:
        """
        Bucket name.
        """
        return pulumi.get(self, "bucket")

    @bucket.setter
    def bucket(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "bucket", value)

    @property
    @pulumi.getter(name="domainCertificate")
    def domain_certificate(self) -> Optional[pulumi.Input['BucketDomainCertificateAttachmentDomainCertificateArgs']]:
        """
        The certificate of specified doamin.
        """
        return pulumi.get(self, "domain_certificate")

    @domain_certificate.setter
    def domain_certificate(self, value: Optional[pulumi.Input['BucketDomainCertificateAttachmentDomainCertificateArgs']]):
        pulumi.set(self, "domain_certificate", value)


class BucketDomainCertificateAttachment(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 bucket: Optional[pulumi.Input[str]] = None,
                 domain_certificate: Optional[pulumi.Input[pulumi.InputType['BucketDomainCertificateAttachmentDomainCertificateArgs']]] = None,
                 __props__=None):
        """
        Provides a resource to attach/detach the corresponding certificate for the domain name in specified cos bucket.

        ## Example Usage

        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        foo = tencentcloud.cos.BucketDomainCertificateAttachment("foo",
            bucket="",
            domain_certificate=tencentcloud.cos.BucketDomainCertificateAttachmentDomainCertificateArgs(
                certificate=tencentcloud.cos.BucketDomainCertificateAttachmentDomainCertificateCertificateArgs(
                    cert_type="CustomCert",
                    custom_cert=tencentcloud.cos.BucketDomainCertificateAttachmentDomainCertificateCertificateCustomCertArgs(
                        cert="===CERTIFICATE===",
                        private_key="===PRIVATE_KEY===",
                    ),
                ),
                domain="domain_name",
            ))
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] bucket: Bucket name.
        :param pulumi.Input[pulumi.InputType['BucketDomainCertificateAttachmentDomainCertificateArgs']] domain_certificate: The certificate of specified doamin.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: BucketDomainCertificateAttachmentArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to attach/detach the corresponding certificate for the domain name in specified cos bucket.

        ## Example Usage

        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        foo = tencentcloud.cos.BucketDomainCertificateAttachment("foo",
            bucket="",
            domain_certificate=tencentcloud.cos.BucketDomainCertificateAttachmentDomainCertificateArgs(
                certificate=tencentcloud.cos.BucketDomainCertificateAttachmentDomainCertificateCertificateArgs(
                    cert_type="CustomCert",
                    custom_cert=tencentcloud.cos.BucketDomainCertificateAttachmentDomainCertificateCertificateCustomCertArgs(
                        cert="===CERTIFICATE===",
                        private_key="===PRIVATE_KEY===",
                    ),
                ),
                domain="domain_name",
            ))
        ```

        :param str resource_name: The name of the resource.
        :param BucketDomainCertificateAttachmentArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(BucketDomainCertificateAttachmentArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 bucket: Optional[pulumi.Input[str]] = None,
                 domain_certificate: Optional[pulumi.Input[pulumi.InputType['BucketDomainCertificateAttachmentDomainCertificateArgs']]] = None,
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
            __props__ = BucketDomainCertificateAttachmentArgs.__new__(BucketDomainCertificateAttachmentArgs)

            if bucket is None and not opts.urn:
                raise TypeError("Missing required property 'bucket'")
            __props__.__dict__["bucket"] = bucket
            if domain_certificate is None and not opts.urn:
                raise TypeError("Missing required property 'domain_certificate'")
            __props__.__dict__["domain_certificate"] = domain_certificate
        super(BucketDomainCertificateAttachment, __self__).__init__(
            'tencentcloud:Cos/bucketDomainCertificateAttachment:BucketDomainCertificateAttachment',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            bucket: Optional[pulumi.Input[str]] = None,
            domain_certificate: Optional[pulumi.Input[pulumi.InputType['BucketDomainCertificateAttachmentDomainCertificateArgs']]] = None) -> 'BucketDomainCertificateAttachment':
        """
        Get an existing BucketDomainCertificateAttachment resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] bucket: Bucket name.
        :param pulumi.Input[pulumi.InputType['BucketDomainCertificateAttachmentDomainCertificateArgs']] domain_certificate: The certificate of specified doamin.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _BucketDomainCertificateAttachmentState.__new__(_BucketDomainCertificateAttachmentState)

        __props__.__dict__["bucket"] = bucket
        __props__.__dict__["domain_certificate"] = domain_certificate
        return BucketDomainCertificateAttachment(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def bucket(self) -> pulumi.Output[str]:
        """
        Bucket name.
        """
        return pulumi.get(self, "bucket")

    @property
    @pulumi.getter(name="domainCertificate")
    def domain_certificate(self) -> pulumi.Output['outputs.BucketDomainCertificateAttachmentDomainCertificate']:
        """
        The certificate of specified doamin.
        """
        return pulumi.get(self, "domain_certificate")
