using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossBaseProcessSignVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossBaseProcessSignVerifyModel : AopObject
    {
        /// <summary>
        /// 流程唯一ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("puid")]
        public string Puid { get; set; }

        /// <summary>
        /// mnotify签名直接回传
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign_content")]
        public string SignContent { get; set; }
    }
}
