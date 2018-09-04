using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbAdvertSubjectResponse Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertSubjectResponse : AopObject
    {
        /// <summary>
        /// 分佣规则
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commission_clause")]
        public KbAdvertCommissionClauseResponse CommissionClause { get; set; }

        /// <summary>
        /// 标的类型  voucher-券
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// 券标的  只有type=voucher才会有值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("voucher")]
        public KbAdvertSubjectVoucherResponse Voucher { get; set; }
    }
}
