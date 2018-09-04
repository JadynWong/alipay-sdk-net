using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAuthTokenAppResponse.
    /// </summary>
    public class AlipayOpenAuthTokenAppResponse : AopResponse
    {
        /// <summary>
        /// 应用授权令牌
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_auth_token")]
        public string AppAuthToken { get; set; }

        /// <summary>
        /// 刷新令牌
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_refresh_token")]
        public string AppRefreshToken { get; set; }

        /// <summary>
        /// 授权商户的appid
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_app_id")]
        public string AuthAppId { get; set; }

        /// <summary>
        /// 应用授权令牌的有效时间（从接口调用时间作为起始时间），单位到秒
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expires_in")]
        public string ExpiresIn { get; set; }

        /// <summary>
        /// 刷新令牌的有效时间（从接口调用时间作为起始时间），单位到秒
        /// </summary>
        [Newtonsoft.Json.JsonProperty("re_expires_in")]
        public string ReExpiresIn { get; set; }

        /// <summary>
        /// 批量授权换码访问令牌列表
        /// </summary>
        [XmlArray("tokens")]
        [XmlArrayItem("app_token_exchange_sub_element")]
        public List<AppTokenExchangeSubElement> Tokens { get; set; }

        /// <summary>
        /// 授权商户的user_id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
