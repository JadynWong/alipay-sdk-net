using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAirXfgDsgModifyResponse.
    /// </summary>
    public class AlipayCommerceAirXfgDsgModifyResponse : AopResponse
    {
        /// <summary>
        /// 用户级别
        /// </summary>
        [Newtonsoft.Json.JsonProperty("level")]
        public string Level { get; set; }
    }
}
