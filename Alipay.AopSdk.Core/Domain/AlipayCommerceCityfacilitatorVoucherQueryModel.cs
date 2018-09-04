using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorVoucherQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorVoucherQueryModel : AopObject
    {
        /// <summary>
        /// 城市标准码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 8位核销码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ticket_no")]
        public string TicketNo { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_no")]
        public string TradeNo { get; set; }
    }
}
