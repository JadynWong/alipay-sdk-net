using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DishonestyDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DishonestyDetailInfo : AopObject
    {
        /// <summary>
        /// 被执行人行为具体情况
        /// </summary>
        [Newtonsoft.Json.JsonProperty("behavior")]
        public string Behavior { get; set; }

        /// <summary>
        /// 案号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("case_code")]
        public string CaseCode { get; set; }

        /// <summary>
        /// 执行法院
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enforce_court")]
        public string EnforceCourt { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id_number")]
        public string IdNumber { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 被执行人履行情况
        /// </summary>
        [Newtonsoft.Json.JsonProperty("performance")]
        public string Performance { get; set; }

        /// <summary>
        /// 发布日期
        /// </summary>
        [Newtonsoft.Json.JsonProperty("publish_date")]
        public string PublishDate { get; set; }

        /// <summary>
        /// 所在区域
        /// </summary>
        [Newtonsoft.Json.JsonProperty("region")]
        public string Region { get; set; }
    }
}
