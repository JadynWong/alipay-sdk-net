using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GoodsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsInfo : AopObject
    {
        /// <summary>
        /// 商品类目
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_category")]
        public string GoodsCategory { get; set; }

        /// <summary>
        /// 商户自定义商品外部编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商户自定义商品名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品单价，单位元,精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [Newtonsoft.Json.JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品数量,支持小数，但是小数位不能超过两位
        /// </summary>
        [Newtonsoft.Json.JsonProperty("quantity")]
        public string Quantity { get; set; }
    }
}
