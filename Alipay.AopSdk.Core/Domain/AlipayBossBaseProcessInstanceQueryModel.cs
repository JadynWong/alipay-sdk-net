using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossBaseProcessInstanceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossBaseProcessInstanceQueryModel : AopObject
    {
        /// <summary>
        /// 流程全局唯一ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("puid")]
        public string Puid { get; set; }
    }
}
