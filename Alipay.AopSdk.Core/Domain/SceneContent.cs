using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SceneContent Data Structure.
    /// </summary>
    [Serializable]
    public class SceneContent : AopObject
    {
        /// <summary>
        /// 文章分类
        /// </summary>
        [Newtonsoft.Json.JsonProperty("article_classify")]
        public long ArticleClassify { get; set; }

        /// <summary>
        /// 文章作者
        /// </summary>
        [Newtonsoft.Json.JsonProperty("author")]
        public string Author { get; set; }

        /// <summary>
        /// 文章id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 文章封面图片
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cover")]
        public string Cover { get; set; }

        /// <summary>
        /// 文章图片列表
        /// </summary>
        [XmlArray("image_list")]
        [XmlArrayItem("string")]
        public List<string> ImageList { get; set; }

        /// <summary>
        /// 生活号id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("public_id")]
        public string PublicId { get; set; }

        /// <summary>
        /// public_name为生活号名称，属于公开信息，无需脱敏
        /// </summary>
        [Newtonsoft.Json.JsonProperty("public_name")]
        public string PublicName { get; set; }

        /// <summary>
        /// 跳转链接
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scheme")]
        public string Scheme { get; set; }

        /// <summary>
        /// 推荐埋点
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scm")]
        public string Scm { get; set; }

        /// <summary>
        /// 文章摘要
        /// </summary>
        [Newtonsoft.Json.JsonProperty("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// 文章标题
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 文章点赞数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_praise_count")]
        public long TotalPraiseCount { get; set; }

        /// <summary>
        /// 文章回复数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_reply_count")]
        public long TotalReplyCount { get; set; }

        /// <summary>
        /// 文章阅读数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_view_count")]
        public long TotalViewCount { get; set; }

        /// <summary>
        /// 文章类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; }
    }
}
