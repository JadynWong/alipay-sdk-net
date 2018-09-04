using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeOrderSettleModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeOrderSettleModel : AopObject
    {
        /// <summary>
        /// 操作员id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 结算请求流水号 开发者自行生成并保证唯一性
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 分账明细信息
        /// </summary>
        [XmlArray("royalty_parameters")]
        [XmlArrayItem("open_api_royalty_detail_info_pojo")]
        public List<OpenApiRoyaltyDetailInfoPojo> RoyaltyParameters { get; set; }

        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_no")]
        public string TradeNo { get; set; }
    }
}
