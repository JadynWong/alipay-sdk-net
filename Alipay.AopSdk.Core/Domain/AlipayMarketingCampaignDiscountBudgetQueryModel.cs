using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignDiscountBudgetQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignDiscountBudgetQueryModel : AopObject
    {
        /// <summary>
        /// 预算名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budget_id")]
        public string BudgetId { get; set; }
    }
}
