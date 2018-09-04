using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionAuditstatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionAuditstatusModifyModel : AopObject
    {
        /// <summary>
        /// 小程序版本
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 审核结果描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_memo")]
        public string AuditMemo { get; set; }

        /// <summary>
        /// 审核结果
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_result")]
        public string AuditResult { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
