using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserAnalysisData Data Structure.
    /// </summary>
    [Serializable]
    public class UserAnalysisData : AopObject
    {
        /// <summary>
        /// 取消关注人数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cancel_user_cnt")]
        public string CancelUserCnt { get; set; }

        /// <summary>
        /// 累积关注人数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cumulate_user_cnt")]
        public string CumulateUserCnt { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date")]
        public string Date { get; set; }

        /// <summary>
        /// 净增关注人数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grow_user_cnt")]
        public string GrowUserCnt { get; set; }

        /// <summary>
        /// 新关注人数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("new_user_cnt")]
        public string NewUserCnt { get; set; }
    }
}
