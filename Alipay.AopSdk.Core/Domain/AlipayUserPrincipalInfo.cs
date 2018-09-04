using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserPrincipalInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserPrincipalInfo : AopObject
    {
        /// <summary>
        /// 用户电子邮箱
        /// </summary>
        [Newtonsoft.Json.JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// 用户的手机号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 支付宝userId
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
