using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentPromoCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignIntelligentPromoCreateModel : AopObject
    {
        /// <summary>
        /// 创建营销方案的上下文信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator_context")]
        public PromoOperatorInfo OperatorContext { get; set; }

        /// <summary>
        /// 代表了一次请求，作为业务幂等性控制
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 智能营销活动信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promo")]
        public IntelligentPromo Promo { get; set; }
    }
}
