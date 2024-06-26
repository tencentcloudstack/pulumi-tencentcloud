// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Teo.Outputs
{

    [OutputType]
    public sealed class RealtimeLogDeliveryDeliveryCondition
    {
        /// <summary>
        /// Log filtering conditions, the detailed filtering conditions are as follows: - `EdgeResponseStatusCode`: filter according to the status code returned by the EdgeOne node to the client. Supported operators: `equal`, `great`, `less`, `great_equal`, `less_equal`; Value range: any integer greater than or equal to 0; - `OriginResponseStatusCode`: filter according to the origin response status code. Supported operators: `equal`, `great`, `less`, `great_equal`, `less_equal`; Value range: any integer greater than or equal to -1; - `SecurityAction`: filter according to the final disposal action after the request hits the security rule. Supported operators: `equal`; Optional options are as follows: `-`: unknown/miss; `Monitor`: observe; `JSChallenge`: JavaScript challenge; `Deny`: intercept; `Allow`: allow; `BlockIP`: IP ban; `Redirect`: redirect; `ReturnCustomPage`: return to a custom page; `ManagedChallenge`: managed challenge; `Silence`: silent; `LongDelay`: respond after a long wait; `ShortDelay`: respond after a short wait; -`SecurityModule`: filter according to the name of the security module that finally handles the request. Supported operators: `equal`; Optional options: `-`: unknown/missed; `CustomRule`: Web Protection - Custom Rules; `RateLimitingCustomRule`: Web Protection - Rate Limiting Rules; `ManagedRule`: Web Protection - Managed Rules; `L7DDoS`: Web Protection - CC Attack Protection; `BotManagement`: Bot Management - Bot Basic Management; `BotClientReputation`: Bot Management - Client Profile Analysis; `BotBehaviorAnalysis`: Bot Management - Bot Intelligent Analysis; `BotCustomRule`: Bot Management - Custom Bot Rules; `BotActiveDetection`: Bot Management - Active Feature Recognition.
        /// </summary>
        public readonly ImmutableArray<Outputs.RealtimeLogDeliveryDeliveryConditionCondition> Conditions;

        [OutputConstructor]
        private RealtimeLogDeliveryDeliveryCondition(ImmutableArray<Outputs.RealtimeLogDeliveryDeliveryConditionCondition> conditions)
        {
            Conditions = conditions;
        }
    }
}
