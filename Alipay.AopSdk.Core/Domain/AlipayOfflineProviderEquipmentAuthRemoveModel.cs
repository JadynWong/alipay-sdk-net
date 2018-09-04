using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderEquipmentAuthRemoveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderEquipmentAuthRemoveModel : AopObject
    {
        /// <summary>
        /// 机具编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 机具类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 扩展信息，传json格式的字符串，包含auth_alipay_card_no =授权的商户支付宝卡号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 机具厂商PID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 操作人名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 操作人ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator_id")]
        public string OperatorId { get; set; }
    }
}
