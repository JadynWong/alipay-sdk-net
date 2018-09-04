using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Retailer Data Structure.
    /// </summary>
    [Serializable]
    public class Retailer : AopObject
    {
        /// <summary>
        /// 零售商名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 零售商pid
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partner_id")]
        public string PartnerId { get; set; }
    }
}
