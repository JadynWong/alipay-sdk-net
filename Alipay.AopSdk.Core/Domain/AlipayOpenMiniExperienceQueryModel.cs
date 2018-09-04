using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniExperienceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniExperienceQueryModel : AopObject
    {
        /// <summary>
        /// 小程序版本号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_version")]
        public string AppVersion { get; set; }
    }
}
