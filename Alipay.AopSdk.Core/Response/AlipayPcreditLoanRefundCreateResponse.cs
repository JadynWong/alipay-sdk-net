using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanRefundCreateResponse.
    /// </summary>
    public class AlipayPcreditLoanRefundCreateResponse : AopResponse
    {
        /// <summary>
        /// 受理的还款申请单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("loan_repay_no")]
        public string LoanRepayNo { get; set; }
    }
}
