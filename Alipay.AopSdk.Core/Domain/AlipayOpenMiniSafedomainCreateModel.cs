using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniSafedomainCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniSafedomainCreateModel : AopObject
    {
        /// <summary>
        /// httpRequest域白名单
        /// </summary>
        [Newtonsoft.Json.JsonProperty("safe_domain")]
        public string SafeDomain { get; set; }
    }
}
