using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskPolicyConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskPolicyConfirmModel : AopObject
    {
        /// <summary>
        /// 二次确认参数，防止篡改
        /// </summary>
        [Newtonsoft.Json.JsonProperty("confirm_params")]
        public string ConfirmParams { get; set; }

        /// <summary>
        /// 安全请求生成的唯一ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("security_id")]
        public string SecurityId { get; set; }
    }
}
