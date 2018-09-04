using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemOrderDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ItemOrderDetail : AopObject
    {
        /// <summary>
        /// 商品原价，单位元，精确到小数点后两位
        /// </summary>
        [Newtonsoft.Json.JsonProperty("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 商品现价，即商品售价，单位为元，精确到小数点后两位
        /// </summary>
        [Newtonsoft.Json.JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// 购买商品数量
        /// </summary>
        [Newtonsoft.Json.JsonProperty("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 商品skuId
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sku_id")]
        public string SkuId { get; set; }
    }
}
