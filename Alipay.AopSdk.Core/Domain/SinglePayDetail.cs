using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SinglePayDetail Data Structure.
    /// </summary>
    [Serializable]
    public class SinglePayDetail : AopObject
    {
        /// <summary>
        /// 支付宝冻结订单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 本次支付金额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 最近修改时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("modified_time")]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// 本次支付url地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_url")]
        public string PayUrl { get; set; }

        /// <summary>
        /// 收款人的userId
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receive_user_id")]
        public string ReceiveUserId { get; set; }

        /// <summary>
        /// 本次支付的支付宝流水号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_order_no")]
        public string TransferOrderNo { get; set; }

        /// <summary>
        /// 本次支付的外部单据号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_out_order_no")]
        public string TransferOutOrderNo { get; set; }
    }
}
