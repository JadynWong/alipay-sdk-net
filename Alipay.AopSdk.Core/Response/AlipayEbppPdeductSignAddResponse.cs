using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppPdeductSignAddResponse.
    /// </summary>
    public class AlipayEbppPdeductSignAddResponse : AopResponse
    {
        /// <summary>
        /// 支付宝代扣协议ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 支付宝协议状态。签约成功则返回success
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agreement_status")]
        public string AgreementStatus { get; set; }

        /// <summary>
        /// 扩展参数，可为空
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 通知方式设置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_config")]
        public string NotifyConfig { get; set; }

        /// <summary>
        /// 商户生成的代扣协议ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_agreement_id")]
        public string OutAgreementId { get; set; }

        /// <summary>
        /// 支付方式设置
        /// </summary>
        [XmlArray("pay_config")]
        [XmlArrayItem("string")]
        public List<string> PayConfig { get; set; }

        /// <summary>
        /// 签约时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign_date")]
        public string SignDate { get; set; }
    }
}
