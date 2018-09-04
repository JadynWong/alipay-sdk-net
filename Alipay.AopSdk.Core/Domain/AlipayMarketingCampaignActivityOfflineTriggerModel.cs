using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignActivityOfflineTriggerModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignActivityOfflineTriggerModel : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
