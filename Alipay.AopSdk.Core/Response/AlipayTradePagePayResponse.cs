using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradePagePayResponse.
    /// </summary>
    public class AlipayTradePagePayResponse : AopResponse
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 收款支付宝账号对应的支付宝唯一用户号。  以2088开头的纯16位数字
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_no")]
        public string TradeNo { get; set; }
    }
}
