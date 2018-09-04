using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiRetailShopitemModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailShopitemModifyModel : AopObject
    {
        /// <summary>
        /// 店铺商品的品牌名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_code")]
        public string BrandCode { get; set; }

        /// <summary>
        /// 店铺商品的商品类别
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 店铺商品SKU
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 口碑门店id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kb_shop_id")]
        public string KbShopId { get; set; }

        /// <summary>
        /// 参考价格
        /// </summary>
        [Newtonsoft.Json.JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// 店铺商品的名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        public string Title { get; set; }
    }
}
