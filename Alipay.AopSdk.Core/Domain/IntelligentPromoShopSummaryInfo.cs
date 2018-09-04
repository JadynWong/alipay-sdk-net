using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IntelligentPromoShopSummaryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IntelligentPromoShopSummaryInfo : AopObject
    {
        /// <summary>
        /// 门店id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 全店名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_name")]
        public string ShopName { get; set; }
    }
}
