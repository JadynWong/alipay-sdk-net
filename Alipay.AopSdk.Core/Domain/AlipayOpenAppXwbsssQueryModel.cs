using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppXwbsssQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppXwbsssQueryModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("a")]
        public string A { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("b")]
        public string B { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlArray("c")]
        [XmlArrayItem("number")]
        public List<long> C { get; set; }

        /// <summary>
        /// 描述描述描述描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effect_date")]
        public string EffectDate { get; set; }
    }
}
