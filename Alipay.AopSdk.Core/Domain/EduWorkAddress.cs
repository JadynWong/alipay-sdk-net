using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EduWorkAddress Data Structure.
    /// </summary>
    [Serializable]
    public class EduWorkAddress : AopObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// 区
        /// </summary>
        [Newtonsoft.Json.JsonProperty("district_name")]
        public string DistrictName { get; set; }

        /// <summary>
        /// 北京市
        /// </summary>
        [Newtonsoft.Json.JsonProperty("province")]
        public string Province { get; set; }

        /// <summary>
        /// 街道
        /// </summary>
        [Newtonsoft.Json.JsonProperty("street_name")]
        public string StreetName { get; set; }
    }
}
