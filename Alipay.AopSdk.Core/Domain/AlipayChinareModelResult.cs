using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayChinareModelResult Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayChinareModelResult : AopObject
    {
        /// <summary>
        /// 体检记录id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 规则id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule_id")]
        public string RuleId { get; set; }

        /// <summary>
        /// 核保结果
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule_result")]
        public string RuleResult { get; set; }

        /// <summary>
        /// 交易流水记录id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trans_id")]
        public string TransId { get; set; }
    }
}
