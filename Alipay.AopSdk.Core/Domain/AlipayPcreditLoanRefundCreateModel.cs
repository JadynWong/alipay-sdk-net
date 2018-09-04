using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditLoanRefundCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanRefundCreateModel : AopObject
    {
        /// <summary>
        /// 蚂蚁借呗贷款申请编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("loan_apply_no")]
        public string LoanApplyNo { get; set; }

        /// <summary>
        /// 商户还款订单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商户还款金额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("repay_amt")]
        public string RepayAmt { get; set; }

        /// <summary>
        /// 请求流水号，用于控制幂等
        /// </summary>
        [Newtonsoft.Json.JsonProperty("req_id")]
        public string ReqId { get; set; }
    }
}
