using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentPromoDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignIntelligentPromoDeleteModel : AopObject
    {
        /// <summary>
        /// 操作下架的操作人信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator_context")]
        public PromoOperatorInfo OperatorContext { get; set; }

        /// <summary>
        /// 代表了一次请求，作为业务幂等性控制
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 智能营销活动的id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promo_id")]
        public string PromoId { get; set; }
    }
}
