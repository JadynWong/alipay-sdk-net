using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenPublicMessageTotalSendResponse.
    /// </summary>
    public class AlipayOpenPublicMessageTotalSendResponse : AopResponse
    {
        /// <summary>
        /// 消息ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("message_id")]
        public string MessageId { get; set; }
    }
}
