using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemOrderVO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemOrderVO : AopObject
    {
        /// <summary>
        /// 业务扩展信息，比如外部卡码，格式为json格式
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商品单ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_order_no")]
        public string ItemOrderNo { get; set; }

        /// <summary>
        /// 商品单价
        /// </summary>
        [Newtonsoft.Json.JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品数量
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
