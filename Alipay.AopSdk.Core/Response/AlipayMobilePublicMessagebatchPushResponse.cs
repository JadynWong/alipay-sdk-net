using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobilePublicMessagebatchPushResponse.
    /// </summary>
    public class AlipayMobilePublicMessagebatchPushResponse : AopResponse
    {
        /// <summary>
        /// 成功
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 消息ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public string Data { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        public string Msg { get; set; }
    }
}
