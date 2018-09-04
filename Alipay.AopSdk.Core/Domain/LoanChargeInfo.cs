using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LoanChargeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LoanChargeInfo : AopObject
    {
        /// <summary>
        /// 费用编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("charge_code")]
        public string ChargeCode { get; set; }

        /// <summary>
        /// 费用名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("charge_name")]
        public string ChargeName { get; set; }

        /// <summary>
        /// 分段费率
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instal_chrg_rate")]
        public InstallmentValue InstalChrgRate { get; set; }
    }
}
