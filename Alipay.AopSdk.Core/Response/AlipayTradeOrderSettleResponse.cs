using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeOrderSettleResponse.
    /// </summary>
    public class AlipayTradeOrderSettleResponse : AopResponse
    {
        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_no")]
        public string TradeNo { get; set; }
    }
}
