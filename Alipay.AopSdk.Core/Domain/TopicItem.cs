using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TopicItem Data Structure.
    /// </summary>
    [Serializable]
    public class TopicItem : AopObject
    {
        /// <summary>
        /// 内容图片url, 尺寸为300*300，最大不超过3M，支持格式:.jpg、.png ，请先调用<a href="https://docs.open.alipay.com/api_3/alipay.offline.material.image.upload"> 图片上传接口</a>获得图片url
        /// </summary>
        [Newtonsoft.Json.JsonProperty("img_url")]
        public string ImgUrl { get; set; }

        /// <summary>
        /// 跳转链接，点击营销位内容图片跳到的链接url
        /// </summary>
        [Newtonsoft.Json.JsonProperty("link_url")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 内容说明
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 内容标题
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        public string Title { get; set; }
    }
}
