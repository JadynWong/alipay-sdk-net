using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherLiteInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherLiteInfo : AopObject
    {
        /// <summary>
        /// 发券时间，格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [Newtonsoft.Json.JsonProperty("send_time")]
        public string SendTime { get; set; }

        /// <summary>
        /// 券状态，可枚举，分别为“可用”(ENABLED)和“不可用”(DISABLED)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 券模板ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 券ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("voucher_id")]
        public string VoucherId { get; set; }
    }
}
