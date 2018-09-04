using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingDataActivityReportQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataActivityReportQueryResponse : AopResponse
    {
        /// <summary>
        /// 报表
        /// </summary>
        [Newtonsoft.Json.JsonProperty("report_data")]
        public string ReportData { get; set; }
    }
}
