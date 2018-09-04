using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RegionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RegionInfo : AopObject
    {
        /// <summary>
        /// 地址所属区代码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 地址所属区名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("area_name")]
        public string AreaName { get; set; }

        /// <summary>
        /// 地址所属市代码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 地址所属市名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 地址所属省份代码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 地址所属省份名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("province_name")]
        public string ProvinceName { get; set; }
    }
}
