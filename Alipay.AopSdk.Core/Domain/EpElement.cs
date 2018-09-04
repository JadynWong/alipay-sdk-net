using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpElement Data Structure.
    /// </summary>
    [Serializable]
    public class EpElement : AopObject
    {
        /// <summary>
        /// 企业征信数据key
        /// </summary>
        [Newtonsoft.Json.JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// 企业征信数据value，字段长度不定。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("value")]
        public string Value { get; set; }
    }
}
