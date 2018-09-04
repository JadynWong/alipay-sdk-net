using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentPromoModifyResponse.
    /// </summary>
    public class KoubeiMarketingCampaignIntelligentPromoModifyResponse : AopResponse
    {
        /// <summary>
        /// 修改后返回的智能活动模型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promo")]
        public IntelligentPromo Promo { get; set; }
    }
}
