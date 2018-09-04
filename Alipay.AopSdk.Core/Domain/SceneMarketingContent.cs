using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SceneMarketingContent Data Structure.
    /// </summary>
    [Serializable]
    public class SceneMarketingContent : AopObject
    {
        /// <summary>
        /// 美食 娱乐等分类条目
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// 小图标地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 营销图片地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>
        /// 营销内容意义
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meaning")]
        public string Meaning { get; set; }

        /// <summary>
        /// 优惠信息的html格式展示参考
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meaning_desc")]
        public string MeaningDesc { get; set; }

        /// <summary>
        /// 营销内容标签
        /// </summary>
        [XmlArray("tags")]
        [XmlArrayItem("string")]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 限制及特性描述
        /// </summary>
        [XmlArray("tips")]
        [XmlArrayItem("string")]
        public List<string> Tips { get; set; }

        /// <summary>
        /// 营销内容标题
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 营销内容类型，例如优惠好店，商圈特惠
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// 营销内容跳转地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        public string Url { get; set; }
    }
}
