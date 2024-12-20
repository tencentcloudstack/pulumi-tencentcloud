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
    /// <summary>
    /// Provides a resource to copy object
    /// 
    /// ## Example Usage
    /// 
    /// &lt;!--Start PulumiCodeChooser --&gt;
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Tencentcloud = TencentCloudIAC.PulumiPackage.Tencentcloud;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var objectCopy = new Tencentcloud.Cos.ObjectCopyOperation("objectCopy", new()
    ///     {
    ///         Bucket = "keep-copy-xxxxxxx",
    ///         Key = "copy-acl.txt",
    ///         SourceUrl = "keep-test-xxxxxx.cos.ap-guangzhou.myqcloud.com/acl.txt",
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Cos/objectCopyOperation:ObjectCopyOperation")]
    public partial class ObjectCopyOperation : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Bucket.
        /// </summary>
        [Output("bucket")]
        public Output<string> Bucket { get; private set; } = null!;

        /// <summary>
        /// Object key.
        /// </summary>
        [Output("key")]
        public Output<string> Key { get; private set; } = null!;

        /// <summary>
        /// Source url. In the CDC scenario, the CDC source url is used.
        /// </summary>
        [Output("sourceUrl")]
        public Output<string> SourceUrl { get; private set; } = null!;


        /// <summary>
        /// Create a ObjectCopyOperation resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ObjectCopyOperation(string name, ObjectCopyOperationArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Cos/objectCopyOperation:ObjectCopyOperation", name, args ?? new ObjectCopyOperationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ObjectCopyOperation(string name, Input<string> id, ObjectCopyOperationState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Cos/objectCopyOperation:ObjectCopyOperation", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/tencentcloudstack",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ObjectCopyOperation resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ObjectCopyOperation Get(string name, Input<string> id, ObjectCopyOperationState? state = null, CustomResourceOptions? options = null)
        {
            return new ObjectCopyOperation(name, id, state, options);
        }
    }

    public sealed class ObjectCopyOperationArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Bucket.
        /// </summary>
        [Input("bucket", required: true)]
        public Input<string> Bucket { get; set; } = null!;

        /// <summary>
        /// Object key.
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        /// <summary>
        /// Source url. In the CDC scenario, the CDC source url is used.
        /// </summary>
        [Input("sourceUrl", required: true)]
        public Input<string> SourceUrl { get; set; } = null!;

        public ObjectCopyOperationArgs()
        {
        }
        public static new ObjectCopyOperationArgs Empty => new ObjectCopyOperationArgs();
    }

    public sealed class ObjectCopyOperationState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Bucket.
        /// </summary>
        [Input("bucket")]
        public Input<string>? Bucket { get; set; }

        /// <summary>
        /// Object key.
        /// </summary>
        [Input("key")]
        public Input<string>? Key { get; set; }

        /// <summary>
        /// Source url. In the CDC scenario, the CDC source url is used.
        /// </summary>
        [Input("sourceUrl")]
        public Input<string>? SourceUrl { get; set; }

        public ObjectCopyOperationState()
        {
        }
        public static new ObjectCopyOperationState Empty => new ObjectCopyOperationState();
    }
}
