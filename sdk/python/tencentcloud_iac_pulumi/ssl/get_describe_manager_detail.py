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
    'GetDescribeManagerDetailResult',
    'AwaitableGetDescribeManagerDetailResult',
    'get_describe_manager_detail',
    'get_describe_manager_detail_output',
]

@pulumi.output_type
class GetDescribeManagerDetailResult:
    """
    A collection of values returned by getDescribeManagerDetail.
    """
    def __init__(__self__, company_id=None, company_infos=None, contact_first_name=None, contact_last_name=None, contact_mail=None, contact_phone=None, contact_position=None, create_time=None, expire_time=None, id=None, manager_department=None, manager_first_name=None, manager_id=None, manager_last_name=None, manager_mail=None, manager_phone=None, manager_position=None, result_output_file=None, status=None, verify_time=None):
        if company_id and not isinstance(company_id, int):
            raise TypeError("Expected argument 'company_id' to be a int")
        pulumi.set(__self__, "company_id", company_id)
        if company_infos and not isinstance(company_infos, list):
            raise TypeError("Expected argument 'company_infos' to be a list")
        pulumi.set(__self__, "company_infos", company_infos)
        if contact_first_name and not isinstance(contact_first_name, str):
            raise TypeError("Expected argument 'contact_first_name' to be a str")
        pulumi.set(__self__, "contact_first_name", contact_first_name)
        if contact_last_name and not isinstance(contact_last_name, str):
            raise TypeError("Expected argument 'contact_last_name' to be a str")
        pulumi.set(__self__, "contact_last_name", contact_last_name)
        if contact_mail and not isinstance(contact_mail, str):
            raise TypeError("Expected argument 'contact_mail' to be a str")
        pulumi.set(__self__, "contact_mail", contact_mail)
        if contact_phone and not isinstance(contact_phone, str):
            raise TypeError("Expected argument 'contact_phone' to be a str")
        pulumi.set(__self__, "contact_phone", contact_phone)
        if contact_position and not isinstance(contact_position, str):
            raise TypeError("Expected argument 'contact_position' to be a str")
        pulumi.set(__self__, "contact_position", contact_position)
        if create_time and not isinstance(create_time, str):
            raise TypeError("Expected argument 'create_time' to be a str")
        pulumi.set(__self__, "create_time", create_time)
        if expire_time and not isinstance(expire_time, str):
            raise TypeError("Expected argument 'expire_time' to be a str")
        pulumi.set(__self__, "expire_time", expire_time)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if manager_department and not isinstance(manager_department, str):
            raise TypeError("Expected argument 'manager_department' to be a str")
        pulumi.set(__self__, "manager_department", manager_department)
        if manager_first_name and not isinstance(manager_first_name, str):
            raise TypeError("Expected argument 'manager_first_name' to be a str")
        pulumi.set(__self__, "manager_first_name", manager_first_name)
        if manager_id and not isinstance(manager_id, int):
            raise TypeError("Expected argument 'manager_id' to be a int")
        pulumi.set(__self__, "manager_id", manager_id)
        if manager_last_name and not isinstance(manager_last_name, str):
            raise TypeError("Expected argument 'manager_last_name' to be a str")
        pulumi.set(__self__, "manager_last_name", manager_last_name)
        if manager_mail and not isinstance(manager_mail, str):
            raise TypeError("Expected argument 'manager_mail' to be a str")
        pulumi.set(__self__, "manager_mail", manager_mail)
        if manager_phone and not isinstance(manager_phone, str):
            raise TypeError("Expected argument 'manager_phone' to be a str")
        pulumi.set(__self__, "manager_phone", manager_phone)
        if manager_position and not isinstance(manager_position, str):
            raise TypeError("Expected argument 'manager_position' to be a str")
        pulumi.set(__self__, "manager_position", manager_position)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)
        if status and not isinstance(status, str):
            raise TypeError("Expected argument 'status' to be a str")
        pulumi.set(__self__, "status", status)
        if verify_time and not isinstance(verify_time, str):
            raise TypeError("Expected argument 'verify_time' to be a str")
        pulumi.set(__self__, "verify_time", verify_time)

    @property
    @pulumi.getter(name="companyId")
    def company_id(self) -> int:
        """
        Company ID.
        """
        return pulumi.get(self, "company_id")

    @property
    @pulumi.getter(name="companyInfos")
    def company_infos(self) -> Sequence['outputs.GetDescribeManagerDetailCompanyInfoResult']:
        """
        Manager&amp;#39;s company information.
        """
        return pulumi.get(self, "company_infos")

    @property
    @pulumi.getter(name="contactFirstName")
    def contact_first_name(self) -> str:
        """
        Contact name.
        """
        return pulumi.get(self, "contact_first_name")

    @property
    @pulumi.getter(name="contactLastName")
    def contact_last_name(self) -> str:
        """
        Contact name.
        """
        return pulumi.get(self, "contact_last_name")

    @property
    @pulumi.getter(name="contactMail")
    def contact_mail(self) -> str:
        """
        Contact mailbox.
        """
        return pulumi.get(self, "contact_mail")

    @property
    @pulumi.getter(name="contactPhone")
    def contact_phone(self) -> str:
        """
        contact number.
        """
        return pulumi.get(self, "contact_phone")

    @property
    @pulumi.getter(name="contactPosition")
    def contact_position(self) -> str:
        """
        Contact position.
        """
        return pulumi.get(self, "contact_position")

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> str:
        """
        Creation time.
        """
        return pulumi.get(self, "create_time")

    @property
    @pulumi.getter(name="expireTime")
    def expire_time(self) -> str:
        """
        Verify expiration timeNote: This field may return NULL, indicating that the valid value cannot be obtained.
        """
        return pulumi.get(self, "expire_time")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="managerDepartment")
    def manager_department(self) -> str:
        """
        Administrator department.
        """
        return pulumi.get(self, "manager_department")

    @property
    @pulumi.getter(name="managerFirstName")
    def manager_first_name(self) -> str:
        """
        Manager name.
        """
        return pulumi.get(self, "manager_first_name")

    @property
    @pulumi.getter(name="managerId")
    def manager_id(self) -> int:
        return pulumi.get(self, "manager_id")

    @property
    @pulumi.getter(name="managerLastName")
    def manager_last_name(self) -> str:
        """
        Manager name.
        """
        return pulumi.get(self, "manager_last_name")

    @property
    @pulumi.getter(name="managerMail")
    def manager_mail(self) -> str:
        """
        Manager mailbox.
        """
        return pulumi.get(self, "manager_mail")

    @property
    @pulumi.getter(name="managerPhone")
    def manager_phone(self) -> str:
        """
        Manager phone call.
        """
        return pulumi.get(self, "manager_phone")

    @property
    @pulumi.getter(name="managerPosition")
    def manager_position(self) -> str:
        """
        Manager position.
        """
        return pulumi.get(self, "manager_position")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")

    @property
    @pulumi.getter
    def status(self) -> str:
        """
        Status: Audit: OK during the review: review passed inValid: expired expiRing: is about to expire Expired: expired.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter(name="verifyTime")
    def verify_time(self) -> str:
        """
        Verify timeNote: This field may return NULL, indicating that the valid value cannot be obtained.
        """
        return pulumi.get(self, "verify_time")


class AwaitableGetDescribeManagerDetailResult(GetDescribeManagerDetailResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetDescribeManagerDetailResult(
            company_id=self.company_id,
            company_infos=self.company_infos,
            contact_first_name=self.contact_first_name,
            contact_last_name=self.contact_last_name,
            contact_mail=self.contact_mail,
            contact_phone=self.contact_phone,
            contact_position=self.contact_position,
            create_time=self.create_time,
            expire_time=self.expire_time,
            id=self.id,
            manager_department=self.manager_department,
            manager_first_name=self.manager_first_name,
            manager_id=self.manager_id,
            manager_last_name=self.manager_last_name,
            manager_mail=self.manager_mail,
            manager_phone=self.manager_phone,
            manager_position=self.manager_position,
            result_output_file=self.result_output_file,
            status=self.status,
            verify_time=self.verify_time)


def get_describe_manager_detail(manager_id: Optional[int] = None,
                                result_output_file: Optional[str] = None,
                                opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetDescribeManagerDetailResult:
    """
    Use this data source to query detailed information of ssl describe_manager_detail

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    describe_manager_detail = tencentcloud.Ssl.get_describe_manager_detail(manager_id="")
    ```
    <!--End PulumiCodeChooser -->


    :param int manager_id: Manager ID.
    :param str result_output_file: Used to save results.
    """
    __args__ = dict()
    __args__['managerId'] = manager_id
    __args__['resultOutputFile'] = result_output_file
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Ssl/getDescribeManagerDetail:getDescribeManagerDetail', __args__, opts=opts, typ=GetDescribeManagerDetailResult).value

    return AwaitableGetDescribeManagerDetailResult(
        company_id=pulumi.get(__ret__, 'company_id'),
        company_infos=pulumi.get(__ret__, 'company_infos'),
        contact_first_name=pulumi.get(__ret__, 'contact_first_name'),
        contact_last_name=pulumi.get(__ret__, 'contact_last_name'),
        contact_mail=pulumi.get(__ret__, 'contact_mail'),
        contact_phone=pulumi.get(__ret__, 'contact_phone'),
        contact_position=pulumi.get(__ret__, 'contact_position'),
        create_time=pulumi.get(__ret__, 'create_time'),
        expire_time=pulumi.get(__ret__, 'expire_time'),
        id=pulumi.get(__ret__, 'id'),
        manager_department=pulumi.get(__ret__, 'manager_department'),
        manager_first_name=pulumi.get(__ret__, 'manager_first_name'),
        manager_id=pulumi.get(__ret__, 'manager_id'),
        manager_last_name=pulumi.get(__ret__, 'manager_last_name'),
        manager_mail=pulumi.get(__ret__, 'manager_mail'),
        manager_phone=pulumi.get(__ret__, 'manager_phone'),
        manager_position=pulumi.get(__ret__, 'manager_position'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'),
        status=pulumi.get(__ret__, 'status'),
        verify_time=pulumi.get(__ret__, 'verify_time'))


@_utilities.lift_output_func(get_describe_manager_detail)
def get_describe_manager_detail_output(manager_id: Optional[pulumi.Input[int]] = None,
                                       result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                                       opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetDescribeManagerDetailResult]:
    """
    Use this data source to query detailed information of ssl describe_manager_detail

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    describe_manager_detail = tencentcloud.Ssl.get_describe_manager_detail(manager_id="")
    ```
    <!--End PulumiCodeChooser -->


    :param int manager_id: Manager ID.
    :param str result_output_file: Used to save results.
    """
    ...
