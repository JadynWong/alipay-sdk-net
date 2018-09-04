using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsMktFactorDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsMktFactorDTO : AopObject
    {
        /// <summary>
        /// 规则因子
        /// </summary>
        [Newtonsoft.Json.JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// 规则因子值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("value")]
        public string Value { get; set; }
    }
}
