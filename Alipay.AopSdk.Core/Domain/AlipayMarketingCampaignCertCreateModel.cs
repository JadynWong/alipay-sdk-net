using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignCertCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignCertCreateModel : AopObject
    {
        /// <summary>
        /// 凭证批次名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 拓展信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Newtonsoft.Json.JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 凭证有效次数，数值(最大为10000)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("valid_count")]
        public string ValidCount { get; set; }
    }
}
