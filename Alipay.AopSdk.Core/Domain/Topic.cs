using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Topic Data Structure.
    /// </summary>
    [Serializable]
    public class Topic : AopObject
    {
        /// <summary>
        /// 营销位图片url
        /// </summary>
        [Newtonsoft.Json.JsonProperty("img_url")]
        public string ImgUrl { get; set; }

        /// <summary>
        /// 营销位跳转地址，点击营销位头图跳到的链接url。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("link_url")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 营销位描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 营销位名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 营销位id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("topic_id")]
        public string TopicId { get; set; }

        /// <summary>
        /// 营销位内容列表
        /// </summary>
        [XmlArray("topic_items")]
        [XmlArrayItem("topic_item")]
        public List<TopicItem> TopicItems { get; set; }
    }
}
