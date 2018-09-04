using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieActivityQueryResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieActivityQueryResponse : AopResponse
    {
        /// <summary>
        /// H5应用详情
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity")]
        public FengdieActivity Activity { get; set; }
    }
}
