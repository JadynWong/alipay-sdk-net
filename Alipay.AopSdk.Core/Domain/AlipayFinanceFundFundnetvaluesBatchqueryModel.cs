using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFinanceFundFundnetvaluesBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinanceFundFundnetvaluesBatchqueryModel : AopObject
    {
        /// <summary>
        /// 结束日期，YYYYMMDD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 基金代码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fund_code")]
        public string FundCode { get; set; }

        /// <summary>
        /// 分页数，从 1 开始
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 开始日期，YYYYMMDD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_date")]
        public string StartDate { get; set; }
    }
}
