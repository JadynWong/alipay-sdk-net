using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFinanceFundFundFixedprofitQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinanceFundFundFixedprofitQueryModel : AopObject
    {
        /// <summary>
        /// 基金代码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fund_code")]
        public string FundCode { get; set; }
    }
}
