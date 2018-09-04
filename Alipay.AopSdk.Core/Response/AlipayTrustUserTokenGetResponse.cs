using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTrustUserTokenGetResponse.
    /// </summary>
    public class AlipayTrustUserTokenGetResponse : AopResponse
    {
        /// <summary>
        /// 访问令牌
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 本字段已废弃
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }
    }
}
