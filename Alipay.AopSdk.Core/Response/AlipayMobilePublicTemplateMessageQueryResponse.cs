using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobilePublicTemplateMessageQueryResponse.
    /// </summary>
    public class AlipayMobilePublicTemplateMessageQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        public string Result { get; set; }
    }
}
