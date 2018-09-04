using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CityShopModel Data Structure.
    /// </summary>
    [Serializable]
    public class CityShopModel : AopObject
    {
        /// <summary>
        /// 城市id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city_id")]
        public string CityId { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 区id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("district_id")]
        public string DistrictId { get; set; }

        /// <summary>
        /// 区名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("district_name")]
        public string DistrictName { get; set; }

        /// <summary>
        /// 判断门店是否是简易门店
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pos_shop")]
        public bool PosShop { get; set; }

        /// <summary>
        /// 省份id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("province_id")]
        public string ProvinceId { get; set; }

        /// <summary>
        /// 省份名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店状态
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_status")]
        public string ShopStatus { get; set; }
    }
}
