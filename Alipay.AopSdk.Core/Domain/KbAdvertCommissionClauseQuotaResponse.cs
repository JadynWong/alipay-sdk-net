using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbAdvertCommissionClauseQuotaResponse Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertCommissionClauseQuotaResponse : AopObject
    {
        /// <summary>
        /// 分佣定额(精度2位的非负小数)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("quota_amount")]
        public string QuotaAmount { get; set; }
    }
}
