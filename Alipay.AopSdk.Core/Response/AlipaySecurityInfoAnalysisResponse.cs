using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityInfoAnalysisResponse.
    /// </summary>
    public class AlipaySecurityInfoAnalysisResponse : AopResponse
    {
        /// <summary>
        /// 风险标签
        /// </summary>
        [Newtonsoft.Json.JsonProperty("risk_code")]
        public string RiskCode { get; set; }

        /// <summary>
        /// 风险等级
        /// </summary>
        [Newtonsoft.Json.JsonProperty("risk_level")]
        public long RiskLevel { get; set; }
    }
}
