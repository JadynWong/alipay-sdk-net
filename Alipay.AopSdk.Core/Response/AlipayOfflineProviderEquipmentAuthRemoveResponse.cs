using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderEquipmentAuthRemoveResponse.
    /// </summary>
    public class AlipayOfflineProviderEquipmentAuthRemoveResponse : AopResponse
    {
        /// <summary>
        /// 被解绑的机具编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 机具厂商PID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_pid")]
        public string MerchantPid { get; set; }
    }
}
