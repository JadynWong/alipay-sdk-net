using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionAuditApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionAuditApplyModel : AopObject
    {
        /// <summary>
        /// 小程序版本
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
