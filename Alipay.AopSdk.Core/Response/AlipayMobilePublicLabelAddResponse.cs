using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobilePublicLabelAddResponse.
    /// </summary>
    public class AlipayMobilePublicLabelAddResponse : AopResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 标签编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }
    }
}
