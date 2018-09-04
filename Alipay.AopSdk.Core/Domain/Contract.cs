using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Contract Data Structure.
    /// </summary>
    [Serializable]
    public class Contract : AopObject
    {
        /// <summary>
        /// 合约文本内容
        /// </summary>
        [Newtonsoft.Json.JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// 合约标题
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 合约类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; }
    }
}
