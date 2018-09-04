using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ArticleSummaryAnalysisData Data Structure.
    /// </summary>
    [Serializable]
    public class ArticleSummaryAnalysisData : AopObject
    {
        /// <summary>
        /// 人均阅读时长
        /// </summary>
        [Newtonsoft.Json.JsonProperty("avg_read_time")]
        public string AvgReadTime { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date")]
        public string Date { get; set; }

        /// <summary>
        /// 送达人数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deliver_user_cnt")]
        public long DeliverUserCnt { get; set; }

        /// <summary>
        /// 图文曝光人数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expose_user_cnt")]
        public long ExposeUserCnt { get; set; }

        /// <summary>
        /// 点赞数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("praise_user_cnt")]
        public long PraiseUserCnt { get; set; }

        /// <summary>
        /// 图文阅读人数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("read_user_cnt")]
        public long ReadUserCnt { get; set; }

        /// <summary>
        /// 评论数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reply_user_cnt")]
        public long ReplyUserCnt { get; set; }

        /// <summary>
        /// 分享人数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("share_user_cnt")]
        public long ShareUserCnt { get; set; }
    }
}
