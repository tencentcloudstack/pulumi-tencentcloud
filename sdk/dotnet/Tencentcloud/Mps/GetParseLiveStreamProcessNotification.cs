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
    public static class GetParseLiveStreamProcessNotification
    {
        /// <summary>
        /// Use this data source to query detailed information of mps parse_live_stream_process_notification
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
        ///     var parseLiveStreamProcessNotification = Tencentcloud.Mps.GetParseLiveStreamProcessNotification.Invoke(new()
        ///     {
        ///         Content = "your_content",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetParseLiveStreamProcessNotificationResult> InvokeAsync(GetParseLiveStreamProcessNotificationArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetParseLiveStreamProcessNotificationResult>("tencentcloud:Mps/getParseLiveStreamProcessNotification:getParseLiveStreamProcessNotification", args ?? new GetParseLiveStreamProcessNotificationArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of mps parse_live_stream_process_notification
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
        ///     var parseLiveStreamProcessNotification = Tencentcloud.Mps.GetParseLiveStreamProcessNotification.Invoke(new()
        ///     {
        ///         Content = "your_content",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetParseLiveStreamProcessNotificationResult> Invoke(GetParseLiveStreamProcessNotificationInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetParseLiveStreamProcessNotificationResult>("tencentcloud:Mps/getParseLiveStreamProcessNotification:getParseLiveStreamProcessNotification", args ?? new GetParseLiveStreamProcessNotificationInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetParseLiveStreamProcessNotificationArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Live stream event notification obtained from CMQ.
        /// </summary>
        [Input("content", required: true)]
        public string Content { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetParseLiveStreamProcessNotificationArgs()
        {
        }
        public static new GetParseLiveStreamProcessNotificationArgs Empty => new GetParseLiveStreamProcessNotificationArgs();
    }

    public sealed class GetParseLiveStreamProcessNotificationInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Live stream event notification obtained from CMQ.
        /// </summary>
        [Input("content", required: true)]
        public Input<string> Content { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetParseLiveStreamProcessNotificationInvokeArgs()
        {
        }
        public static new GetParseLiveStreamProcessNotificationInvokeArgs Empty => new GetParseLiveStreamProcessNotificationInvokeArgs();
    }


    [OutputType]
    public sealed class GetParseLiveStreamProcessNotificationResult
    {
        public readonly string Content;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetParseLiveStreamProcessNotificationResult(
            string content,

            string id,

            string? resultOutputFile)
        {
            Content = content;
            Id = id;
            ResultOutputFile = resultOutputFile;
        }
    }
}
