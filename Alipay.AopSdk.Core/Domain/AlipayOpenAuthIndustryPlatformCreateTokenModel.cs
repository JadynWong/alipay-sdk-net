using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAuthIndustryPlatformCreateTokenModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAuthIndustryPlatformCreateTokenModel : AopObject
    {
        /// <summary>
        /// isv的appid
        /// </summary>
        [Newtonsoft.Json.JsonProperty("isv_appid")]
        public string IsvAppid { get; set; }

        /// <summary>
        /// auth_mycar_violation
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scope")]
        public string Scope { get; set; }
    }
}
