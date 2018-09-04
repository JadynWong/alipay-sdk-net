using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingDataAntlogmngActivitypagespmCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingDataAntlogmngActivitypagespmCreateModel : AopObject
    {
        /// <summary>
        /// 活动Id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 负责人的工号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("owner")]
        public string Owner { get; set; }

        /// <summary>
        /// spma位
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spma")]
        public string Spma { get; set; }

        /// <summary>
        /// 页面的spmb值code
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spmb")]
        public string Spmb { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 凤蝶页面的url
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        public string Url { get; set; }
    }
}
