using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IpAddrLbsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IpAddrLbsInfo : AopObject
    {
        /// <summary>
        /// IP地址归属地所以城市
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// IP归属地所在的省
        /// </summary>
        [Newtonsoft.Json.JsonProperty("province")]
        public string Province { get; set; }
    }
}
