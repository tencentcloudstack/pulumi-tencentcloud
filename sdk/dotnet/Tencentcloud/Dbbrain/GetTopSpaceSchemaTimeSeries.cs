// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Dbbrain
{
    public static class GetTopSpaceSchemaTimeSeries
    {
        /// <summary>
        /// Use this data source to query detailed information of dbbrain top_space_schema_time_series
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var topSpaceSchemaTimeSeries = Output.Create(Tencentcloud.Dbbrain.GetTopSpaceSchemaTimeSeries.InvokeAsync(new Tencentcloud.Dbbrain.GetTopSpaceSchemaTimeSeriesArgs
        ///         {
        ///             EndDate = "%s",
        ///             InstanceId = "%s",
        ///             Product = "mysql",
        ///             SortBy = "DataLength",
        ///             StartDate = "%s",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetTopSpaceSchemaTimeSeriesResult> InvokeAsync(GetTopSpaceSchemaTimeSeriesArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetTopSpaceSchemaTimeSeriesResult>("tencentcloud:Dbbrain/getTopSpaceSchemaTimeSeries:getTopSpaceSchemaTimeSeries", args ?? new GetTopSpaceSchemaTimeSeriesArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of dbbrain top_space_schema_time_series
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var topSpaceSchemaTimeSeries = Output.Create(Tencentcloud.Dbbrain.GetTopSpaceSchemaTimeSeries.InvokeAsync(new Tencentcloud.Dbbrain.GetTopSpaceSchemaTimeSeriesArgs
        ///         {
        ///             EndDate = "%s",
        ///             InstanceId = "%s",
        ///             Product = "mysql",
        ///             SortBy = "DataLength",
        ///             StartDate = "%s",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetTopSpaceSchemaTimeSeriesResult> Invoke(GetTopSpaceSchemaTimeSeriesInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetTopSpaceSchemaTimeSeriesResult>("tencentcloud:Dbbrain/getTopSpaceSchemaTimeSeries:getTopSpaceSchemaTimeSeries", args ?? new GetTopSpaceSchemaTimeSeriesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetTopSpaceSchemaTimeSeriesArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The deadline, such as 2021-01-01, the earliest is the 29th day before the current day, and the default is the current day.
        /// </summary>
        [Input("endDate")]
        public string? EndDate { get; set; }

        /// <summary>
        /// instance id.
        /// </summary>
        [Input("instanceId", required: true)]
        public string InstanceId { get; set; } = null!;

        /// <summary>
        /// The number of Top libraries to return, the maximum value is 100, and the default is 20.
        /// </summary>
        [Input("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Service product type, supported values include: mysql - cloud database MySQL, cynosdb - cloud database CynosDB for MySQL, the default is mysql.
        /// </summary>
        [Input("product")]
        public string? Product { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        /// <summary>
        /// The sorting field used to filter the Top library. The optional fields include DataLength, IndexLength, TotalLength, DataFree, FragRatio, TableRows, and PhysicalFileSize (only supported by ApsaraDB for MySQL instances). The default for ApsaraDB for MySQL instances is PhysicalFileSize, and the default for other product instances is TotalLength.
        /// </summary>
        [Input("sortBy")]
        public string? SortBy { get; set; }

        /// <summary>
        /// The start date, such as 2021-01-01, the earliest is the 29th day before the current day, and the default is the 6th day before the deadline.
        /// </summary>
        [Input("startDate")]
        public string? StartDate { get; set; }

        public GetTopSpaceSchemaTimeSeriesArgs()
        {
        }
    }

    public sealed class GetTopSpaceSchemaTimeSeriesInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The deadline, such as 2021-01-01, the earliest is the 29th day before the current day, and the default is the current day.
        /// </summary>
        [Input("endDate")]
        public Input<string>? EndDate { get; set; }

        /// <summary>
        /// instance id.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        /// <summary>
        /// The number of Top libraries to return, the maximum value is 100, and the default is 20.
        /// </summary>
        [Input("limit")]
        public Input<int>? Limit { get; set; }

        /// <summary>
        /// Service product type, supported values include: mysql - cloud database MySQL, cynosdb - cloud database CynosDB for MySQL, the default is mysql.
        /// </summary>
        [Input("product")]
        public Input<string>? Product { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        /// <summary>
        /// The sorting field used to filter the Top library. The optional fields include DataLength, IndexLength, TotalLength, DataFree, FragRatio, TableRows, and PhysicalFileSize (only supported by ApsaraDB for MySQL instances). The default for ApsaraDB for MySQL instances is PhysicalFileSize, and the default for other product instances is TotalLength.
        /// </summary>
        [Input("sortBy")]
        public Input<string>? SortBy { get; set; }

        /// <summary>
        /// The start date, such as 2021-01-01, the earliest is the 29th day before the current day, and the default is the 6th day before the deadline.
        /// </summary>
        [Input("startDate")]
        public Input<string>? StartDate { get; set; }

        public GetTopSpaceSchemaTimeSeriesInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetTopSpaceSchemaTimeSeriesResult
    {
        public readonly string? EndDate;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceId;
        public readonly int? Limit;
        public readonly string? Product;
        public readonly string? ResultOutputFile;
        public readonly string? SortBy;
        public readonly string? StartDate;
        /// <summary>
        /// The time series data list of the returned top library space statistics.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetTopSpaceSchemaTimeSeriesTopSpaceSchemaTimeSeriesResult> DbbrainTopSpaceSchemaTimeSeries;

        [OutputConstructor]
        private GetTopSpaceSchemaTimeSeriesResult(
            string? endDate,

            string id,

            string instanceId,

            int? limit,

            string? product,

            string? resultOutputFile,

            string? sortBy,

            string? startDate,

            ImmutableArray<Outputs.GetTopSpaceSchemaTimeSeriesTopSpaceSchemaTimeSeriesResult> topSpaceSchemaTimeSeries)
        {
            EndDate = endDate;
            Id = id;
            InstanceId = instanceId;
            Limit = limit;
            Product = product;
            ResultOutputFile = resultOutputFile;
            SortBy = sortBy;
            StartDate = startDate;
            DbbrainTopSpaceSchemaTimeSeries = topSpaceSchemaTimeSeries;
        }
    }
}