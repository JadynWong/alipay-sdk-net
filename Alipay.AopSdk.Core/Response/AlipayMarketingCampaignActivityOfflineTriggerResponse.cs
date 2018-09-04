using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignActivityOfflineTriggerResponse.
    /// </summary>
    public class AlipayMarketingCampaignActivityOfflineTriggerResponse : AopResponse
    {
        /// <summary>
        /// 外部奖品ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_prize_id")]
        public string OutPrizeId { get; set; }
    }
}
