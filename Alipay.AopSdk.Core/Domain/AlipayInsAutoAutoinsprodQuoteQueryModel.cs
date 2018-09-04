using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodQuoteQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsAutoAutoinsprodQuoteQueryModel : AopObject
    {
        /// <summary>
        /// 询价ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enquiry_biz_id")]
        public string EnquiryBizId { get; set; }

        /// <summary>
        /// 报价ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("quote_biz_id")]
        public string QuoteBizId { get; set; }
    }
}
