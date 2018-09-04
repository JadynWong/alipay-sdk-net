using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReduceToDiscountDstCampPrizeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ReduceToDiscountDstCampPrizeModel : AopObject
    {
        /// <summary>
        /// 折扣预算ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budget_id")]
        public string BudgetId { get; set; }

        /// <summary>
        /// 奖品id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 单次优惠上限(元)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("max_discount_amt")]
        public string MaxDiscountAmt { get; set; }

        /// <summary>
        /// 折扣幅度减至必须为0.3到1之间的小数(保留小数点后2位)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reduce_to_discount_rate")]
        public string ReduceToDiscountRate { get; set; }
    }
}
