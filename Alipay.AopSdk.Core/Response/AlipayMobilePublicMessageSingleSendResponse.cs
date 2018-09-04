using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobilePublicMessageSingleSendResponse.
    /// </summary>
    public class AlipayMobilePublicMessageSingleSendResponse : AopResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        public string Msg { get; set; }
    }
}
