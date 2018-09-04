using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniExperienceCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniExperienceCreateModel : AopObject
    {
        /// <summary>
        /// 小程序版本号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_version")]
        public string AppVersion { get; set; }
    }
}
