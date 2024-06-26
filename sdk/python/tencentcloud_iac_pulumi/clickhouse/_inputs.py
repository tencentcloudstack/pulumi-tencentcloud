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
    'AccountPermissionDatabasePrivilegeListArgs',
    'AccountPermissionDatabasePrivilegeListTablePrivilegeListArgs',
    'BackupStrategyDataBackupStrategyArgs',
    'BackupStrategyDataBackupStrategyBackUpTableArgs',
    'BackupStrategyMetaBackupStrategyArgs',
    'InstanceCommonSpecArgs',
    'InstanceDataSpecArgs',
    'KeyvalConfigItemsArgs',
    'XmlConfigModifyConfContextArgs',
]

@pulumi.input_type
class AccountPermissionDatabasePrivilegeListArgs:
    def __init__(__self__, *,
                 database_name: pulumi.Input[str],
                 database_privileges: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 table_privilege_lists: Optional[pulumi.Input[Sequence[pulumi.Input['AccountPermissionDatabasePrivilegeListTablePrivilegeListArgs']]]] = None):
        """
        :param pulumi.Input[str] database_name: Database name.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] database_privileges: Database privileges. Valid valuse: SELECT, INSERT_ALL, ALTER, TRUNCATE, DROP_TABLE, CREATE_TABLE, DROP_DATABASE.
        :param pulumi.Input[Sequence[pulumi.Input['AccountPermissionDatabasePrivilegeListTablePrivilegeListArgs']]] table_privilege_lists: Table privilege list.
        """
        pulumi.set(__self__, "database_name", database_name)
        if database_privileges is not None:
            pulumi.set(__self__, "database_privileges", database_privileges)
        if table_privilege_lists is not None:
            pulumi.set(__self__, "table_privilege_lists", table_privilege_lists)

    @property
    @pulumi.getter(name="databaseName")
    def database_name(self) -> pulumi.Input[str]:
        """
        Database name.
        """
        return pulumi.get(self, "database_name")

    @database_name.setter
    def database_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "database_name", value)

    @property
    @pulumi.getter(name="databasePrivileges")
    def database_privileges(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Database privileges. Valid valuse: SELECT, INSERT_ALL, ALTER, TRUNCATE, DROP_TABLE, CREATE_TABLE, DROP_DATABASE.
        """
        return pulumi.get(self, "database_privileges")

    @database_privileges.setter
    def database_privileges(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "database_privileges", value)

    @property
    @pulumi.getter(name="tablePrivilegeLists")
    def table_privilege_lists(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['AccountPermissionDatabasePrivilegeListTablePrivilegeListArgs']]]]:
        """
        Table privilege list.
        """
        return pulumi.get(self, "table_privilege_lists")

    @table_privilege_lists.setter
    def table_privilege_lists(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['AccountPermissionDatabasePrivilegeListTablePrivilegeListArgs']]]]):
        pulumi.set(self, "table_privilege_lists", value)


@pulumi.input_type
class AccountPermissionDatabasePrivilegeListTablePrivilegeListArgs:
    def __init__(__self__, *,
                 table_name: pulumi.Input[str],
                 table_privileges: pulumi.Input[Sequence[pulumi.Input[str]]]):
        """
        :param pulumi.Input[str] table_name: Table name.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] table_privileges: Table privileges. Valid values: SELECT, INSERT_ALL, ALTER, TRUNCATE, DROP_TABLE.
        """
        pulumi.set(__self__, "table_name", table_name)
        pulumi.set(__self__, "table_privileges", table_privileges)

    @property
    @pulumi.getter(name="tableName")
    def table_name(self) -> pulumi.Input[str]:
        """
        Table name.
        """
        return pulumi.get(self, "table_name")

    @table_name.setter
    def table_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "table_name", value)

    @property
    @pulumi.getter(name="tablePrivileges")
    def table_privileges(self) -> pulumi.Input[Sequence[pulumi.Input[str]]]:
        """
        Table privileges. Valid values: SELECT, INSERT_ALL, ALTER, TRUNCATE, DROP_TABLE.
        """
        return pulumi.get(self, "table_privileges")

    @table_privileges.setter
    def table_privileges(self, value: pulumi.Input[Sequence[pulumi.Input[str]]]):
        pulumi.set(self, "table_privileges", value)


@pulumi.input_type
class BackupStrategyDataBackupStrategyArgs:
    def __init__(__self__, *,
                 back_up_tables: pulumi.Input[Sequence[pulumi.Input['BackupStrategyDataBackupStrategyBackUpTableArgs']]],
                 execute_hour: pulumi.Input[int],
                 retain_days: pulumi.Input[int],
                 week_days: pulumi.Input[str]):
        """
        :param pulumi.Input[Sequence[pulumi.Input['BackupStrategyDataBackupStrategyBackUpTableArgs']]] back_up_tables: Back up the list of tables.
        :param pulumi.Input[int] execute_hour: Execution hour.
        :param pulumi.Input[int] retain_days: Retention days.
        :param pulumi.Input[str] week_days: The day of the week is separated by commas. For example: 2 represents Tuesday.
        """
        pulumi.set(__self__, "back_up_tables", back_up_tables)
        pulumi.set(__self__, "execute_hour", execute_hour)
        pulumi.set(__self__, "retain_days", retain_days)
        pulumi.set(__self__, "week_days", week_days)

    @property
    @pulumi.getter(name="backUpTables")
    def back_up_tables(self) -> pulumi.Input[Sequence[pulumi.Input['BackupStrategyDataBackupStrategyBackUpTableArgs']]]:
        """
        Back up the list of tables.
        """
        return pulumi.get(self, "back_up_tables")

    @back_up_tables.setter
    def back_up_tables(self, value: pulumi.Input[Sequence[pulumi.Input['BackupStrategyDataBackupStrategyBackUpTableArgs']]]):
        pulumi.set(self, "back_up_tables", value)

    @property
    @pulumi.getter(name="executeHour")
    def execute_hour(self) -> pulumi.Input[int]:
        """
        Execution hour.
        """
        return pulumi.get(self, "execute_hour")

    @execute_hour.setter
    def execute_hour(self, value: pulumi.Input[int]):
        pulumi.set(self, "execute_hour", value)

    @property
    @pulumi.getter(name="retainDays")
    def retain_days(self) -> pulumi.Input[int]:
        """
        Retention days.
        """
        return pulumi.get(self, "retain_days")

    @retain_days.setter
    def retain_days(self, value: pulumi.Input[int]):
        pulumi.set(self, "retain_days", value)

    @property
    @pulumi.getter(name="weekDays")
    def week_days(self) -> pulumi.Input[str]:
        """
        The day of the week is separated by commas. For example: 2 represents Tuesday.
        """
        return pulumi.get(self, "week_days")

    @week_days.setter
    def week_days(self, value: pulumi.Input[str]):
        pulumi.set(self, "week_days", value)


@pulumi.input_type
class BackupStrategyDataBackupStrategyBackUpTableArgs:
    def __init__(__self__, *,
                 database: pulumi.Input[str],
                 table: pulumi.Input[str],
                 total_bytes: pulumi.Input[int],
                 ips: Optional[pulumi.Input[str]] = None,
                 rip: Optional[pulumi.Input[str]] = None,
                 v_cluster: Optional[pulumi.Input[str]] = None,
                 zoo_path: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input[str] database: Database.
        :param pulumi.Input[str] table: Table.
        :param pulumi.Input[int] total_bytes: Back up the list of tables.
        :param pulumi.Input[str] ips: Table ip.
        :param pulumi.Input[str] rip: Ip address of cvm.
        :param pulumi.Input[str] v_cluster: Virtual clusters.
        :param pulumi.Input[str] zoo_path: ZK path.
        """
        pulumi.set(__self__, "database", database)
        pulumi.set(__self__, "table", table)
        pulumi.set(__self__, "total_bytes", total_bytes)
        if ips is not None:
            pulumi.set(__self__, "ips", ips)
        if rip is not None:
            pulumi.set(__self__, "rip", rip)
        if v_cluster is not None:
            pulumi.set(__self__, "v_cluster", v_cluster)
        if zoo_path is not None:
            pulumi.set(__self__, "zoo_path", zoo_path)

    @property
    @pulumi.getter
    def database(self) -> pulumi.Input[str]:
        """
        Database.
        """
        return pulumi.get(self, "database")

    @database.setter
    def database(self, value: pulumi.Input[str]):
        pulumi.set(self, "database", value)

    @property
    @pulumi.getter
    def table(self) -> pulumi.Input[str]:
        """
        Table.
        """
        return pulumi.get(self, "table")

    @table.setter
    def table(self, value: pulumi.Input[str]):
        pulumi.set(self, "table", value)

    @property
    @pulumi.getter(name="totalBytes")
    def total_bytes(self) -> pulumi.Input[int]:
        """
        Back up the list of tables.
        """
        return pulumi.get(self, "total_bytes")

    @total_bytes.setter
    def total_bytes(self, value: pulumi.Input[int]):
        pulumi.set(self, "total_bytes", value)

    @property
    @pulumi.getter
    def ips(self) -> Optional[pulumi.Input[str]]:
        """
        Table ip.
        """
        return pulumi.get(self, "ips")

    @ips.setter
    def ips(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "ips", value)

    @property
    @pulumi.getter
    def rip(self) -> Optional[pulumi.Input[str]]:
        """
        Ip address of cvm.
        """
        return pulumi.get(self, "rip")

    @rip.setter
    def rip(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "rip", value)

    @property
    @pulumi.getter(name="vCluster")
    def v_cluster(self) -> Optional[pulumi.Input[str]]:
        """
        Virtual clusters.
        """
        return pulumi.get(self, "v_cluster")

    @v_cluster.setter
    def v_cluster(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "v_cluster", value)

    @property
    @pulumi.getter(name="zooPath")
    def zoo_path(self) -> Optional[pulumi.Input[str]]:
        """
        ZK path.
        """
        return pulumi.get(self, "zoo_path")

    @zoo_path.setter
    def zoo_path(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "zoo_path", value)


@pulumi.input_type
class BackupStrategyMetaBackupStrategyArgs:
    def __init__(__self__, *,
                 execute_hour: Optional[pulumi.Input[int]] = None,
                 retain_days: Optional[pulumi.Input[int]] = None,
                 week_days: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input[int] execute_hour: Execution hour.
        :param pulumi.Input[int] retain_days: Retention days.
        :param pulumi.Input[str] week_days: The day of the week is separated by commas. For example: 2 represents Tuesday.
        """
        if execute_hour is not None:
            pulumi.set(__self__, "execute_hour", execute_hour)
        if retain_days is not None:
            pulumi.set(__self__, "retain_days", retain_days)
        if week_days is not None:
            pulumi.set(__self__, "week_days", week_days)

    @property
    @pulumi.getter(name="executeHour")
    def execute_hour(self) -> Optional[pulumi.Input[int]]:
        """
        Execution hour.
        """
        return pulumi.get(self, "execute_hour")

    @execute_hour.setter
    def execute_hour(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "execute_hour", value)

    @property
    @pulumi.getter(name="retainDays")
    def retain_days(self) -> Optional[pulumi.Input[int]]:
        """
        Retention days.
        """
        return pulumi.get(self, "retain_days")

    @retain_days.setter
    def retain_days(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "retain_days", value)

    @property
    @pulumi.getter(name="weekDays")
    def week_days(self) -> Optional[pulumi.Input[str]]:
        """
        The day of the week is separated by commas. For example: 2 represents Tuesday.
        """
        return pulumi.get(self, "week_days")

    @week_days.setter
    def week_days(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "week_days", value)


@pulumi.input_type
class InstanceCommonSpecArgs:
    def __init__(__self__, *,
                 count: pulumi.Input[int],
                 disk_size: pulumi.Input[int],
                 spec_name: pulumi.Input[str]):
        """
        :param pulumi.Input[int] count: Node count. NOTE: Only support value 3.
        :param pulumi.Input[int] disk_size: Disk size.
        :param pulumi.Input[str] spec_name: Spec name.
        """
        pulumi.set(__self__, "count", count)
        pulumi.set(__self__, "disk_size", disk_size)
        pulumi.set(__self__, "spec_name", spec_name)

    @property
    @pulumi.getter
    def count(self) -> pulumi.Input[int]:
        """
        Node count. NOTE: Only support value 3.
        """
        return pulumi.get(self, "count")

    @count.setter
    def count(self, value: pulumi.Input[int]):
        pulumi.set(self, "count", value)

    @property
    @pulumi.getter(name="diskSize")
    def disk_size(self) -> pulumi.Input[int]:
        """
        Disk size.
        """
        return pulumi.get(self, "disk_size")

    @disk_size.setter
    def disk_size(self, value: pulumi.Input[int]):
        pulumi.set(self, "disk_size", value)

    @property
    @pulumi.getter(name="specName")
    def spec_name(self) -> pulumi.Input[str]:
        """
        Spec name.
        """
        return pulumi.get(self, "spec_name")

    @spec_name.setter
    def spec_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "spec_name", value)


@pulumi.input_type
class InstanceDataSpecArgs:
    def __init__(__self__, *,
                 count: pulumi.Input[int],
                 disk_size: pulumi.Input[int],
                 spec_name: pulumi.Input[str]):
        """
        :param pulumi.Input[int] count: Data spec count.
        :param pulumi.Input[int] disk_size: Disk size.
        :param pulumi.Input[str] spec_name: Spec name.
        """
        pulumi.set(__self__, "count", count)
        pulumi.set(__self__, "disk_size", disk_size)
        pulumi.set(__self__, "spec_name", spec_name)

    @property
    @pulumi.getter
    def count(self) -> pulumi.Input[int]:
        """
        Data spec count.
        """
        return pulumi.get(self, "count")

    @count.setter
    def count(self, value: pulumi.Input[int]):
        pulumi.set(self, "count", value)

    @property
    @pulumi.getter(name="diskSize")
    def disk_size(self) -> pulumi.Input[int]:
        """
        Disk size.
        """
        return pulumi.get(self, "disk_size")

    @disk_size.setter
    def disk_size(self, value: pulumi.Input[int]):
        pulumi.set(self, "disk_size", value)

    @property
    @pulumi.getter(name="specName")
    def spec_name(self) -> pulumi.Input[str]:
        """
        Spec name.
        """
        return pulumi.get(self, "spec_name")

    @spec_name.setter
    def spec_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "spec_name", value)


@pulumi.input_type
class KeyvalConfigItemsArgs:
    def __init__(__self__, *,
                 conf_key: pulumi.Input[str],
                 conf_value: pulumi.Input[str]):
        """
        :param pulumi.Input[str] conf_key: Instance config key.
        :param pulumi.Input[str] conf_value: Instance config value.
        """
        pulumi.set(__self__, "conf_key", conf_key)
        pulumi.set(__self__, "conf_value", conf_value)

    @property
    @pulumi.getter(name="confKey")
    def conf_key(self) -> pulumi.Input[str]:
        """
        Instance config key.
        """
        return pulumi.get(self, "conf_key")

    @conf_key.setter
    def conf_key(self, value: pulumi.Input[str]):
        pulumi.set(self, "conf_key", value)

    @property
    @pulumi.getter(name="confValue")
    def conf_value(self) -> pulumi.Input[str]:
        """
        Instance config value.
        """
        return pulumi.get(self, "conf_value")

    @conf_value.setter
    def conf_value(self, value: pulumi.Input[str]):
        pulumi.set(self, "conf_value", value)


@pulumi.input_type
class XmlConfigModifyConfContextArgs:
    def __init__(__self__, *,
                 file_name: pulumi.Input[str],
                 new_conf_value: pulumi.Input[str],
                 file_path: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input[str] file_name: Configuration file name.
        :param pulumi.Input[str] new_conf_value: New content of configuration file, base64 encoded.
        :param pulumi.Input[str] file_path: Path to save configuration file.
        """
        pulumi.set(__self__, "file_name", file_name)
        pulumi.set(__self__, "new_conf_value", new_conf_value)
        if file_path is not None:
            pulumi.set(__self__, "file_path", file_path)

    @property
    @pulumi.getter(name="fileName")
    def file_name(self) -> pulumi.Input[str]:
        """
        Configuration file name.
        """
        return pulumi.get(self, "file_name")

    @file_name.setter
    def file_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "file_name", value)

    @property
    @pulumi.getter(name="newConfValue")
    def new_conf_value(self) -> pulumi.Input[str]:
        """
        New content of configuration file, base64 encoded.
        """
        return pulumi.get(self, "new_conf_value")

    @new_conf_value.setter
    def new_conf_value(self, value: pulumi.Input[str]):
        pulumi.set(self, "new_conf_value", value)

    @property
    @pulumi.getter(name="filePath")
    def file_path(self) -> Optional[pulumi.Input[str]]:
        """
        Path to save configuration file.
        """
        return pulumi.get(self, "file_path")

    @file_path.setter
    def file_path(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "file_path", value)


