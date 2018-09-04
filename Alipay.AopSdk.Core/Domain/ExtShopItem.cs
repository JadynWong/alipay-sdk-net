using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExtShopItem Data Structure.
    /// </summary>
    [Serializable]
    public class ExtShopItem : AopObject
    {
        /// <summary>
        /// 品牌编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_code")]
        public string BrandCode { get; set; }

        /// <summary>
        /// 品类编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 入数，必须为整数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count")]
        public long Count { get; set; }

        /// <summary>
        /// 产地
        /// </summary>
        [Newtonsoft.Json.JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// 产品描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 商品扩展信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_goods_info")]
        public string ExtGoodsInfo { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 商品条码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 口碑门店id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kb_shop_id")]
        public string KbShopId { get; set; }

        /// <summary>
        /// 商品图片url
        /// </summary>
        [Newtonsoft.Json.JsonProperty("picture")]
        public string Picture { get; set; }

        /// <summary>
        /// 参考价格
        /// </summary>
        [Newtonsoft.Json.JsonProperty("price")]
        public long Price { get; set; }

        /// <summary>
        /// 商品规格
        /// </summary>
        [Newtonsoft.Json.JsonProperty("specification")]
        public string Specification { get; set; }

        /// <summary>
        /// ISV系统提供商
        /// </summary>
        [Newtonsoft.Json.JsonProperty("system_provider_id")]
        public string SystemProviderId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        public string Title { get; set; }
    }
}
