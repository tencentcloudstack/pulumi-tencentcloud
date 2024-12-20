// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Mps.Outputs
{

    [OutputType]
    public sealed class FlowInputGroupSrtSettings
    {
        /// <summary>
        /// Delay, default 0, unit ms, range [0, 3000].
        /// </summary>
        public readonly int? Latency;
        /// <summary>
        /// SRT mode, optional [LISTENER|CALLER], default is LISTENER.
        /// </summary>
        public readonly string? Mode;
        /// <summary>
        /// The decryption key, which is empty by default, means no encryption. Only ascii code values can be filled in, and the length is [10, 79].
        /// </summary>
        public readonly string? Passphrase;
        /// <summary>
        /// Key length, default is 0, optional [0|16|24|32].
        /// </summary>
        public readonly int? PbKeyLen;
        /// <summary>
        /// Peer timeout, default is 5000, unit ms, range is [1000, 10000].
        /// </summary>
        public readonly int? PeerIdleTimeout;
        /// <summary>
        /// Peer delay, the default is 0, the unit is ms, and the range is [0, 3000].
        /// </summary>
        public readonly int? PeerLatency;
        /// <summary>
        /// Receiving delay, default is 120, unit ms, range is [0, 3000].
        /// </summary>
        public readonly int? RecvLatency;
        /// <summary>
        /// SRT peer address, required when Mode is CALLER, and only 1 set can be filled in.
        /// </summary>
        public readonly ImmutableArray<Outputs.FlowInputGroupSrtSettingsSourceAddress> SourceAddresses;
        /// <summary>
        /// Stream ID, optional uppercase and lowercase letters, numbers and special characters (.#!:&amp;amp;,=_-), length 0~512. For specific format, please refer to:https://github.com/Haivision/srt/blob/master/docs/features/access-control.md#standard-keys.
        /// </summary>
        public readonly string? StreamId;

        [OutputConstructor]
        private FlowInputGroupSrtSettings(
            int? latency,

            string? mode,

            string? passphrase,

            int? pbKeyLen,

            int? peerIdleTimeout,

            int? peerLatency,

            int? recvLatency,

            ImmutableArray<Outputs.FlowInputGroupSrtSettingsSourceAddress> sourceAddresses,

            string? streamId)
        {
            Latency = latency;
            Mode = mode;
            Passphrase = passphrase;
            PbKeyLen = pbKeyLen;
            PeerIdleTimeout = peerIdleTimeout;
            PeerLatency = peerLatency;
            RecvLatency = recvLatency;
            SourceAddresses = sourceAddresses;
            StreamId = streamId;
        }
    }
}
