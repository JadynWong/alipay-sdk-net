using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignDiscountBudgetQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignDiscountBudgetQueryResponse : AopResponse
    {
        /// <summary>
        /// 预算ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budget_id")]
        public string BudgetId { get; set; }

        /// <summary>
        /// 预算剩余冻结金额(元)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("freeze_amount")]
        public string FreezeAmount { get; set; }

        /// <summary>
        /// 预算已回收退回保证金账户金额(元)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recycle_amount")]
        public string RecycleAmount { get; set; }

        /// <summary>
        /// 交易已退款金额(元)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 预算总金额(元)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 交易已使用金额(元)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("used_amount")]
        public string UsedAmount { get; set; }
    }
}
