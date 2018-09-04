using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAccountExrateTraderequestCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountExrateTraderequestCreateModel : AopObject
    {
        /// <summary>
        /// 交易请求对象内容
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_request")]
        public TradeRequestVO TradeRequest { get; set; }
    }
}
