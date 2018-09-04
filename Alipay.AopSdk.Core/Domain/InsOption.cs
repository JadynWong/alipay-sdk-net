using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsOption Data Structure.
    /// </summary>
    [Serializable]
    public class InsOption : AopObject
    {
        /// <summary>
        /// 保额key
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coverage")]
        public string Coverage { get; set; }

        /// <summary>
        /// 保额value
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coverage_text")]
        public string CoverageText { get; set; }
    }
}
