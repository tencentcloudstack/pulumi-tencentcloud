// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tcm
{
    /// <summary>
    /// Provides a resource to create a tcm access_log_config
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Tencentcloud = TencentCloudIAC.PulumiPackage.Tencentcloud;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var accessLogConfig = new Tencentcloud.Tcm.AccessLogConfig("accessLogConfig", new Tencentcloud.Tcm.AccessLogConfigArgs
    ///         {
    ///             Address = "10.0.0.1",
    ///             Cls = new Tencentcloud.Tcm.Inputs.AccessLogConfigClsArgs
    ///             {
    ///                 Enable = false,
    ///             },
    ///             Enable = true,
    ///             EnableServer = true,
    ///             EnableStdout = true,
    ///             Encoding = "JSON",
    ///             Format = @"{
    /// 	""authority"": ""%REQ(:AUTHORITY)%"",
    /// 	""bytes_received"": ""%BYTES_RECEIVED%"",
    /// 	""bytes_sent"": ""%BYTES_SENT%"",
    /// 	""downstream_local_address"": ""%DOWNSTREAM_LOCAL_ADDRESS%"",
    /// 	""downstream_remote_address"": ""%DOWNSTREAM_REMOTE_ADDRESS%"",
    /// 	""duration"": ""%DURATION%"",
    /// 	""istio_policy_status"": ""%DYNAMIC_METADATA(istio.mixer:status)%"",
    /// 	""method"": ""%REQ(:METHOD)%"",
    /// 	""path"": ""%REQ(X-ENVOY-ORIGINAL-PATH?:PATH)%"",
    /// 	""protocol"": ""%PROTOCOL%"",
    /// 	""request_id"": ""%REQ(X-REQUEST-ID)%"",
    /// 	""requested_server_name"": ""%REQUESTED_SERVER_NAME%"",
    /// 	""response_code"": ""%RESPONSE_CODE%"",
    /// 	""response_flags"": ""%RESPONSE_FLAGS%"",
    /// 	""route_name"": ""%ROUTE_NAME%"",
    /// 	""start_time"": ""%START_TIME%"",
    /// 	""upstream_cluster"": ""%UPSTREAM_CLUSTER%"",
    /// 	""upstream_host"": ""%UPSTREAM_HOST%"",
    /// 	""upstream_local_address"": ""%UPSTREAM_LOCAL_ADDRESS%"",
    /// 	""upstream_service_time"": ""%RESP(X-ENVOY-UPSTREAM-SERVICE-TIME)%"",
    /// 	""upstream_transport_failure_reason"": ""%UPSTREAM_TRANSPORT_FAILURE_REASON%"",
    /// 	""user_agent"": ""%REQ(USER-AGENT)%"",
    /// 	""x_forwarded_for"": ""%REQ(X-FORWARDED-FOR)%""
    /// }
    /// 
    /// ",
    ///             MeshName = "mesh-rofjmxxx",
    ///             SelectedRange = new Tencentcloud.Tcm.Inputs.AccessLogConfigSelectedRangeArgs
    ///             {
    ///                 All = true,
    ///             },
    ///             Template = "istio",
    ///         });
    ///         var deleteLogConfig = new Tencentcloud.Tcm.AccessLogConfig("deleteLogConfig", new Tencentcloud.Tcm.AccessLogConfigArgs
    ///         {
    ///             Cls = new Tencentcloud.Tcm.Inputs.AccessLogConfigClsArgs
    ///             {
    ///                 Enable = false,
    ///             },
    ///             EnableServer = false,
    ///             EnableStdout = false,
    ///             MeshName = "mesh-rofjmux7",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// tcm access_log_config can be imported using the mesh_id(mesh_name), e.g.
    /// 
    /// ```sh
    ///  $ pulumi import tencentcloud:Tcm/accessLogConfig:AccessLogConfig access_log_config mesh-rofjmxxx
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Tcm/accessLogConfig:AccessLogConfig")]
    public partial class AccessLogConfig : Pulumi.CustomResource
    {
        /// <summary>
        /// Third party grpc server address.
        /// </summary>
        [Output("address")]
        public Output<string?> Address { get; private set; } = null!;

        /// <summary>
        /// CLS config.
        /// </summary>
        [Output("cls")]
        public Output<Outputs.AccessLogConfigCls?> Cls { get; private set; } = null!;

        /// <summary>
        /// Whether enable log.
        /// </summary>
        [Output("enable")]
        public Output<bool?> Enable { get; private set; } = null!;

        /// <summary>
        /// Whether enable third party grpc server.
        /// </summary>
        [Output("enableServer")]
        public Output<bool?> EnableServer { get; private set; } = null!;

        /// <summary>
        /// Whether enable stdout.
        /// </summary>
        [Output("enableStdout")]
        public Output<bool?> EnableStdout { get; private set; } = null!;

        /// <summary>
        /// Log encoding, TEXT or JSON.
        /// </summary>
        [Output("encoding")]
        public Output<string?> Encoding { get; private set; } = null!;

        /// <summary>
        /// Log format.
        /// </summary>
        [Output("format")]
        public Output<string?> Format { get; private set; } = null!;

        /// <summary>
        /// Mesh ID.
        /// </summary>
        [Output("meshName")]
        public Output<string> MeshName { get; private set; } = null!;

        /// <summary>
        /// Selected range.
        /// </summary>
        [Output("selectedRange")]
        public Output<Outputs.AccessLogConfigSelectedRange?> SelectedRange { get; private set; } = null!;

        /// <summary>
        /// Log template, istio/trace/custome.
        /// </summary>
        [Output("template")]
        public Output<string?> Template { get; private set; } = null!;


        /// <summary>
        /// Create a AccessLogConfig resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AccessLogConfig(string name, AccessLogConfigArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Tcm/accessLogConfig:AccessLogConfig", name, args ?? new AccessLogConfigArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AccessLogConfig(string name, Input<string> id, AccessLogConfigState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Tcm/accessLogConfig:AccessLogConfig", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing AccessLogConfig resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AccessLogConfig Get(string name, Input<string> id, AccessLogConfigState? state = null, CustomResourceOptions? options = null)
        {
            return new AccessLogConfig(name, id, state, options);
        }
    }

    public sealed class AccessLogConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Third party grpc server address.
        /// </summary>
        [Input("address")]
        public Input<string>? Address { get; set; }

        /// <summary>
        /// CLS config.
        /// </summary>
        [Input("cls")]
        public Input<Inputs.AccessLogConfigClsArgs>? Cls { get; set; }

        /// <summary>
        /// Whether enable log.
        /// </summary>
        [Input("enable")]
        public Input<bool>? Enable { get; set; }

        /// <summary>
        /// Whether enable third party grpc server.
        /// </summary>
        [Input("enableServer")]
        public Input<bool>? EnableServer { get; set; }

        /// <summary>
        /// Whether enable stdout.
        /// </summary>
        [Input("enableStdout")]
        public Input<bool>? EnableStdout { get; set; }

        /// <summary>
        /// Log encoding, TEXT or JSON.
        /// </summary>
        [Input("encoding")]
        public Input<string>? Encoding { get; set; }

        /// <summary>
        /// Log format.
        /// </summary>
        [Input("format")]
        public Input<string>? Format { get; set; }

        /// <summary>
        /// Mesh ID.
        /// </summary>
        [Input("meshName", required: true)]
        public Input<string> MeshName { get; set; } = null!;

        /// <summary>
        /// Selected range.
        /// </summary>
        [Input("selectedRange")]
        public Input<Inputs.AccessLogConfigSelectedRangeArgs>? SelectedRange { get; set; }

        /// <summary>
        /// Log template, istio/trace/custome.
        /// </summary>
        [Input("template")]
        public Input<string>? Template { get; set; }

        public AccessLogConfigArgs()
        {
        }
    }

    public sealed class AccessLogConfigState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Third party grpc server address.
        /// </summary>
        [Input("address")]
        public Input<string>? Address { get; set; }

        /// <summary>
        /// CLS config.
        /// </summary>
        [Input("cls")]
        public Input<Inputs.AccessLogConfigClsGetArgs>? Cls { get; set; }

        /// <summary>
        /// Whether enable log.
        /// </summary>
        [Input("enable")]
        public Input<bool>? Enable { get; set; }

        /// <summary>
        /// Whether enable third party grpc server.
        /// </summary>
        [Input("enableServer")]
        public Input<bool>? EnableServer { get; set; }

        /// <summary>
        /// Whether enable stdout.
        /// </summary>
        [Input("enableStdout")]
        public Input<bool>? EnableStdout { get; set; }

        /// <summary>
        /// Log encoding, TEXT or JSON.
        /// </summary>
        [Input("encoding")]
        public Input<string>? Encoding { get; set; }

        /// <summary>
        /// Log format.
        /// </summary>
        [Input("format")]
        public Input<string>? Format { get; set; }

        /// <summary>
        /// Mesh ID.
        /// </summary>
        [Input("meshName")]
        public Input<string>? MeshName { get; set; }

        /// <summary>
        /// Selected range.
        /// </summary>
        [Input("selectedRange")]
        public Input<Inputs.AccessLogConfigSelectedRangeGetArgs>? SelectedRange { get; set; }

        /// <summary>
        /// Log template, istio/trace/custome.
        /// </summary>
        [Input("template")]
        public Input<string>? Template { get; set; }

        public AccessLogConfigState()
        {
        }
    }
}