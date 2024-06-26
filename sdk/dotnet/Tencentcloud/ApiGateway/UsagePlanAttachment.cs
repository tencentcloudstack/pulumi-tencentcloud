// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.ApiGateway
{
    /// <summary>
    /// Use this resource to attach API gateway usage plan to service.
    /// 
    /// &gt; **NOTE:** If the `auth_type` parameter of API is not `SECRET`, it cannot be bound access key.
    /// 
    /// ## Example Usage
    /// 
    /// ### Normal creation
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
    ///     var exampleUsagePlan = new Tencentcloud.ApiGateway.UsagePlan("exampleUsagePlan", new()
    ///     {
    ///         UsagePlanName = "tf_example",
    ///         UsagePlanDesc = "desc.",
    ///         MaxRequestNum = 100,
    ///         MaxRequestNumPreSec = 10,
    ///     });
    /// 
    ///     var exampleService = new Tencentcloud.ApiGateway.Service("exampleService", new()
    ///     {
    ///         ServiceName = "tf_example",
    ///         Protocol = "http&amp;https",
    ///         ServiceDesc = "desc.",
    ///         NetTypes = new[]
    ///         {
    ///             "INNER",
    ///             "OUTER",
    ///         },
    ///         IpVersion = "IPv4",
    ///     });
    /// 
    ///     var exampleApi = new Tencentcloud.ApiGateway.Api("exampleApi", new()
    ///     {
    ///         ServiceId = exampleService.Id,
    ///         ApiName = "tf_example",
    ///         ApiDesc = "my hello api update",
    ///         AuthType = "SECRET",
    ///         Protocol = "HTTP",
    ///         EnableCors = true,
    ///         RequestConfigPath = "/user/info",
    ///         RequestConfigMethod = "POST",
    ///         RequestParameters = new[]
    ///         {
    ///             new Tencentcloud.ApiGateway.Inputs.ApiRequestParameterArgs
    ///             {
    ///                 Name = "email",
    ///                 Position = "QUERY",
    ///                 Type = "string",
    ///                 Desc = "desc.",
    ///                 DefaultValue = "test@qq.com",
    ///                 Required = true,
    ///             },
    ///         },
    ///         ServiceConfigType = "HTTP",
    ///         ServiceConfigTimeout = 10,
    ///         ServiceConfigUrl = "http://www.tencent.com",
    ///         ServiceConfigPath = "/user",
    ///         ServiceConfigMethod = "POST",
    ///         ResponseType = "XML",
    ///         ResponseSuccessExample = "&lt;note&gt;success&lt;/note&gt;",
    ///         ResponseFailExample = "&lt;note&gt;fail&lt;/note&gt;",
    ///         ResponseErrorCodes = new[]
    ///         {
    ///             new Tencentcloud.ApiGateway.Inputs.ApiResponseErrorCodeArgs
    ///             {
    ///                 Code = 500,
    ///                 Msg = "system error",
    ///                 Desc = "system error code",
    ///                 ConvertedCode = 5000,
    ///                 NeedConvert = true,
    ///             },
    ///         },
    ///     });
    /// 
    ///     var exampleUsagePlanAttachment = new Tencentcloud.ApiGateway.UsagePlanAttachment("exampleUsagePlanAttachment", new()
    ///     {
    ///         UsagePlanId = exampleUsagePlan.Id,
    ///         ServiceId = exampleService.Id,
    ///         Environment = "release",
    ///         BindType = "API",
    ///         ApiId = exampleApi.Id,
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ### Bind the key to a usage plan
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
    ///     var exampleApiKey = new Tencentcloud.ApiGateway.ApiKey("exampleApiKey", new()
    ///     {
    ///         SecretName = "tf_example",
    ///         Status = "on",
    ///     });
    /// 
    ///     var exampleUsagePlanAttachment = new Tencentcloud.ApiGateway.UsagePlanAttachment("exampleUsagePlanAttachment", new()
    ///     {
    ///         UsagePlanId = tencentcloud_api_gateway_usage_plan.Example.Id,
    ///         ServiceId = tencentcloud_api_gateway_service.Example.Id,
    ///         Environment = "release",
    ///         BindType = "API",
    ///         ApiId = tencentcloud_api_gateway_api.Example.Id,
    ///         AccessKeyIds = new[]
    ///         {
    ///             exampleApiKey.Id,
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ## Import
    /// 
    /// API gateway usage plan attachment can be imported using the id, e.g.
    /// 
    /// ```sh
    /// $ pulumi import tencentcloud:ApiGateway/usagePlanAttachment:UsagePlanAttachment attach_service usagePlan-pe7fbdgn#service-kuqd6xqk#release#API#api-p8gtanvy
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:ApiGateway/usagePlanAttachment:UsagePlanAttachment")]
    public partial class UsagePlanAttachment : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Array of key IDs to be bound.
        /// </summary>
        [Output("accessKeyIds")]
        public Output<ImmutableArray<string>> AccessKeyIds { get; private set; } = null!;

        /// <summary>
        /// ID of the API. This parameter will be required when `bind_type` is `API`.
        /// </summary>
        [Output("apiId")]
        public Output<string?> ApiId { get; private set; } = null!;

        /// <summary>
        /// Binding type. Valid values: `API`, `SERVICE`. Default value is `SERVICE`.
        /// </summary>
        [Output("bindType")]
        public Output<string?> BindType { get; private set; } = null!;

        /// <summary>
        /// The environment to be bound. Valid values: `test`, `prepub`, `release`.
        /// </summary>
        [Output("environment")]
        public Output<string> Environment { get; private set; } = null!;

        /// <summary>
        /// ID of the service.
        /// </summary>
        [Output("serviceId")]
        public Output<string> ServiceId { get; private set; } = null!;

        /// <summary>
        /// ID of the usage plan.
        /// </summary>
        [Output("usagePlanId")]
        public Output<string> UsagePlanId { get; private set; } = null!;


        /// <summary>
        /// Create a UsagePlanAttachment resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public UsagePlanAttachment(string name, UsagePlanAttachmentArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:ApiGateway/usagePlanAttachment:UsagePlanAttachment", name, args ?? new UsagePlanAttachmentArgs(), MakeResourceOptions(options, ""))
        {
        }

        private UsagePlanAttachment(string name, Input<string> id, UsagePlanAttachmentState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:ApiGateway/usagePlanAttachment:UsagePlanAttachment", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing UsagePlanAttachment resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static UsagePlanAttachment Get(string name, Input<string> id, UsagePlanAttachmentState? state = null, CustomResourceOptions? options = null)
        {
            return new UsagePlanAttachment(name, id, state, options);
        }
    }

    public sealed class UsagePlanAttachmentArgs : global::Pulumi.ResourceArgs
    {
        [Input("accessKeyIds")]
        private InputList<string>? _accessKeyIds;

        /// <summary>
        /// Array of key IDs to be bound.
        /// </summary>
        public InputList<string> AccessKeyIds
        {
            get => _accessKeyIds ?? (_accessKeyIds = new InputList<string>());
            set => _accessKeyIds = value;
        }

        /// <summary>
        /// ID of the API. This parameter will be required when `bind_type` is `API`.
        /// </summary>
        [Input("apiId")]
        public Input<string>? ApiId { get; set; }

        /// <summary>
        /// Binding type. Valid values: `API`, `SERVICE`. Default value is `SERVICE`.
        /// </summary>
        [Input("bindType")]
        public Input<string>? BindType { get; set; }

        /// <summary>
        /// The environment to be bound. Valid values: `test`, `prepub`, `release`.
        /// </summary>
        [Input("environment", required: true)]
        public Input<string> Environment { get; set; } = null!;

        /// <summary>
        /// ID of the service.
        /// </summary>
        [Input("serviceId", required: true)]
        public Input<string> ServiceId { get; set; } = null!;

        /// <summary>
        /// ID of the usage plan.
        /// </summary>
        [Input("usagePlanId", required: true)]
        public Input<string> UsagePlanId { get; set; } = null!;

        public UsagePlanAttachmentArgs()
        {
        }
        public static new UsagePlanAttachmentArgs Empty => new UsagePlanAttachmentArgs();
    }

    public sealed class UsagePlanAttachmentState : global::Pulumi.ResourceArgs
    {
        [Input("accessKeyIds")]
        private InputList<string>? _accessKeyIds;

        /// <summary>
        /// Array of key IDs to be bound.
        /// </summary>
        public InputList<string> AccessKeyIds
        {
            get => _accessKeyIds ?? (_accessKeyIds = new InputList<string>());
            set => _accessKeyIds = value;
        }

        /// <summary>
        /// ID of the API. This parameter will be required when `bind_type` is `API`.
        /// </summary>
        [Input("apiId")]
        public Input<string>? ApiId { get; set; }

        /// <summary>
        /// Binding type. Valid values: `API`, `SERVICE`. Default value is `SERVICE`.
        /// </summary>
        [Input("bindType")]
        public Input<string>? BindType { get; set; }

        /// <summary>
        /// The environment to be bound. Valid values: `test`, `prepub`, `release`.
        /// </summary>
        [Input("environment")]
        public Input<string>? Environment { get; set; }

        /// <summary>
        /// ID of the service.
        /// </summary>
        [Input("serviceId")]
        public Input<string>? ServiceId { get; set; }

        /// <summary>
        /// ID of the usage plan.
        /// </summary>
        [Input("usagePlanId")]
        public Input<string>? UsagePlanId { get; set; }

        public UsagePlanAttachmentState()
        {
        }
        public static new UsagePlanAttachmentState Empty => new UsagePlanAttachmentState();
    }
}
