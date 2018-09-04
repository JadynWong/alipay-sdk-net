using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RepayDetail Data Structure.
    /// </summary>
    [Serializable]
    public class RepayDetail : AopObject
    {
        /// <summary>
        /// 应还本金
        /// </summary>
        [Newtonsoft.Json.JsonProperty("capital_amount")]
        public string CapitalAmount { get; set; }

        /// <summary>
        /// 贷款合同编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 应还利息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("interest_amount")]
        public string InterestAmount { get; set; }

        /// <summary>
        /// 贷款年份
        /// </summary>
        [Newtonsoft.Json.JsonProperty("loan_year")]
        public string LoanYear { get; set; }

        /// <summary>
        /// 总还款金额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_amount")]
        public string TotalAmount { get; set; }
    }
}
