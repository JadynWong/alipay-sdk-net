using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportOfflinepayRecordVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportOfflinepayRecordVerifyModel : AopObject
    {
        /// <summary>
        /// 原始脱机记录信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("record")]
        public string Record { get; set; }
    }
}
