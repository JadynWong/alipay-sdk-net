using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceOrderInfo : AopObject
    {
        /// <summary>
        /// 服务总金额，单位为元
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 商品服务所在类目的id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 订单创建时间，格式为  yyyy-MM-dd HH:mm:ss
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 订单修改时间，格式为  yyyy-MM-dd HH:mm:ss
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 订单最后支付时间，格式：  yyyy-MM-dd HH:mm:ss
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gmt_payment")]
        public string GmtPayment { get; set; }

        /// <summary>
        /// 订单最后退款时间，格式：  yyyy-MM-dd HH:mm:ss
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gmt_refund")]
        public string GmtRefund { get; set; }

        /// <summary>
        /// 消费者标注订单备注
        /// </summary>
        [Newtonsoft.Json.JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 第三方服务id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_service_id")]
        public string OutServiceId { get; set; }

        /// <summary>
        /// 商品的商家端端SKU ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 第三方服务者id列表，例子：  [“2323”,…]，如果没有服务者，则为[]
        /// </summary>
        [XmlArray("out_sp_id")]
        [XmlArrayItem("string")]
        public List<string> OutSpId { get; set; }

        /// <summary>
        /// 服务已付金额，单位为元
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_amount")]
        public string PaymentAmount { get; set; }

        /// <summary>
        /// 单价，单位为元
        /// </summary>
        [Newtonsoft.Json.JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// 份数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 服务实际金额，单位为元
        /// </summary>
        [Newtonsoft.Json.JsonProperty("real_amount")]
        public string RealAmount { get; set; }

        /// <summary>
        /// 订单退款金额，单位为元
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 到位的服务id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 服务订单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_order_no")]
        public string ServiceOrderNo { get; set; }

        /// <summary>
        /// 商品的内部SKU ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 商品价格单位
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unit")]
        public string Unit { get; set; }
    }
}
