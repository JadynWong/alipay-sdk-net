using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignPrizeAmountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignPrizeAmountQueryModel : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 奖品id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prize_id")]
        public string PrizeId { get; set; }
    }
}
