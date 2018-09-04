using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignCashDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignCashDetailQueryModel : AopObject
    {
        /// <summary>
        /// 要查询的现金红包活动号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crowd_no")]
        public string CrowdNo { get; set; }
    }
}
