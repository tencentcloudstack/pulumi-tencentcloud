# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = [
    'GetUploadIncrementalInfoResult',
    'AwaitableGetUploadIncrementalInfoResult',
    'get_upload_incremental_info',
    'get_upload_incremental_info_output',
]

@pulumi.output_type
class GetUploadIncrementalInfoResult:
    """
    A collection of values returned by getUploadIncrementalInfo.
    """
    def __init__(__self__, backup_migration_id=None, bucket_name=None, expired_time=None, id=None, incremental_migration_id=None, instance_id=None, path=None, region=None, result_output_file=None, start_time=None, tmp_secret_id=None, tmp_secret_key=None, x_cos_security_token=None):
        if backup_migration_id and not isinstance(backup_migration_id, str):
            raise TypeError("Expected argument 'backup_migration_id' to be a str")
        pulumi.set(__self__, "backup_migration_id", backup_migration_id)
        if bucket_name and not isinstance(bucket_name, str):
            raise TypeError("Expected argument 'bucket_name' to be a str")
        pulumi.set(__self__, "bucket_name", bucket_name)
        if expired_time and not isinstance(expired_time, str):
            raise TypeError("Expected argument 'expired_time' to be a str")
        pulumi.set(__self__, "expired_time", expired_time)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if incremental_migration_id and not isinstance(incremental_migration_id, str):
            raise TypeError("Expected argument 'incremental_migration_id' to be a str")
        pulumi.set(__self__, "incremental_migration_id", incremental_migration_id)
        if instance_id and not isinstance(instance_id, str):
            raise TypeError("Expected argument 'instance_id' to be a str")
        pulumi.set(__self__, "instance_id", instance_id)
        if path and not isinstance(path, str):
            raise TypeError("Expected argument 'path' to be a str")
        pulumi.set(__self__, "path", path)
        if region and not isinstance(region, str):
            raise TypeError("Expected argument 'region' to be a str")
        pulumi.set(__self__, "region", region)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)
        if start_time and not isinstance(start_time, str):
            raise TypeError("Expected argument 'start_time' to be a str")
        pulumi.set(__self__, "start_time", start_time)
        if tmp_secret_id and not isinstance(tmp_secret_id, str):
            raise TypeError("Expected argument 'tmp_secret_id' to be a str")
        pulumi.set(__self__, "tmp_secret_id", tmp_secret_id)
        if tmp_secret_key and not isinstance(tmp_secret_key, str):
            raise TypeError("Expected argument 'tmp_secret_key' to be a str")
        pulumi.set(__self__, "tmp_secret_key", tmp_secret_key)
        if x_cos_security_token and not isinstance(x_cos_security_token, str):
            raise TypeError("Expected argument 'x_cos_security_token' to be a str")
        pulumi.set(__self__, "x_cos_security_token", x_cos_security_token)

    @property
    @pulumi.getter(name="backupMigrationId")
    def backup_migration_id(self) -> str:
        return pulumi.get(self, "backup_migration_id")

    @property
    @pulumi.getter(name="bucketName")
    def bucket_name(self) -> str:
        """
        Bucket name.
        """
        return pulumi.get(self, "bucket_name")

    @property
    @pulumi.getter(name="expiredTime")
    def expired_time(self) -> str:
        """
        Temporary key expiration time.
        """
        return pulumi.get(self, "expired_time")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="incrementalMigrationId")
    def incremental_migration_id(self) -> str:
        return pulumi.get(self, "incremental_migration_id")

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> str:
        return pulumi.get(self, "instance_id")

    @property
    @pulumi.getter
    def path(self) -> str:
        """
        Storage path.
        """
        return pulumi.get(self, "path")

    @property
    @pulumi.getter
    def region(self) -> str:
        """
        Bucket location information.
        """
        return pulumi.get(self, "region")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")

    @property
    @pulumi.getter(name="startTime")
    def start_time(self) -> str:
        """
        Temporary key start time.
        """
        return pulumi.get(self, "start_time")

    @property
    @pulumi.getter(name="tmpSecretId")
    def tmp_secret_id(self) -> str:
        """
        Temporary key ID.
        """
        return pulumi.get(self, "tmp_secret_id")

    @property
    @pulumi.getter(name="tmpSecretKey")
    def tmp_secret_key(self) -> str:
        """
        Temporary key (Key).
        """
        return pulumi.get(self, "tmp_secret_key")

    @property
    @pulumi.getter(name="xCosSecurityToken")
    def x_cos_security_token(self) -> str:
        """
        Temporary key (Token).
        """
        return pulumi.get(self, "x_cos_security_token")


class AwaitableGetUploadIncrementalInfoResult(GetUploadIncrementalInfoResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetUploadIncrementalInfoResult(
            backup_migration_id=self.backup_migration_id,
            bucket_name=self.bucket_name,
            expired_time=self.expired_time,
            id=self.id,
            incremental_migration_id=self.incremental_migration_id,
            instance_id=self.instance_id,
            path=self.path,
            region=self.region,
            result_output_file=self.result_output_file,
            start_time=self.start_time,
            tmp_secret_id=self.tmp_secret_id,
            tmp_secret_key=self.tmp_secret_key,
            x_cos_security_token=self.x_cos_security_token)


def get_upload_incremental_info(backup_migration_id: Optional[str] = None,
                                incremental_migration_id: Optional[str] = None,
                                instance_id: Optional[str] = None,
                                result_output_file: Optional[str] = None,
                                opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetUploadIncrementalInfoResult:
    """
    Use this data source to query detailed information of sqlserver upload_incremental_info

    ## Example Usage

    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    upload_incremental_info = tencentcloud.Sqlserver.get_upload_incremental_info(backup_migration_id="mssql-backup-migration-83t5u3tv",
        incremental_migration_id="mssql-incremental-migration-h36gkdxn",
        instance_id="mssql-4tgeyeeh")
    ```


    :param str backup_migration_id: Backup import task ID, which is returned through the API CreateBackupMigration.
    :param str incremental_migration_id: ID of the incremental import task.
    :param str instance_id: Instance ID.
    :param str result_output_file: Used to save results.
    """
    __args__ = dict()
    __args__['backupMigrationId'] = backup_migration_id
    __args__['incrementalMigrationId'] = incremental_migration_id
    __args__['instanceId'] = instance_id
    __args__['resultOutputFile'] = result_output_file
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
        if opts.plugin_download_url is None:
            opts.plugin_download_url = _utilities.get_plugin_download_url()
    __ret__ = pulumi.runtime.invoke('tencentcloud:Sqlserver/getUploadIncrementalInfo:getUploadIncrementalInfo', __args__, opts=opts, typ=GetUploadIncrementalInfoResult).value

    return AwaitableGetUploadIncrementalInfoResult(
        backup_migration_id=__ret__.backup_migration_id,
        bucket_name=__ret__.bucket_name,
        expired_time=__ret__.expired_time,
        id=__ret__.id,
        incremental_migration_id=__ret__.incremental_migration_id,
        instance_id=__ret__.instance_id,
        path=__ret__.path,
        region=__ret__.region,
        result_output_file=__ret__.result_output_file,
        start_time=__ret__.start_time,
        tmp_secret_id=__ret__.tmp_secret_id,
        tmp_secret_key=__ret__.tmp_secret_key,
        x_cos_security_token=__ret__.x_cos_security_token)


@_utilities.lift_output_func(get_upload_incremental_info)
def get_upload_incremental_info_output(backup_migration_id: Optional[pulumi.Input[str]] = None,
                                       incremental_migration_id: Optional[pulumi.Input[str]] = None,
                                       instance_id: Optional[pulumi.Input[str]] = None,
                                       result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                                       opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetUploadIncrementalInfoResult]:
    """
    Use this data source to query detailed information of sqlserver upload_incremental_info

    ## Example Usage

    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    upload_incremental_info = tencentcloud.Sqlserver.get_upload_incremental_info(backup_migration_id="mssql-backup-migration-83t5u3tv",
        incremental_migration_id="mssql-incremental-migration-h36gkdxn",
        instance_id="mssql-4tgeyeeh")
    ```


    :param str backup_migration_id: Backup import task ID, which is returned through the API CreateBackupMigration.
    :param str incremental_migration_id: ID of the incremental import task.
    :param str instance_id: Instance ID.
    :param str result_output_file: Used to save results.
    """
    ...