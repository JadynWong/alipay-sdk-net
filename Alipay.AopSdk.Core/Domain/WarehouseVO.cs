using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WarehouseVO Data Structure.
    /// </summary>
    [Serializable]
    public class WarehouseVO : AopObject
    {
        /// <summary>
        /// 仓库详细地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// 区域编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 区域名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("area_name")]
        public string AreaName { get; set; }

        /// <summary>
        /// 仓库的状态，EFFECTIVE：生效，INVALID：失效。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_status")]
        public string BizStatus { get; set; }

        /// <summary>
        /// 菜鸟仓的编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cainiao_code")]
        public string CainiaoCode { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 市的名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact")]
        public string Contact { get; set; }

        /// <summary>
        /// 维度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lat")]
        public string Lat { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lon")]
        public string Lon { get; set; }

        /// <summary>
        /// 归属人ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 省的编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 省的名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 对应的门店ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("warehouse_code")]
        public string WarehouseCode { get; set; }

        /// <summary>
        /// 仓库名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("warehouse_name")]
        public string WarehouseName { get; set; }

        /// <summary>
        /// 仓库类型，REAL：实仓
        /// </summary>
        [Newtonsoft.Json.JsonProperty("warehouse_type")]
        public string WarehouseType { get; set; }
    }
}
