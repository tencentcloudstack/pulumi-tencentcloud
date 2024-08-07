// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cos
{
    public static class GetBucketMultipartUploads
    {
        /// <summary>
        /// Use this data source to query the COS bucket multipart uploads.
        /// 
        /// ## Example Usage
        /// 
        /// &lt;!--Start PulumiCodeChooser --&gt;
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var cosBucketMultipartUploads = Tencentcloud.Cos.GetBucketMultipartUploads.Invoke(new()
        ///     {
        ///         Bucket = "xxxxxx",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetBucketMultipartUploadsResult> InvokeAsync(GetBucketMultipartUploadsArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetBucketMultipartUploadsResult>("tencentcloud:Cos/getBucketMultipartUploads:getBucketMultipartUploads", args ?? new GetBucketMultipartUploadsArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query the COS bucket multipart uploads.
        /// 
        /// ## Example Usage
        /// 
        /// &lt;!--Start PulumiCodeChooser --&gt;
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var cosBucketMultipartUploads = Tencentcloud.Cos.GetBucketMultipartUploads.Invoke(new()
        ///     {
        ///         Bucket = "xxxxxx",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetBucketMultipartUploadsResult> Invoke(GetBucketMultipartUploadsInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetBucketMultipartUploadsResult>("tencentcloud:Cos/getBucketMultipartUploads:getBucketMultipartUploads", args ?? new GetBucketMultipartUploadsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetBucketMultipartUploadsArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Bucket.
        /// </summary>
        [Input("bucket", required: true)]
        public string Bucket { get; set; } = null!;

        /// <summary>
        /// The delimiter is a symbol, and the Object name contains the Object between the specified prefix and the first occurrence of delimiter characters as a set of elements: common prefix. If there is no prefix, start from the beginning of the path.
        /// </summary>
        [Input("delimiter")]
        public string? Delimiter { get; set; }

        /// <summary>
        /// Specifies the encoding format of the return value. Legal value: url.
        /// </summary>
        [Input("encodingType")]
        public string? EncodingType { get; set; }

        /// <summary>
        /// The returned Object key must be prefixed with Prefix. Note that when using the prefix query, the returned key still contains Prefix.
        /// </summary>
        [Input("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetBucketMultipartUploadsArgs()
        {
        }
        public static new GetBucketMultipartUploadsArgs Empty => new GetBucketMultipartUploadsArgs();
    }

    public sealed class GetBucketMultipartUploadsInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Bucket.
        /// </summary>
        [Input("bucket", required: true)]
        public Input<string> Bucket { get; set; } = null!;

        /// <summary>
        /// The delimiter is a symbol, and the Object name contains the Object between the specified prefix and the first occurrence of delimiter characters as a set of elements: common prefix. If there is no prefix, start from the beginning of the path.
        /// </summary>
        [Input("delimiter")]
        public Input<string>? Delimiter { get; set; }

        /// <summary>
        /// Specifies the encoding format of the return value. Legal value: url.
        /// </summary>
        [Input("encodingType")]
        public Input<string>? EncodingType { get; set; }

        /// <summary>
        /// The returned Object key must be prefixed with Prefix. Note that when using the prefix query, the returned key still contains Prefix.
        /// </summary>
        [Input("prefix")]
        public Input<string>? Prefix { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetBucketMultipartUploadsInvokeArgs()
        {
        }
        public static new GetBucketMultipartUploadsInvokeArgs Empty => new GetBucketMultipartUploadsInvokeArgs();
    }


    [OutputType]
    public sealed class GetBucketMultipartUploadsResult
    {
        public readonly string Bucket;
        public readonly string? Delimiter;
        public readonly string? EncodingType;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? Prefix;
        public readonly string? ResultOutputFile;
        /// <summary>
        /// Information for each Upload.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetBucketMultipartUploadsUploadResult> Uploads;

        [OutputConstructor]
        private GetBucketMultipartUploadsResult(
            string bucket,

            string? delimiter,

            string? encodingType,

            string id,

            string? prefix,

            string? resultOutputFile,

            ImmutableArray<Outputs.GetBucketMultipartUploadsUploadResult> uploads)
        {
            Bucket = bucket;
            Delimiter = delimiter;
            EncodingType = encodingType;
            Id = id;
            Prefix = prefix;
            ResultOutputFile = resultOutputFile;
            Uploads = uploads;
        }
    }
}
