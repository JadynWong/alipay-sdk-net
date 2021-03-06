using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCardBenefitCreateResponse.
    /// </summary>
    public class AlipayMarketingCardBenefitCreateResponse : AopResponse
    {
        /// <summary>
        /// 权益ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("benefit_id")]
        public string BenefitId { get; set; }
    }
}
