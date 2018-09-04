using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPassCodeAddResponse.
    /// </summary>
    public class AlipayPassCodeAddResponse : AopResponse
    {
        /// <summary>
        /// 成功时返回业务参数
        /// </summary>
        [XmlArray("biz_result")]
        [XmlArrayItem("string")]
        public List<string> BizResult { get; set; }

        /// <summary>
        /// 返回码.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 是否发码成功的标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success")]
        public bool Success { get; set; }
    }
}
