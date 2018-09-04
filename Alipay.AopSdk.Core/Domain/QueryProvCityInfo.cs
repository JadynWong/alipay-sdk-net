using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QueryProvCityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class QueryProvCityInfo : AopObject
    {
        /// <summary>
        /// 省市编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adcode")]
        public string Adcode { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }
    }
}
