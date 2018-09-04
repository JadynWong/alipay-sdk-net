using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZmWatchListExtendInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ZmWatchListExtendInfo : AopObject
    {
        /// <summary>
        /// 对于这个key的描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 对应的字段名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// 对应的值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("value")]
        public string Value { get; set; }
    }
}
