using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignCrowdCreateResponse.
    /// </summary>
    public class KoubeiMarketingCampaignCrowdCreateResponse : AopResponse
    {
        /// <summary>
        /// 返回的人群组的唯一标识
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crowd_group_id")]
        public string CrowdGroupId { get; set; }
    }
}
