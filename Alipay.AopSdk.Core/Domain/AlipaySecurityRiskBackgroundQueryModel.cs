using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskBackgroundQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskBackgroundQueryModel : AopObject
    {
        /// <summary>
        /// params+用于背调查询的输入信息+用户传入
        /// </summary>
        [Newtonsoft.Json.JsonProperty("params")]
        public string Params { get; set; }

        /// <summary>
        /// partner_name+唯一+作为标识调用者身份的字段+用户填入
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partner_name")]
        public string PartnerName { get; set; }
    }
}
