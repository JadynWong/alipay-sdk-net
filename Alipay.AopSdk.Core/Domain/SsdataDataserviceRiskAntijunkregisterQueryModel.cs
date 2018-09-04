using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SsdataDataserviceRiskAntijunkregisterQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class SsdataDataserviceRiskAntijunkregisterQueryModel : AopObject
    {
        /// <summary>
        /// 行为发生时的Apdid值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apdid")]
        public string Apdid { get; set; }

        /// <summary>
        /// 行为发生时的IP值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// 调用服务的商户id ，如果是第三方服务商，需要将其实际的商户id透传过来，如果是普通商户传入自己的appid即可
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 行为发生时的手机号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 风险场景码，不传该参数，则走默认的场景
        /// </summary>
        [Newtonsoft.Json.JsonProperty("risk_code")]
        public string RiskCode { get; set; }

        /// <summary>
        /// 业务场景，不传该参数，则走默认的业务场景
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sys_version")]
        public string SysVersion { get; set; }

        /// <summary>
        /// 行为发生时的UMID值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("umid")]
        public string Umid { get; set; }
    }
}
