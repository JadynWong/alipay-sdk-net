using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskReconfirmVerificatecallbackSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskReconfirmVerificatecallbackSendModel : AopObject
    {
        /// <summary>
        /// 账号名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account")]
        public string Account { get; set; }

        /// <summary>
        /// 接入的应用编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_code")]
        public string AppCode { get; set; }

        /// <summary>
        /// 额外参数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extend_param")]
        public string ExtendParam { get; set; }

        /// <summary>
        /// 风险识别流水id，为风险识别的标识，不敏感，无需脱敏
        /// </summary>
        [Newtonsoft.Json.JsonProperty("identify_id")]
        public string IdentifyId { get; set; }

        /// <summary>
        /// 核身方式
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reauth_type")]
        public string ReauthType { get; set; }

        /// <summary>
        /// 核身结果
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reconfirm_result")]
        public bool ReconfirmResult { get; set; }

        /// <summary>
        /// 场景对应的编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 设备指纹id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("um_id")]
        public string UmId { get; set; }

        /// <summary>
        /// 采集设备指纹对应的token
        /// </summary>
        [Newtonsoft.Json.JsonProperty("um_id_token")]
        public string UmIdToken { get; set; }

        /// <summary>
        /// 会员ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
