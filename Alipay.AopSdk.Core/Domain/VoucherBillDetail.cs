using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherBillDetail Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherBillDetail : AopObject
    {
        /// <summary>
        /// 券核销/退款金额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 账单类型(V_USE:支付,V_REFUND:退款)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 交易合作伙伴ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partner_name")]
        public string PartnerName { get; set; }

        /// <summary>
        /// 交易状态(I: 处理中, S: 成功)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_no")]
        public string TradeNo { get; set; }
    }
}
