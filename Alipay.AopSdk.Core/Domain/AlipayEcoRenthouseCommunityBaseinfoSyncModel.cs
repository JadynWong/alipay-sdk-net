using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoRenthouseCommunityBaseinfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoRenthouseCommunityBaseinfoSyncModel : AopObject
    {
        /// <summary>
        /// 商圈编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bus_code")]
        public string BusCode { get; set; }

        /// <summary>
        /// 商圈所在纬度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bus_lat")]
        public string BusLat { get; set; }

        /// <summary>
        /// 商圈所在经度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bus_lng")]
        public string BusLng { get; set; }

        /// <summary>
        /// 商圈名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bus_name")]
        public string BusName { get; set; }

        /// <summary>
        /// 商圈覆盖半径(单位:米)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bus_radius")]
        public long BusRadius { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 城市所在纬度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city_lat")]
        public string CityLat { get; set; }

        /// <summary>
        /// 城市所在经度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city_lng")]
        public string CityLng { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 小区/大楼编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("community_code")]
        public string CommunityCode { get; set; }

        /// <summary>
        /// 小区/大楼所在纬度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("community_lat")]
        public string CommunityLat { get; set; }

        /// <summary>
        /// 小区/大楼所在经度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("community_lng")]
        public string CommunityLng { get; set; }

        /// <summary>
        /// 小区/大楼名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("community_name")]
        public string CommunityName { get; set; }

        /// <summary>
        /// 小区/大楼弄号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("community_nong")]
        public string CommunityNong { get; set; }

        /// <summary>
        /// 小区/大楼街道
        /// </summary>
        [Newtonsoft.Json.JsonProperty("community_street")]
        public string CommunityStreet { get; set; }

        /// <summary>
        /// 小区/大楼标识类型 1：小区  2:大楼
        /// </summary>
        [Newtonsoft.Json.JsonProperty("community_tag")]
        public string CommunityTag { get; set; }

        /// <summary>
        /// 行政区域编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 行政区域所在纬度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("district_lat")]
        public string DistrictLat { get; set; }

        /// <summary>
        /// 行政区域所在经度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("district_lng")]
        public string DistrictLng { get; set; }

        /// <summary>
        /// 行政区域名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("district_name")]
        public string DistrictName { get; set; }

        /// <summary>
        /// 地铁线地铁站关系
        /// </summary>
        [XmlArray("subway_stations")]
        [XmlArrayItem("string")]
        public List<string> SubwayStations { get; set; }
    }
}
