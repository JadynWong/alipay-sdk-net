using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbOrderShopModel Data Structure.
    /// </summary>
    [Serializable]
    public class KbOrderShopModel : AopObject
    {
        /// <summary>
        /// 门店ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 00007
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_id")]
        public string StoreId { get; set; }
    }
}
