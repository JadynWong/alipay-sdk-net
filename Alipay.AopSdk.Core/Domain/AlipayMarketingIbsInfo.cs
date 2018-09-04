using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingIbsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingIbsInfo : AopObject
    {
        /// <summary>
        /// 精度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accuracy")]
        public string Accuracy { get; set; }

        /// <summary>
        /// 海拔
        /// </summary>
        [Newtonsoft.Json.JsonProperty("altitude")]
        public string Altitude { get; set; }

        /// <summary>
        /// 维度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 时间ms
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time")]
        public string Time { get; set; }
    }
}
