using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenPublicMessageContentModifyResponse.
    /// </summary>
    public class AlipayOpenPublicMessageContentModifyResponse : AopResponse
    {
        /// <summary>
        /// 内容id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 内容详情内链url
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content_url")]
        public string ContentUrl { get; set; }
    }
}
