using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SceneMarketingHeader Data Structure.
    /// </summary>
    [Serializable]
    public class SceneMarketingHeader : AopObject
    {
        /// <summary>
        /// 图标地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 子标题
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 简要描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [XmlArray("tags")]
        [XmlArrayItem("string")]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 跳转地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        public string Url { get; set; }
    }
}
