using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketMcommentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketMcommentQueryModel : AopObject
    {
        /// <summary>
        /// 调用途径：  1：当值为ISV表示isv途径调用  2：当值为PROVIDER表示服务商调用
        /// </summary>
        [Newtonsoft.Json.JsonProperty("op_role")]
        public string OpRole { get; set; }

        /// <summary>
        /// 字段涵义：当前交易对应的商户partner_id  仅op_role='PROVIDER'必须传入
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_no")]
        public string TradeNo { get; set; }
    }
}
