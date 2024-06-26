// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tsf
{
    public static class GetApplicationFileConfig
    {
        /// <summary>
        /// Use this data source to query detailed information of tsf application_file_config
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
        ///     var applicationFileConfig = Tencentcloud.Tsf.GetApplicationFileConfig.Invoke(new()
        ///     {
        ///         ApplicationId = "application-2vzk6n3v",
        ///         ConfigId = "dcfg-f-4y4ekzqv",
        ///         ConfigName = "file-log1",
        ///         ConfigVersion = "1.2",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetApplicationFileConfigResult> InvokeAsync(GetApplicationFileConfigArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetApplicationFileConfigResult>("tencentcloud:Tsf/getApplicationFileConfig:getApplicationFileConfig", args ?? new GetApplicationFileConfigArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of tsf application_file_config
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
        ///     var applicationFileConfig = Tencentcloud.Tsf.GetApplicationFileConfig.Invoke(new()
        ///     {
        ///         ApplicationId = "application-2vzk6n3v",
        ///         ConfigId = "dcfg-f-4y4ekzqv",
        ///         ConfigName = "file-log1",
        ///         ConfigVersion = "1.2",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetApplicationFileConfigResult> Invoke(GetApplicationFileConfigInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetApplicationFileConfigResult>("tencentcloud:Tsf/getApplicationFileConfig:getApplicationFileConfig", args ?? new GetApplicationFileConfigInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetApplicationFileConfigArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Application ID.
        /// </summary>
        [Input("applicationId")]
        public string? ApplicationId { get; set; }

        /// <summary>
        /// Configuration ID.
        /// </summary>
        [Input("configId")]
        public string? ConfigId { get; set; }

        [Input("configIdLists")]
        private List<string>? _configIdLists;

        /// <summary>
        /// List of configuration item ID.
        /// </summary>
        public List<string> ConfigIdLists
        {
            get => _configIdLists ?? (_configIdLists = new List<string>());
            set => _configIdLists = value;
        }

        /// <summary>
        /// Configuration item name.
        /// </summary>
        [Input("configName")]
        public string? ConfigName { get; set; }

        /// <summary>
        /// Configuration item version.
        /// </summary>
        [Input("configVersion")]
        public string? ConfigVersion { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetApplicationFileConfigArgs()
        {
        }
        public static new GetApplicationFileConfigArgs Empty => new GetApplicationFileConfigArgs();
    }

    public sealed class GetApplicationFileConfigInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Application ID.
        /// </summary>
        [Input("applicationId")]
        public Input<string>? ApplicationId { get; set; }

        /// <summary>
        /// Configuration ID.
        /// </summary>
        [Input("configId")]
        public Input<string>? ConfigId { get; set; }

        [Input("configIdLists")]
        private InputList<string>? _configIdLists;

        /// <summary>
        /// List of configuration item ID.
        /// </summary>
        public InputList<string> ConfigIdLists
        {
            get => _configIdLists ?? (_configIdLists = new InputList<string>());
            set => _configIdLists = value;
        }

        /// <summary>
        /// Configuration item name.
        /// </summary>
        [Input("configName")]
        public Input<string>? ConfigName { get; set; }

        /// <summary>
        /// Configuration item version.
        /// </summary>
        [Input("configVersion")]
        public Input<string>? ConfigVersion { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetApplicationFileConfigInvokeArgs()
        {
        }
        public static new GetApplicationFileConfigInvokeArgs Empty => new GetApplicationFileConfigInvokeArgs();
    }


    [OutputType]
    public sealed class GetApplicationFileConfigResult
    {
        /// <summary>
        /// application Id. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string? ApplicationId;
        /// <summary>
        /// Config ID. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string? ConfigId;
        public readonly ImmutableArray<string> ConfigIdLists;
        /// <summary>
        /// Configuration item name. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string? ConfigName;
        /// <summary>
        /// Configuration version. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string? ConfigVersion;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;
        /// <summary>
        /// File configuration item list. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetApplicationFileConfigResultResult> Results;

        [OutputConstructor]
        private GetApplicationFileConfigResult(
            string? applicationId,

            string? configId,

            ImmutableArray<string> configIdLists,

            string? configName,

            string? configVersion,

            string id,

            string? resultOutputFile,

            ImmutableArray<Outputs.GetApplicationFileConfigResultResult> results)
        {
            ApplicationId = applicationId;
            ConfigId = configId;
            ConfigIdLists = configIdLists;
            ConfigName = configName;
            ConfigVersion = configVersion;
            Id = id;
            ResultOutputFile = resultOutputFile;
            Results = results;
        }
    }
}
