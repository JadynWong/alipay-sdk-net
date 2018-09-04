using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskMobileactivityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskMobileactivityQueryModel : AopObject
    {
        /// <summary>
        /// 账户绑定手机号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 场景名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 支付宝userId
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
