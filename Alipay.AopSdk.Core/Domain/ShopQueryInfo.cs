using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopQueryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopQueryInfo : AopObject
    {
        /// <summary>
        /// 门店地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// 是否包含同mid下的其他pid的店铺
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_include_cognate")]
        public bool IsIncludeCognate { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 内部门店ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 门店类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_type")]
        public string ShopType { get; set; }

        /// <summary>
        /// 外部门店ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_id")]
        public string StoreId { get; set; }
    }
}
