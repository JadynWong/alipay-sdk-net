using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicLifeMsgRecallModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicLifeMsgRecallModel : AopObject
    {
        /// <summary>
        /// 消息id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("message_id")]
        public string MessageId { get; set; }
    }
}
