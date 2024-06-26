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
    'BatchSendEmailAttachmentArgs',
    'BatchSendEmailCycleParamArgs',
    'BatchSendEmailTemplateArgs',
    'BatchSendEmailTimedParamArgs',
    'DomainAttributeArgs',
    'ReceiverDataArgs',
    'SendEmailAttachmentArgs',
    'SendEmailTemplateArgs',
    'TemplateTemplateContentArgs',
]

@pulumi.input_type
class BatchSendEmailAttachmentArgs:
    def __init__(__self__, *,
                 content: pulumi.Input[str],
                 file_name: pulumi.Input[str]):
        """
        :param pulumi.Input[str] content: Base64-encoded attachment content. You can send attachments of up to 4 MB in the total size.Note: The TencentCloud API supports a request packet of up to 8 MB in size, and the size of the attachmentcontent will increase by 1.5 times after Base64 encoding. Therefore, you need to keep the total size of allattachments below 4 MB. If the entire request exceeds 8 MB, the API will return an error.
        :param pulumi.Input[str] file_name: Attachment name, which cannot exceed 255 characters. Some attachment types are not supported. For details, see [Attachment Types.](https://www.tencentcloud.com/document/product/1084/42373?has_map=1).
        """
        pulumi.set(__self__, "content", content)
        pulumi.set(__self__, "file_name", file_name)

    @property
    @pulumi.getter
    def content(self) -> pulumi.Input[str]:
        """
        Base64-encoded attachment content. You can send attachments of up to 4 MB in the total size.Note: The TencentCloud API supports a request packet of up to 8 MB in size, and the size of the attachmentcontent will increase by 1.5 times after Base64 encoding. Therefore, you need to keep the total size of allattachments below 4 MB. If the entire request exceeds 8 MB, the API will return an error.
        """
        return pulumi.get(self, "content")

    @content.setter
    def content(self, value: pulumi.Input[str]):
        pulumi.set(self, "content", value)

    @property
    @pulumi.getter(name="fileName")
    def file_name(self) -> pulumi.Input[str]:
        """
        Attachment name, which cannot exceed 255 characters. Some attachment types are not supported. For details, see [Attachment Types.](https://www.tencentcloud.com/document/product/1084/42373?has_map=1).
        """
        return pulumi.get(self, "file_name")

    @file_name.setter
    def file_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "file_name", value)


@pulumi.input_type
class BatchSendEmailCycleParamArgs:
    def __init__(__self__, *,
                 begin_time: pulumi.Input[str],
                 interval_time: pulumi.Input[int],
                 term_cycle: Optional[pulumi.Input[int]] = None):
        """
        :param pulumi.Input[str] begin_time: Start time of the task.
        :param pulumi.Input[int] interval_time: Task recurrence in hours.
        :param pulumi.Input[int] term_cycle: Specifies whether to end the cycle. This parameter is used to update the task. Valid values: 0: No; 1: Yes.
        """
        pulumi.set(__self__, "begin_time", begin_time)
        pulumi.set(__self__, "interval_time", interval_time)
        if term_cycle is not None:
            pulumi.set(__self__, "term_cycle", term_cycle)

    @property
    @pulumi.getter(name="beginTime")
    def begin_time(self) -> pulumi.Input[str]:
        """
        Start time of the task.
        """
        return pulumi.get(self, "begin_time")

    @begin_time.setter
    def begin_time(self, value: pulumi.Input[str]):
        pulumi.set(self, "begin_time", value)

    @property
    @pulumi.getter(name="intervalTime")
    def interval_time(self) -> pulumi.Input[int]:
        """
        Task recurrence in hours.
        """
        return pulumi.get(self, "interval_time")

    @interval_time.setter
    def interval_time(self, value: pulumi.Input[int]):
        pulumi.set(self, "interval_time", value)

    @property
    @pulumi.getter(name="termCycle")
    def term_cycle(self) -> Optional[pulumi.Input[int]]:
        """
        Specifies whether to end the cycle. This parameter is used to update the task. Valid values: 0: No; 1: Yes.
        """
        return pulumi.get(self, "term_cycle")

    @term_cycle.setter
    def term_cycle(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "term_cycle", value)


@pulumi.input_type
class BatchSendEmailTemplateArgs:
    def __init__(__self__, *,
                 template_data: pulumi.Input[str],
                 template_id: pulumi.Input[int]):
        """
        :param pulumi.Input[str] template_data: Variable parameters in the template. Please use json.dump to format the JSON object into a string type.The object is a set of key-value pairs. Each key denotes a variable, which is represented by {{key}}. The key will be replaced with the correspondingvalue (represented by {{value}}) when sending the email.Note: The parameter value cannot be data of a complex type such as HTML.Example: {name:xxx,age:xx}.
        :param pulumi.Input[int] template_id: Template ID. If you do not have any template, please create one.
        """
        pulumi.set(__self__, "template_data", template_data)
        pulumi.set(__self__, "template_id", template_id)

    @property
    @pulumi.getter(name="templateData")
    def template_data(self) -> pulumi.Input[str]:
        """
        Variable parameters in the template. Please use json.dump to format the JSON object into a string type.The object is a set of key-value pairs. Each key denotes a variable, which is represented by {{key}}. The key will be replaced with the correspondingvalue (represented by {{value}}) when sending the email.Note: The parameter value cannot be data of a complex type such as HTML.Example: {name:xxx,age:xx}.
        """
        return pulumi.get(self, "template_data")

    @template_data.setter
    def template_data(self, value: pulumi.Input[str]):
        pulumi.set(self, "template_data", value)

    @property
    @pulumi.getter(name="templateId")
    def template_id(self) -> pulumi.Input[int]:
        """
        Template ID. If you do not have any template, please create one.
        """
        return pulumi.get(self, "template_id")

    @template_id.setter
    def template_id(self, value: pulumi.Input[int]):
        pulumi.set(self, "template_id", value)


@pulumi.input_type
class BatchSendEmailTimedParamArgs:
    def __init__(__self__, *,
                 begin_time: pulumi.Input[str]):
        """
        :param pulumi.Input[str] begin_time: Start time of a scheduled sending task.
        """
        pulumi.set(__self__, "begin_time", begin_time)

    @property
    @pulumi.getter(name="beginTime")
    def begin_time(self) -> pulumi.Input[str]:
        """
        Start time of a scheduled sending task.
        """
        return pulumi.get(self, "begin_time")

    @begin_time.setter
    def begin_time(self, value: pulumi.Input[str]):
        pulumi.set(self, "begin_time", value)


@pulumi.input_type
class DomainAttributeArgs:
    def __init__(__self__, *,
                 expected_value: Optional[pulumi.Input[str]] = None,
                 send_domain: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input[str] expected_value: Values that need to be configured.
        :param pulumi.Input[str] send_domain: Domain name.
        :param pulumi.Input[str] type: Record Type CNAME | A | TXT | MX.
        """
        if expected_value is not None:
            pulumi.set(__self__, "expected_value", expected_value)
        if send_domain is not None:
            pulumi.set(__self__, "send_domain", send_domain)
        if type is not None:
            pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="expectedValue")
    def expected_value(self) -> Optional[pulumi.Input[str]]:
        """
        Values that need to be configured.
        """
        return pulumi.get(self, "expected_value")

    @expected_value.setter
    def expected_value(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "expected_value", value)

    @property
    @pulumi.getter(name="sendDomain")
    def send_domain(self) -> Optional[pulumi.Input[str]]:
        """
        Domain name.
        """
        return pulumi.get(self, "send_domain")

    @send_domain.setter
    def send_domain(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "send_domain", value)

    @property
    @pulumi.getter
    def type(self) -> Optional[pulumi.Input[str]]:
        """
        Record Type CNAME | A | TXT | MX.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "type", value)


@pulumi.input_type
class ReceiverDataArgs:
    def __init__(__self__, *,
                 email: pulumi.Input[str],
                 template_data: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input[str] email: Recipient email addresses.
        :param pulumi.Input[str] template_data: Variable parameters in the template, please use json.dump to format the JSON object as a string type. The object is a set of key-value pairs, where each key represents a variable in the template, and the variables in the template are represented by {{key}}, and the corresponding values will be replaced with {{value}} when sent.Note: Parameter values cannot be complex data such as HTML. The total length of TemplateData (the entire JSON structure) should be less than 800 bytes.
        """
        pulumi.set(__self__, "email", email)
        if template_data is not None:
            pulumi.set(__self__, "template_data", template_data)

    @property
    @pulumi.getter
    def email(self) -> pulumi.Input[str]:
        """
        Recipient email addresses.
        """
        return pulumi.get(self, "email")

    @email.setter
    def email(self, value: pulumi.Input[str]):
        pulumi.set(self, "email", value)

    @property
    @pulumi.getter(name="templateData")
    def template_data(self) -> Optional[pulumi.Input[str]]:
        """
        Variable parameters in the template, please use json.dump to format the JSON object as a string type. The object is a set of key-value pairs, where each key represents a variable in the template, and the variables in the template are represented by {{key}}, and the corresponding values will be replaced with {{value}} when sent.Note: Parameter values cannot be complex data such as HTML. The total length of TemplateData (the entire JSON structure) should be less than 800 bytes.
        """
        return pulumi.get(self, "template_data")

    @template_data.setter
    def template_data(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "template_data", value)


@pulumi.input_type
class SendEmailAttachmentArgs:
    def __init__(__self__, *,
                 content: pulumi.Input[str],
                 file_name: pulumi.Input[str]):
        """
        :param pulumi.Input[str] content: Base64-encoded attachment content. You can send attachments of up to 4 MB in the total size.Note: The TencentCloud API supports a request packet of up to 8 MB in size, and the size of the attachmentcontent will increase by 1.5 times after Base64 encoding. Therefore, you need to keep the total size of allattachments below 4 MB. If the entire request exceeds 8 MB, the API will return an error.
        :param pulumi.Input[str] file_name: Attachment name, which cannot exceed 255 characters. Some attachment types are not supported. For details, see [Attachment Types.](https://www.tencentcloud.com/document/product/1084/42373?has_map=1).
        """
        pulumi.set(__self__, "content", content)
        pulumi.set(__self__, "file_name", file_name)

    @property
    @pulumi.getter
    def content(self) -> pulumi.Input[str]:
        """
        Base64-encoded attachment content. You can send attachments of up to 4 MB in the total size.Note: The TencentCloud API supports a request packet of up to 8 MB in size, and the size of the attachmentcontent will increase by 1.5 times after Base64 encoding. Therefore, you need to keep the total size of allattachments below 4 MB. If the entire request exceeds 8 MB, the API will return an error.
        """
        return pulumi.get(self, "content")

    @content.setter
    def content(self, value: pulumi.Input[str]):
        pulumi.set(self, "content", value)

    @property
    @pulumi.getter(name="fileName")
    def file_name(self) -> pulumi.Input[str]:
        """
        Attachment name, which cannot exceed 255 characters. Some attachment types are not supported. For details, see [Attachment Types.](https://www.tencentcloud.com/document/product/1084/42373?has_map=1).
        """
        return pulumi.get(self, "file_name")

    @file_name.setter
    def file_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "file_name", value)


@pulumi.input_type
class SendEmailTemplateArgs:
    def __init__(__self__, *,
                 template_data: pulumi.Input[str],
                 template_id: pulumi.Input[int]):
        """
        :param pulumi.Input[str] template_data: Variable parameters in the template. Please use json.dump to format the JSON object into a string type.The object is a set of key-value pairs. Each key denotes a variable, which is represented by {{key}}. The key will be replaced with the correspondingvalue (represented by {{value}}) when sending the email.Note: The parameter value cannot be data of a complex type such as HTML.Example: {name:xxx,age:xx}.
        :param pulumi.Input[int] template_id: Template ID. If you do not have any template, please create one.
        """
        pulumi.set(__self__, "template_data", template_data)
        pulumi.set(__self__, "template_id", template_id)

    @property
    @pulumi.getter(name="templateData")
    def template_data(self) -> pulumi.Input[str]:
        """
        Variable parameters in the template. Please use json.dump to format the JSON object into a string type.The object is a set of key-value pairs. Each key denotes a variable, which is represented by {{key}}. The key will be replaced with the correspondingvalue (represented by {{value}}) when sending the email.Note: The parameter value cannot be data of a complex type such as HTML.Example: {name:xxx,age:xx}.
        """
        return pulumi.get(self, "template_data")

    @template_data.setter
    def template_data(self, value: pulumi.Input[str]):
        pulumi.set(self, "template_data", value)

    @property
    @pulumi.getter(name="templateId")
    def template_id(self) -> pulumi.Input[int]:
        """
        Template ID. If you do not have any template, please create one.
        """
        return pulumi.get(self, "template_id")

    @template_id.setter
    def template_id(self, value: pulumi.Input[int]):
        pulumi.set(self, "template_id", value)


@pulumi.input_type
class TemplateTemplateContentArgs:
    def __init__(__self__, *,
                 html: Optional[pulumi.Input[str]] = None,
                 text: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input[str] html: Html code after base64.
        :param pulumi.Input[str] text: Text content after base64.
        """
        if html is not None:
            pulumi.set(__self__, "html", html)
        if text is not None:
            pulumi.set(__self__, "text", text)

    @property
    @pulumi.getter
    def html(self) -> Optional[pulumi.Input[str]]:
        """
        Html code after base64.
        """
        return pulumi.get(self, "html")

    @html.setter
    def html(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "html", value)

    @property
    @pulumi.getter
    def text(self) -> Optional[pulumi.Input[str]]:
        """
        Text content after base64.
        """
        return pulumi.get(self, "text")

    @text.setter
    def text(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "text", value)


