using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppPdeductAsyncPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppPdeductAsyncPayModel : AopObject
    {
        /// <summary>
        /// 分配给外部机构发起扣款时的渠道码。朗新为LANGXIN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agent_channel")]
        public string AgentChannel { get; set; }

        /// <summary>
        /// 二级渠道码，预留字段
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agent_code")]
        public string AgentCode { get; set; }

        /// <summary>
        /// 支付宝代扣协议Id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 账期
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 户号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_key")]
        public string BillKey { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 滞纳金
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fine_amount")]
        public string FineAmount { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 商户外部业务流水号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 扣款金额，支付总金额，包含滞纳金
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 商户partnerId
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
