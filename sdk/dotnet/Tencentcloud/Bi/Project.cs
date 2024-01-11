// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Bi
{
    /// <summary>
    /// Provides a resource to create a bi project
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
    ///         var project = new Tencentcloud.Bi.Project("project", new Tencentcloud.Bi.ProjectArgs
    ///         {
    ///             ColorCode = "#7BD936",
    ///             Logo = "TF-test",
    ///             Mark = "project mark",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// bi project can be imported using the id, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import tencentcloud:Bi/project:Project project project_id
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Bi/project:Project")]
    public partial class Project : Pulumi.CustomResource
    {
        /// <summary>
        /// Logo background color.
        /// </summary>
        [Output("colorCode")]
        public Output<string> ColorCode { get; private set; } = null!;

        /// <summary>
        /// Project logo.
        /// </summary>
        [Output("logo")]
        public Output<string?> Logo { get; private set; } = null!;

        /// <summary>
        /// Remark.
        /// </summary>
        [Output("mark")]
        public Output<string?> Mark { get; private set; } = null!;

        /// <summary>
        /// Project name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;


        /// <summary>
        /// Create a Project resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Project(string name, ProjectArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Bi/project:Project", name, args ?? new ProjectArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Project(string name, Input<string> id, ProjectState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Bi/project:Project", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Project resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Project Get(string name, Input<string> id, ProjectState? state = null, CustomResourceOptions? options = null)
        {
            return new Project(name, id, state, options);
        }
    }

    public sealed class ProjectArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Logo background color.
        /// </summary>
        [Input("colorCode", required: true)]
        public Input<string> ColorCode { get; set; } = null!;

        /// <summary>
        /// Project logo.
        /// </summary>
        [Input("logo")]
        public Input<string>? Logo { get; set; }

        /// <summary>
        /// Remark.
        /// </summary>
        [Input("mark")]
        public Input<string>? Mark { get; set; }

        /// <summary>
        /// Project name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public ProjectArgs()
        {
        }
    }

    public sealed class ProjectState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Logo background color.
        /// </summary>
        [Input("colorCode")]
        public Input<string>? ColorCode { get; set; }

        /// <summary>
        /// Project logo.
        /// </summary>
        [Input("logo")]
        public Input<string>? Logo { get; set; }

        /// <summary>
        /// Remark.
        /// </summary>
        [Input("mark")]
        public Input<string>? Mark { get; set; }

        /// <summary>
        /// Project name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public ProjectState()
        {
        }
    }
}