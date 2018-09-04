using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// SsdataDataserviceRiskAlixiaohaoQueryResponse.
    /// </summary>
    public class SsdataDataserviceRiskAlixiaohaoQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否阿里小号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_alixiaohao")]
        public bool IsAlixiaohao { get; set; }
    }
}
