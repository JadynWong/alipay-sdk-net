using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketingVoucherUseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketingVoucherUseModel : AopObject
    {
        /// <summary>
        /// 约定的扩展参数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 外部活动id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 外部交易信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_trade_info")]
        public VoucherUserExternalTradeInfo ExternalTradeInfo { get; set; }

        /// <summary>
        /// 外部券码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_voucher_code")]
        public string ExternalVoucherCode { get; set; }
    }
}
