using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RefundRoyaltyResult Data Structure.
    /// </summary>
    [Serializable]
    public class RefundRoyaltyResult : AopObject
    {
        /// <summary>
        /// 退分润金额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退分润结果码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 转入人支付宝账号对应用户ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trans_in")]
        public string TransIn { get; set; }

        /// <summary>
        /// 转入人支付宝账号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trans_in_email")]
        public string TransInEmail { get; set; }

        /// <summary>
        /// 转出人支付宝账号对应用户ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trans_out")]
        public string TransOut { get; set; }

        /// <summary>
        /// 转出人支付宝账号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trans_out_email")]
        public string TransOutEmail { get; set; }
    }
}
