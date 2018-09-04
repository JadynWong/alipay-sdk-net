using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditSupplychainTradePayConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSupplychainTradePayConfirmModel : AopObject
    {
        /// <summary>
        /// 买家身份信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buyer")]
        public Member Buyer { get; set; }

        /// <summary>
        /// 外部订单号，格式：机构ipRoleId_外部订单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 预付订单号，在预付场景为必填，其他场景视情况而定
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prepay_order_no")]
        public string PrepayOrderNo { get; set; }

        /// <summary>
        /// 幂等编号，用于幂等控制，格式：机构ipRoleId_yyyymmddhhmmss_8位uniqId
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_id")]
        public string RequestId { get; set; }
    }
}
