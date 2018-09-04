using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniVersionBuildQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniVersionBuildQueryModel : AopObject
    {
        /// <summary>
        /// 小程序版本号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_version")]
        public string AppVersion { get; set; }
    }
}
