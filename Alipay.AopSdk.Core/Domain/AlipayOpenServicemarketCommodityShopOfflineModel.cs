using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketCommodityShopOfflineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenServicemarketCommodityShopOfflineModel : AopObject
    {
        /// <summary>
        /// 服务商户ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commodity_id")]
        public string CommodityId { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
