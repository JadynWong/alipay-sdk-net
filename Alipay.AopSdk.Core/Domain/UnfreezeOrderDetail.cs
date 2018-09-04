using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UnfreezeOrderDetail Data Structure.
    /// </summary>
    [Serializable]
    public class UnfreezeOrderDetail : AopObject
    {
        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Newtonsoft.Json.JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 冻结订单的商户订单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 订单的最近修改时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("modified_time")]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// 冻结金额（含服务费）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 订单状态：I：初始，S：成功，F：失败
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 解冻金额（含服务费）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unfreeze_amount")]
        public string UnfreezeAmount { get; set; }
    }
}
