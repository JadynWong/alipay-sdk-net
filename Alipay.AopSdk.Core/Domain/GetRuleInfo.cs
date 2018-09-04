using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GetRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GetRuleInfo : AopObject
    {
        /// <summary>
        /// 截至时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 发放次数限制
        /// </summary>
        [Newtonsoft.Json.JsonProperty("get_count_limit")]
        public PeriodInfo GetCountLimit { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        public string StartTime { get; set; }
    }
}
