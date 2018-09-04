using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignActivityOfflineCreateResponse.
    /// </summary>
    public class AlipayMarketingCampaignActivityOfflineCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建成功的活动id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 创建成功的券模版id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prize_id")]
        public string PrizeId { get; set; }
    }
}
