using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbdishCookPriceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishCookPriceInfo : AopObject
    {
        /// <summary>
        /// 菜单id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cook_id")]
        public string CookId { get; set; }

        /// <summary>
        /// 菜品id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 会员价
        /// </summary>
        [Newtonsoft.Json.JsonProperty("member_price")]
        public string MemberPrice { get; set; }

        /// <summary>
        /// 售卖价格
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sell_price")]
        public string SellPrice { get; set; }

        /// <summary>
        /// skuid
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sku_id")]
        public string SkuId { get; set; }
    }
}
