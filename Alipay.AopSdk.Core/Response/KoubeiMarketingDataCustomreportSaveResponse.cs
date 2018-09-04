using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingDataCustomreportSaveResponse.
    /// </summary>
    public class KoubeiMarketingDataCustomreportSaveResponse : AopResponse
    {
        /// <summary>
        /// 自定义报表的规则ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("condition_key")]
        public string ConditionKey { get; set; }
    }
}
