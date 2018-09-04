using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcoRenthouseOtherAmount Data Structure.
    /// </summary>
    [Serializable]
    public class EcoRenthouseOtherAmount : AopObject
    {
        /// <summary>
        /// 30
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 费用名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 费用单位
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unit")]
        public string Unit { get; set; }
    }
}
