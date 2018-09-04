using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditSupplychainTradePayModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSupplychainTradePayModel : AopObject
    {
        /// <summary>
        /// 买家信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buyer")]
        public Member Buyer { get; set; }

        /// <summary>
        /// 渠道，TMGXBL：天猫供销保理，TYZBL：通用自保理，TMZBL：天猫自保理
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 业务扩展字段
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_data")]
        public string ExtData { get; set; }

        /// <summary>
        /// 外部订单号，格式：机构ipRoleId_外部订单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 支付金额（单位：元），只支持两位小数点的正数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 幂等编号，用于幂等控制，格式 instIpRoleId_yyyymmddhhmmss_8位uniqId
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sale_pd_code")]
        public string SalePdCode { get; set; }

        /// <summary>
        /// FACTORING：保理，PREPAYMENT：预付融资，CREDITPAY：信任付
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_type")]
        public string TradeType { get; set; }
    }
}
