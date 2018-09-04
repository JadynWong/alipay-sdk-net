using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieActivityCreateResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieActivityCreateResponse : AopResponse
    {
        /// <summary>
        /// H5应用的唯一id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_id")]
        public long ActivityId { get; set; }
    }
}
