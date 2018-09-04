using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskReconfirmRiskidentifyCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskReconfirmRiskidentifyCertifyModel : AopObject
    {
        /// <summary>
        /// 登录对应的账号名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account")]
        public string Account { get; set; }

        /// <summary>
        /// 接入的应用编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_code")]
        public string AppCode { get; set; }

        /// <summary>
        /// 用户所属公司
        /// </summary>
        [Newtonsoft.Json.JsonProperty("company")]
        public string Company { get; set; }

        /// <summary>
        /// 额外参数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extend_param")]
        public string ExtendParam { get; set; }

        /// <summary>
        /// 具体场景对应的code
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 用户关联的租户id list
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tenant_id_list")]
        public string TenantIdList { get; set; }

        /// <summary>
        /// 设备指纹id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("um_id")]
        public string UmId { get; set; }

        /// <summary>
        /// 采集设备指纹信息对应的token
        /// </summary>
        [Newtonsoft.Json.JsonProperty("um_id_token")]
        public string UmIdToken { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
