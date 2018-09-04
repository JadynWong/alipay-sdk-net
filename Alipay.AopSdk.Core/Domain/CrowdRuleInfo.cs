using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CrowdRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CrowdRuleInfo : AopObject
    {
        /// <summary>
        /// 规则描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ruledesc")]
        public string Ruledesc { get; set; }

        /// <summary>
        /// 规则id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ruleid")]
        public string Ruleid { get; set; }

        /// <summary>
        /// 圈人规则的状态
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; }
    }
}
