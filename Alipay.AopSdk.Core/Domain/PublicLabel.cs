using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PublicLabel Data Structure.
    /// </summary>
    [Serializable]
    public class PublicLabel : AopObject
    {
        /// <summary>
        /// 标签用户量
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count")]
        public long Count { get; set; }

        /// <summary>
        /// 标签编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }
    }
}
