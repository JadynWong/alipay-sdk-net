using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskHideDeviceidQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskHideDeviceidQueryModel : AopObject
    {
        /// <summary>
        /// 商户的sdk客户端key
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_key_client")]
        public string AppKeyClient { get; set; }

        /// <summary>
        /// 商户使用的设备指纹服务端key
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_key_server")]
        public string AppKeyServer { get; set; }

        /// <summary>
        /// 商户应用名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 设备指纹deviceid对应的token
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deviceid_token")]
        public string DeviceidToken { get; set; }
    }
}
