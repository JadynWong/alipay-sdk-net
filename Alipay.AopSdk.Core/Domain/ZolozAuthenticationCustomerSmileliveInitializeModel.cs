using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZolozAuthenticationCustomerSmileliveInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZolozAuthenticationCustomerSmileliveInitializeModel : AopObject
    {
        /// <summary>
        /// { "apdidToken": "设备指纹", "appName": "应用名称", "appVersion": "应用版本", "bioMetaInfo": "生物信息如2.3.0:3,-4" }
        /// </summary>
        [Newtonsoft.Json.JsonProperty("zimmetainfo")]
        public string Zimmetainfo { get; set; }
    }
}
