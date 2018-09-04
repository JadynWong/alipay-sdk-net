using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GoodInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GoodInfo : AopObject
    {
        /// <summary>
        /// 商品的编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 设备中该商品的剩余数量
        /// </summary>
        [Newtonsoft.Json.JsonProperty("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 商品重量,单位克
        /// </summary>
        [Newtonsoft.Json.JsonProperty("weight")]
        public string Weight { get; set; }
    }
}
