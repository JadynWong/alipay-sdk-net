using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommodityBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CommodityBaseInfo : AopObject
    {
        /// <summary>
        /// 服务logo
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 服务备注
        /// </summary>
        [Newtonsoft.Json.JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 服务地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_url")]
        public string ServiceUrl { get; set; }
    }
}
