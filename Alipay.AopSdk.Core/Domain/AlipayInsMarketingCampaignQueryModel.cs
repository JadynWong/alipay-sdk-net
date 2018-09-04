using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsMarketingCampaignQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsMarketingCampaignQueryModel : AopObject
    {
        /// <summary>
        /// 保险营销活动Id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// 请求流水Id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_id")]
        public string RequestId { get; set; }
    }
}
