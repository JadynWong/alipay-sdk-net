using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceDetailOutputQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceDetailOutputQueryModel : AopObject
    {
        /// <summary>
        /// 发票代码  长度限制（10-12位）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票号码  长度限制（8-10位）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 获取发票明细应用场景  固定值：INVOICE_EXPENSE-发票报销
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
