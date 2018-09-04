using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PartnerVO Data Structure.
    /// </summary>
    [Serializable]
    public class PartnerVO : AopObject
    {
        /// <summary>
        /// 生效状态，EFFECTIVE：生效，INVALID：失效。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_status")]
        public string BizStatus { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partner_name")]
        public string PartnerName { get; set; }

        /// <summary>
        /// 商户简码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("short_code")]
        public string ShortCode { get; set; }
    }
}
