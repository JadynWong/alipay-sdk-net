using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AccountRecord Data Structure.
    /// </summary>
    [Serializable]
    public class AccountRecord : AopObject
    {
        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 当时账户的余额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 收入金额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("in_amount")]
        public string InAmount { get; set; }

        /// <summary>
        /// 账务备注说明
        /// </summary>
        [Newtonsoft.Json.JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 对方支付宝账户ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("opt_user_id")]
        public string OptUserId { get; set; }

        /// <summary>
        /// 支出金额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_amount")]
        public string OutAmount { get; set; }

        /// <summary>
        /// 本方支付宝账户ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("self_user_id")]
        public string SelfUserId { get; set; }

        /// <summary>
        /// 账务类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; }
    }
}
