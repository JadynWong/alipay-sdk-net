using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ModelColumn Data Structure.
    /// </summary>
    [Serializable]
    public class ModelColumn : AopObject
    {
        /// <summary>
        /// 列别名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// 列值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public string Data { get; set; }
    }
}
