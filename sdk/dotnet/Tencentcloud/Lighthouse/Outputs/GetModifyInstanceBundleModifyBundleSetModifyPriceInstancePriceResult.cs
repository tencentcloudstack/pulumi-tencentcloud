// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Lighthouse.Outputs
{

    [OutputType]
    public sealed class GetModifyInstanceBundleModifyBundleSetModifyPriceInstancePriceResult
    {
        /// <summary>
        /// A monetary unit of price. Value range CNY: RMB. USD: us dollar.
        /// </summary>
        public readonly string Currency;
        /// <summary>
        /// Discount.
        /// </summary>
        public readonly double Discount;
        /// <summary>
        /// Discounted price.
        /// </summary>
        public readonly double DiscountPrice;
        /// <summary>
        /// Original unit price of the package.
        /// </summary>
        public readonly double OriginalBundlePrice;
        /// <summary>
        /// Original price.
        /// </summary>
        public readonly double OriginalPrice;

        [OutputConstructor]
        private GetModifyInstanceBundleModifyBundleSetModifyPriceInstancePriceResult(
            string currency,

            double discount,

            double discountPrice,

            double originalBundlePrice,

            double originalPrice)
        {
            Currency = currency;
            Discount = discount;
            DiscountPrice = discountPrice;
            OriginalBundlePrice = originalBundlePrice;
            OriginalPrice = originalPrice;
        }
    }
}
