using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaymentSchedule Data Structure.
    /// </summary>
    [Serializable]
    public class PaymentSchedule : AopObject
    {
        /// <summary>
        /// 还款日
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date")]
        public string Date { get; set; }

        /// <summary>
        /// 已还利息总和，单位为元，小数点保留2位
        /// </summary>
        [Newtonsoft.Json.JsonProperty("repaid_interest_total")]
        public string RepaidInterestTotal { get; set; }

        /// <summary>
        /// 已还罚息总和，单位为元，小数点保留2位
        /// </summary>
        [Newtonsoft.Json.JsonProperty("repaid_penalty_total")]
        public string RepaidPenaltyTotal { get; set; }

        /// <summary>
        /// 已还本金总和，单位为元，小数点保留2位
        /// </summary>
        [Newtonsoft.Json.JsonProperty("repaid_principal_total")]
        public string RepaidPrincipalTotal { get; set; }

        /// <summary>
        /// 期初时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 期次
        /// </summary>
        [Newtonsoft.Json.JsonProperty("term")]
        public long Term { get; set; }

        /// <summary>
        /// 应还利息总和，单位为元，小数点保留2位
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unpaid_interest_total")]
        public string UnpaidInterestTotal { get; set; }

        /// <summary>
        /// 应还罚息总和，单位为元，小数点保留2位
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unpaid_penalty_total")]
        public string UnpaidPenaltyTotal { get; set; }

        /// <summary>
        /// 应还本金总和，单位为元，小数点保留2位
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unpaid_principal_total")]
        public string UnpaidPrincipalTotal { get; set; }
    }
}
