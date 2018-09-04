using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAuthTokenAppQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAuthTokenAppQueryModel : AopObject
    {
        /// <summary>
        /// 应用授权令牌
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_auth_token")]
        public string AppAuthToken { get; set; }
    }
}
