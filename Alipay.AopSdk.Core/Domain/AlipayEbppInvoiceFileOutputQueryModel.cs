using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceFileOutputQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceFileOutputQueryModel : AopObject
    {
        /// <summary>
        /// 发票代码  字段长度（10-12位）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票号码  字段长度（8-10位）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票pdf文件下载应用场景  固定值－INVOICE_EXPENSE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
