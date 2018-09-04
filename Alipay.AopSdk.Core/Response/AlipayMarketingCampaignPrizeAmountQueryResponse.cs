using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignPrizeAmountQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignPrizeAmountQueryResponse : AopResponse
    {
        /// <summary>
        /// 奖品剩余数量，数值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remain_amount")]
        public string RemainAmount { get; set; }
    }
}
