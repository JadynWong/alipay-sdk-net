using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsMerchant Data Structure.
    /// </summary>
    [Serializable]
    public class InsMerchant : AopObject
    {
        /// <summary>
        /// 机构全称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 服务电话
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_phone")]
        public string ServicePhone { get; set; }

        /// <summary>
        /// 机构简称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("short_name")]
        public string ShortName { get; set; }
    }
}
