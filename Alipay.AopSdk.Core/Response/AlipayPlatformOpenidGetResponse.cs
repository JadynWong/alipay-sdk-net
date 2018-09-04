using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPlatformOpenidGetResponse.
    /// </summary>
    public class AlipayPlatformOpenidGetResponse : AopResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// id字典，key为userId和老的openId，value为新的openId
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dict")]
        public string Dict { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        public string Msg { get; set; }
    }
}
