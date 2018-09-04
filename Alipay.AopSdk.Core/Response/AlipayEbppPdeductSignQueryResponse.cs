using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppPdeductSignQueryResponse.
    /// </summary>
    public class AlipayEbppPdeductSignQueryResponse : AopResponse
    {
        /// <summary>
        /// 协议ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 户号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_key")]
        public string BillKey { get; set; }

        /// <summary>
        /// 出账机构
        /// </summary>
        [Newtonsoft.Json.JsonProperty("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 朗新协议ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_agreement_id")]
        public string OutAgreementId { get; set; }

        /// <summary>
        /// 签约时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign_date")]
        public string SignDate { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
