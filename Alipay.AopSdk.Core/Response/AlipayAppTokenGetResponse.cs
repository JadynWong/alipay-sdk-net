using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAppTokenGetResponse.
    /// </summary>
    public class AlipayAppTokenGetResponse : AopResponse
    {
        /// <summary>
        /// 应用访问令牌
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_access_token")]
        public string AppAccessToken { get; set; }

        /// <summary>
        /// 应用访问凭证有效时间，单位：秒
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expires_in")]
        public long ExpiresIn { get; set; }
    }
}
