using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ModelQueryParam Data Structure.
    /// </summary>
    [Serializable]
    public class ModelQueryParam : AopObject
    {
        /// <summary>
        /// 条件查询参数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// 操作计算符，目前仅支持EQ
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operate")]
        public string Operate { get; set; }

        /// <summary>
        /// 查询参数值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("value")]
        public string Value { get; set; }
    }
}
