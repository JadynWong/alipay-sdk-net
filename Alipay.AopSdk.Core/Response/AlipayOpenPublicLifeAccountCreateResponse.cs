using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenPublicLifeAccountCreateResponse.
    /// </summary>
    public class AlipayOpenPublicLifeAccountCreateResponse : AopResponse
    {
        /// <summary>
        /// 过期时间，在过期时间之前需要拿refresh_token重新换取新的token使用
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 生活号id，用于表示此生活号唯一性
        /// </summary>
        [Newtonsoft.Json.JsonProperty("public_id")]
        public string PublicId { get; set; }

        /// <summary>
        /// 刷新令牌，当返回值中过期时间快到了，可以通过此令牌来重新刷新令牌，时间自动延长一年
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// 授权token，通过授权token可以代替已生成的生活号id进行代理操作，例如发送广播等
        /// </summary>
        [Newtonsoft.Json.JsonProperty("token")]
        public string Token { get; set; }
    }
}
