using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicMessageContentCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicMessageContentCreateModel : AopObject
    {
        /// <summary>
        /// 活动利益点，图文类型ctype为activity类型时才需要传，最多10个字符
        /// </summary>
        [Newtonsoft.Json.JsonProperty("benefit")]
        public string Benefit { get; set; }

        /// <summary>
        /// 消息正文（支持富文本）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// 是否允许评论 T:允许 F:不允许，默认不允许
        /// </summary>
        [Newtonsoft.Json.JsonProperty("could_comment")]
        public string CouldComment { get; set; }

        /// <summary>
        /// 封面图url, 尺寸为996*450，最大不超过3M，支持格式:.jpg、.png ，请先调用<a href="https://docs.open.alipay.com/api_3/alipay.offline.material.image.upload"> 图片上传接口</a>获得图片url。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cover")]
        public string Cover { get; set; }

        /// <summary>
        /// 图文类型  activity: 活动图文，不填默认普通图文
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ctype")]
        public string Ctype { get; set; }

        /// <summary>
        /// 关键词列表，英文逗号分隔，最多不超过5个
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_tags")]
        public string ExtTags { get; set; }

        /// <summary>
        /// 可预览支付宝账号列表，需要预览时才填写， 英文逗号分隔，最多不超过10个
        /// </summary>
        [Newtonsoft.Json.JsonProperty("login_ids")]
        public string LoginIds { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        public string Title { get; set; }
    }
}
