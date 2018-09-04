using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarDataExternalQueryResponse.
    /// </summary>
    public class AlipayEcoMycarDataExternalQueryResponse : AopResponse
    {
        /// <summary>
        /// 30
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_system_name")]
        public string ExternalSystemName { get; set; }

        /// <summary>
        /// outter_response
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query_result")]
        public string QueryResult { get; set; }
    }
}
