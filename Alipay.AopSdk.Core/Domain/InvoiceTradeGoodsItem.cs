using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceTradeGoodsItem Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceTradeGoodsItem : AopObject
    {
        /// <summary>
        /// 商品类目
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商户设置的商品编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_no")]
        public string GoodsNo { get; set; }

        /// <summary>
        /// 商品项支付金额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_sum_amount")]
        public string GoodsSumAmount { get; set; }

        /// <summary>
        /// 商品单价，单位元，精确到小数点后两位
        /// </summary>
        [Newtonsoft.Json.JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// 购买数量
        /// </summary>
        [Newtonsoft.Json.JsonProperty("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 购买商品规格型号描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("specification")]
        public string Specification { get; set; }

        /// <summary>
        /// 购买商品单位描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unit")]
        public string Unit { get; set; }
    }
}
