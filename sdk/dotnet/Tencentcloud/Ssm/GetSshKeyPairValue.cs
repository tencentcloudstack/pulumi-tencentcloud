// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Ssm
{
    public static class GetSshKeyPairValue
    {
        /// <summary>
        /// Use this data source to query detailed information of ssm ssh_key_pair_value
        /// 
        /// &gt; **NOTE:** Must set at least one of `secret_name` or `ssh_key_id`.
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
        ///     var example = Tencentcloud.Ssm.GetSshKeyPairValue.Invoke(new()
        ///     {
        ///         SecretName = "keep_terraform",
        ///         SshKeyId = "skey-2ae2snwd",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// 
        /// ### Or
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
        ///     var example = Tencentcloud.Ssm.GetSshKeyPairValue.Invoke(new()
        ///     {
        ///         SecretName = "keep_terraform",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// 
        /// ### Or
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
        ///     var example = Tencentcloud.Ssm.GetSshKeyPairValue.Invoke(new()
        ///     {
        ///         SshKeyId = "skey-2ae2snwd",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetSshKeyPairValueResult> InvokeAsync(GetSshKeyPairValueArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetSshKeyPairValueResult>("tencentcloud:Ssm/getSshKeyPairValue:getSshKeyPairValue", args ?? new GetSshKeyPairValueArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of ssm ssh_key_pair_value
        /// 
        /// &gt; **NOTE:** Must set at least one of `secret_name` or `ssh_key_id`.
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
        ///     var example = Tencentcloud.Ssm.GetSshKeyPairValue.Invoke(new()
        ///     {
        ///         SecretName = "keep_terraform",
        ///         SshKeyId = "skey-2ae2snwd",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// 
        /// ### Or
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
        ///     var example = Tencentcloud.Ssm.GetSshKeyPairValue.Invoke(new()
        ///     {
        ///         SecretName = "keep_terraform",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// 
        /// ### Or
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
        ///     var example = Tencentcloud.Ssm.GetSshKeyPairValue.Invoke(new()
        ///     {
        ///         SshKeyId = "skey-2ae2snwd",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetSshKeyPairValueResult> Invoke(GetSshKeyPairValueInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetSshKeyPairValueResult>("tencentcloud:Ssm/getSshKeyPairValue:getSshKeyPairValue", args ?? new GetSshKeyPairValueInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetSshKeyPairValueArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        /// <summary>
        /// Secret name.
        /// </summary>
        [Input("secretName")]
        public string? SecretName { get; set; }

        /// <summary>
        /// The key pair ID is the unique identifier of the key pair in the cloud server.
        /// </summary>
        [Input("sshKeyId")]
        public string? SshKeyId { get; set; }

        public GetSshKeyPairValueArgs()
        {
        }
        public static new GetSshKeyPairValueArgs Empty => new GetSshKeyPairValueArgs();
    }

    public sealed class GetSshKeyPairValueInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        /// <summary>
        /// Secret name.
        /// </summary>
        [Input("secretName")]
        public Input<string>? SecretName { get; set; }

        /// <summary>
        /// The key pair ID is the unique identifier of the key pair in the cloud server.
        /// </summary>
        [Input("sshKeyId")]
        public Input<string>? SshKeyId { get; set; }

        public GetSshKeyPairValueInvokeArgs()
        {
        }
        public static new GetSshKeyPairValueInvokeArgs Empty => new GetSshKeyPairValueInvokeArgs();
    }


    [OutputType]
    public sealed class GetSshKeyPairValueResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Private key plain text, encoded using base64.
        /// </summary>
        public readonly string PrivateKey;
        /// <summary>
        /// The project ID to which this key pair belongs.
        /// </summary>
        public readonly int ProjectId;
        /// <summary>
        /// Public key plain text, encoded using base64.
        /// </summary>
        public readonly string PublicKey;
        public readonly string? ResultOutputFile;
        public readonly string SecretName;
        /// <summary>
        /// Description of the SSH key pair. Users can modify the description information of the key pair in the CVM console.
        /// </summary>
        public readonly string SshKeyDescription;
        public readonly string SshKeyId;
        /// <summary>
        /// SSH key name.
        /// </summary>
        public readonly string SshKeyName;

        [OutputConstructor]
        private GetSshKeyPairValueResult(
            string id,

            string privateKey,

            int projectId,

            string publicKey,

            string? resultOutputFile,

            string secretName,

            string sshKeyDescription,

            string sshKeyId,

            string sshKeyName)
        {
            Id = id;
            PrivateKey = privateKey;
            ProjectId = projectId;
            PublicKey = publicKey;
            ResultOutputFile = resultOutputFile;
            SecretName = secretName;
            SshKeyDescription = sshKeyDescription;
            SshKeyId = sshKeyId;
            SshKeyName = sshKeyName;
        }
    }
}
