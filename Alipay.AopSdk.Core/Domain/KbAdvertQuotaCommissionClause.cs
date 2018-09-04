using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbAdvertQuotaCommissionClause Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertQuotaCommissionClause : AopObject
    {
        /// <summary>
        /// 固定金额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("quota_amount")]
        public string QuotaAmount { get; set; }
    }
}
