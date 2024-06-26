// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tsf.Outputs
{

    [OutputType]
    public sealed class GetRepositoryResultContentResult
    {
        /// <summary>
        /// Repository bucket name. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string BucketName;
        /// <summary>
        /// Repository region. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string BucketRegion;
        /// <summary>
        /// CreationTime. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string CreateTime;
        /// <summary>
        /// Repository Directory. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string Directory;
        /// <summary>
        /// Whether the repository is being used. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly bool IsUsed;
        /// <summary>
        /// Repository description (default warehouse: default, private warehouse: private).
        /// </summary>
        public readonly string RepositoryDesc;
        /// <summary>
        /// repository Id.
        /// </summary>
        public readonly string RepositoryId;
        /// <summary>
        /// Repository Name.
        /// </summary>
        public readonly string RepositoryName;
        /// <summary>
        /// Repository type (default Repository: default, private Repository: private).
        /// </summary>
        public readonly string RepositoryType;

        [OutputConstructor]
        private GetRepositoryResultContentResult(
            string bucketName,

            string bucketRegion,

            string createTime,

            string directory,

            bool isUsed,

            string repositoryDesc,

            string repositoryId,

            string repositoryName,

            string repositoryType)
        {
            BucketName = bucketName;
            BucketRegion = bucketRegion;
            CreateTime = createTime;
            Directory = directory;
            IsUsed = isUsed;
            RepositoryDesc = repositoryDesc;
            RepositoryId = repositoryId;
            RepositoryName = repositoryName;
            RepositoryType = repositoryType;
        }
    }
}
