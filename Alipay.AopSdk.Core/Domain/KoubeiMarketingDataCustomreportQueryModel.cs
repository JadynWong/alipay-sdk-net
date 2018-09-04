using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingDataCustomreportQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataCustomreportQueryModel : AopObject
    {
        /// <summary>
        /// 规则KEY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("condition_key")]
        public string ConditionKey { get; set; }

        /// <summary>
        /// 额外增加的查询过滤条件
        /// </summary>
        [XmlArray("filter_tags")]
        [XmlArrayItem("filter_tag")]
        public List<FilterTag> FilterTags { get; set; }

        /// <summary>
        /// 一次拉多少条
        /// </summary>
        [Newtonsoft.Json.JsonProperty("max_count")]
        public string MaxCount { get; set; }
    }
}
