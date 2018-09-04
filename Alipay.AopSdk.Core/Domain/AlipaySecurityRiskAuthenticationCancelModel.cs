using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskAuthenticationCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskAuthenticationCancelModel : AopObject
    {
        /// <summary>
        /// 身份认证场景信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authentication_scene")]
        public AuthenticationScene AuthenticationScene { get; set; }

        /// <summary>
        /// 业务流水号，与初始化接口保持一致
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务参数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_info")]
        public string BizInfo { get; set; }

        /// <summary>
        /// 身份认证初始化返回token_id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("token_id")]
        public string TokenId { get; set; }
    }
}
