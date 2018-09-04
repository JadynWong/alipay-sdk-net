using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceFileQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceFileQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝端生成的发票id，该字段可从发票详情查询接口获得
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invoice_id")]
        public string InvoiceId { get; set; }
    }
}
