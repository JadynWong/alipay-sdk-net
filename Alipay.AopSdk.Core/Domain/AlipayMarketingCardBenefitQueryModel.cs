using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCardBenefitQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCardBenefitQueryModel : AopObject
    {
        /// <summary>
        /// 权益ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// 会员卡模板ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        public string TemplateId { get; set; }
    }
}
