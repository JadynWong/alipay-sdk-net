using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenPublicTopicCreateResponse.
    /// </summary>
    public class AlipayOpenPublicTopicCreateResponse : AopResponse
    {
        /// <summary>
        /// 营销位id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("topic_id")]
        public string TopicId { get; set; }
    }
}
