using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneCouponSendResponse.
    /// </summary>
    public class AlipayInsSceneCouponSendResponse : AopResponse
    {
        /// <summary>
        /// 发奖凭证
        /// </summary>
        [Newtonsoft.Json.JsonProperty("certificate")]
        public InsCertificate Certificate { get; set; }

        /// <summary>
        /// 活动ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("compaign_id")]
        public string CompaignId { get; set; }

        /// <summary>
        /// 发奖流水ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("flow_id")]
        public string FlowId { get; set; }

        /// <summary>
        /// 保险产品
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product")]
        public InsProduct Product { get; set; }
    }
}
