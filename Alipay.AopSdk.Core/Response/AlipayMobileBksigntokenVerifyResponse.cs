using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobileBksigntokenVerifyResponse.
    /// </summary>
    public class AlipayMobileBksigntokenVerifyResponse : AopResponse
    {
        /// <summary>
        /// 返回值创建时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("createtimestamp")]
        public string Createtimestamp { get; set; }

        /// <summary>
        /// 返回值logonId
        /// </summary>
        [Newtonsoft.Json.JsonProperty("loginid")]
        public string Loginid { get; set; }

        /// <summary>
        /// 结果说明
        /// </summary>
        [Newtonsoft.Json.JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 结果状态码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resultcode")]
        public long Resultcode { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 返回值userId
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        public string Userid { get; set; }
    }
}
