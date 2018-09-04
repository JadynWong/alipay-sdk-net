using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditSupplychainPrepaymentApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSupplychainPrepaymentApplyModel : AopObject
    {
        /// <summary>
        /// 买家身份信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buyer")]
        public Member Buyer { get; set; }

        /// <summary>
        /// 贷款支付金额，单位人民币元。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("loan_pay_amount")]
        public string LoanPayAmount { get; set; }

        /// <summary>
        /// 外部订单号，格式：机构ipRoleId_外部订单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 接口幂等字段，相同requestId请求系统默认认为是相同的请求。此处requestId要求的格式为"{机构IpRoleId}_{机构生成的唯一请求ID}"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 客户自付金额，一般为订单首付，单位人民币元。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("self_pay_amount")]
        public string SelfPayAmount { get; set; }
    }
}
