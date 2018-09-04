using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicTopicDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicTopicDeleteModel : AopObject
    {
        /// <summary>
        /// 营销位id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("topic_id")]
        public string TopicId { get; set; }
    }
}
