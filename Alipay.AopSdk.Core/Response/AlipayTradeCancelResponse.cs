using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeCancelResponse.
    /// </summary>
    public class AlipayTradeCancelResponse : AopResponse
    {
        /// <summary>
        /// 本次撤销触发的交易动作  close：关闭交易，无退款  refund：产生了退款
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        public string Action { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 是否需要重试
        /// </summary>
        [Newtonsoft.Json.JsonProperty("retry_flag")]
        public string RetryFlag { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_no")]
        public string TradeNo { get; set; }
    }
}
