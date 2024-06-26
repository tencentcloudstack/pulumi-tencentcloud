// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Mps
{
    public static class GetMediaMetaData
    {
        /// <summary>
        /// Use this data source to query detailed information of mps media_meta_data
        /// 
        /// ## Example Usage
        /// 
        /// ### Query the mps media meta data through COS
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
        ///     var @object = Tencentcloud.Cos.GetBucketObject.Invoke(new()
        ///     {
        ///         Bucket = $"keep-bucket-{local.App_id}",
        ///         Key = "/mps-test/test.mov",
        ///     });
        /// 
        ///     var metadata = Tencentcloud.Mps.GetMediaMetaData.Invoke(new()
        ///     {
        ///         InputInfo = new Tencentcloud.Mps.Inputs.GetMediaMetaDataInputInfoInputArgs
        ///         {
        ///             Type = "COS",
        ///             CosInputInfo = new Tencentcloud.Mps.Inputs.GetMediaMetaDataInputInfoCosInputInfoInputArgs
        ///             {
        ///                 Bucket = @object.Apply(getBucketObjectResult =&gt; getBucketObjectResult.Bucket),
        ///                 Region = "%s",
        ///                 Object = @object.Apply(getBucketObjectResult =&gt; getBucketObjectResult.Key),
        ///             },
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetMediaMetaDataResult> InvokeAsync(GetMediaMetaDataArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetMediaMetaDataResult>("tencentcloud:Mps/getMediaMetaData:getMediaMetaData", args ?? new GetMediaMetaDataArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of mps media_meta_data
        /// 
        /// ## Example Usage
        /// 
        /// ### Query the mps media meta data through COS
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
        ///     var @object = Tencentcloud.Cos.GetBucketObject.Invoke(new()
        ///     {
        ///         Bucket = $"keep-bucket-{local.App_id}",
        ///         Key = "/mps-test/test.mov",
        ///     });
        /// 
        ///     var metadata = Tencentcloud.Mps.GetMediaMetaData.Invoke(new()
        ///     {
        ///         InputInfo = new Tencentcloud.Mps.Inputs.GetMediaMetaDataInputInfoInputArgs
        ///         {
        ///             Type = "COS",
        ///             CosInputInfo = new Tencentcloud.Mps.Inputs.GetMediaMetaDataInputInfoCosInputInfoInputArgs
        ///             {
        ///                 Bucket = @object.Apply(getBucketObjectResult =&gt; getBucketObjectResult.Bucket),
        ///                 Region = "%s",
        ///                 Object = @object.Apply(getBucketObjectResult =&gt; getBucketObjectResult.Key),
        ///             },
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetMediaMetaDataResult> Invoke(GetMediaMetaDataInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetMediaMetaDataResult>("tencentcloud:Mps/getMediaMetaData:getMediaMetaData", args ?? new GetMediaMetaDataInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetMediaMetaDataArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Input information of file for metadata getting.
        /// </summary>
        [Input("inputInfo", required: true)]
        public Inputs.GetMediaMetaDataInputInfoArgs InputInfo { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetMediaMetaDataArgs()
        {
        }
        public static new GetMediaMetaDataArgs Empty => new GetMediaMetaDataArgs();
    }

    public sealed class GetMediaMetaDataInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Input information of file for metadata getting.
        /// </summary>
        [Input("inputInfo", required: true)]
        public Input<Inputs.GetMediaMetaDataInputInfoInputArgs> InputInfo { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetMediaMetaDataInvokeArgs()
        {
        }
        public static new GetMediaMetaDataInvokeArgs Empty => new GetMediaMetaDataInvokeArgs();
    }


    [OutputType]
    public sealed class GetMediaMetaDataResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly Outputs.GetMediaMetaDataInputInfoResult InputInfo;
        /// <summary>
        /// Media metadata.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetMediaMetaDataMetaDataResult> MetaDatas;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetMediaMetaDataResult(
            string id,

            Outputs.GetMediaMetaDataInputInfoResult inputInfo,

            ImmutableArray<Outputs.GetMediaMetaDataMetaDataResult> metaDatas,

            string? resultOutputFile)
        {
            Id = id;
            InputInfo = inputInfo;
            MetaDatas = metaDatas;
            ResultOutputFile = resultOutputFile;
        }
    }
}
