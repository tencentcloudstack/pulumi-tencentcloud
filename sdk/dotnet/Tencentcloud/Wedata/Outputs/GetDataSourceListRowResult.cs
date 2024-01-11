// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Wedata.Outputs
{

    [OutputType]
    public sealed class GetDataSourceListRowResult
    {
        /// <summary>
        /// Appid.
        /// </summary>
        public readonly int AppId;
        /// <summary>
        /// Has Author.
        /// </summary>
        public readonly bool Author;
        /// <summary>
        /// Datasource AuthorityProjectName.
        /// </summary>
        public readonly string AuthorityProjectName;
        /// <summary>
        /// Datasource AuthorityUserName.
        /// </summary>
        public readonly string AuthorityUserName;
        /// <summary>
        /// Biz params.
        /// </summary>
        public readonly string BizParams;
        /// <summary>
        /// Biz params json string.
        /// </summary>
        public readonly string BizParamsString;
        /// <summary>
        /// Datasource category.
        /// </summary>
        public readonly string Category;
        /// <summary>
        /// Datasource cluster id.
        /// </summary>
        public readonly string ClusterId;
        /// <summary>
        /// Datasource cluster name.
        /// </summary>
        public readonly string ClusterName;
        /// <summary>
        /// CreateTime.
        /// </summary>
        public readonly int CreateTime;
        /// <summary>
        /// DatasourceDataSourceStatus.
        /// </summary>
        public readonly string DataSourceStatus;
        /// <summary>
        /// DatabaseName.
        /// </summary>
        public readonly string DatabaseName;
        /// <summary>
        /// Can Deliver.
        /// </summary>
        public readonly bool Deliver;
        /// <summary>
        /// Description.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Datasource display name.
        /// </summary>
        public readonly string Display;
        /// <summary>
        /// Datasource can Edit.
        /// </summary>
        public readonly bool Edit;
        /// <summary>
        /// ID.
        /// </summary>
        public readonly int Id;
        /// <summary>
        /// Instance.
        /// </summary>
        public readonly string Instance;
        /// <summary>
        /// Datasource ModifiedTime.
        /// </summary>
        public readonly int ModifiedTime;
        /// <summary>
        /// Filter name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Datasource owner account.
        /// </summary>
        public readonly string OwnerAccount;
        /// <summary>
        /// Datasource owner account name.
        /// </summary>
        public readonly string OwnerAccountName;
        /// <summary>
        /// Datasource owner project id.
        /// </summary>
        public readonly string OwnerProjectId;
        /// <summary>
        /// Datasource OwnerProjectIdent.
        /// </summary>
        public readonly string OwnerProjectIdent;
        /// <summary>
        /// Datasource OwnerProjectName.
        /// </summary>
        public readonly string OwnerProjectName;
        /// <summary>
        /// Datasource params.
        /// </summary>
        public readonly string Params;
        /// <summary>
        /// Params json string.
        /// </summary>
        public readonly string ParamsString;
        /// <summary>
        /// Datasource engin cluster region.
        /// </summary>
        public readonly string Region;
        /// <summary>
        /// Datasource show type.
        /// </summary>
        public readonly string ShowType;
        /// <summary>
        /// Datasource status.
        /// </summary>
        public readonly int Status;
        /// <summary>
        /// Datasource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetDataSourceListRowResult(
            int appId,

            bool author,

            string authorityProjectName,

            string authorityUserName,

            string bizParams,

            string bizParamsString,

            string category,

            string clusterId,

            string clusterName,

            int createTime,

            string dataSourceStatus,

            string databaseName,

            bool deliver,

            string description,

            string display,

            bool edit,

            int id,

            string instance,

            int modifiedTime,

            string name,

            string ownerAccount,

            string ownerAccountName,

            string ownerProjectId,

            string ownerProjectIdent,

            string ownerProjectName,

            string @params,

            string paramsString,

            string region,

            string showType,

            int status,

            string type)
        {
            AppId = appId;
            Author = author;
            AuthorityProjectName = authorityProjectName;
            AuthorityUserName = authorityUserName;
            BizParams = bizParams;
            BizParamsString = bizParamsString;
            Category = category;
            ClusterId = clusterId;
            ClusterName = clusterName;
            CreateTime = createTime;
            DataSourceStatus = dataSourceStatus;
            DatabaseName = databaseName;
            Deliver = deliver;
            Description = description;
            Display = display;
            Edit = edit;
            Id = id;
            Instance = instance;
            ModifiedTime = modifiedTime;
            Name = name;
            OwnerAccount = ownerAccount;
            OwnerAccountName = ownerAccountName;
            OwnerProjectId = ownerProjectId;
            OwnerProjectIdent = ownerProjectIdent;
            OwnerProjectName = ownerProjectName;
            Params = @params;
            ParamsString = paramsString;
            Region = region;
            ShowType = showType;
            Status = status;
            Type = type;
        }
    }
}