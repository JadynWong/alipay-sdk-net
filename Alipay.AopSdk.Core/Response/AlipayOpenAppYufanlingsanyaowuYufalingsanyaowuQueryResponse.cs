using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppYufanlingsanyaowuYufalingsanyaowuQueryResponse.
    /// </summary>
    public class AlipayOpenAppYufanlingsanyaowuYufalingsanyaowuQueryResponse : AopResponse
    {
        /// <summary>
        /// 10
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        public string Userid { get; set; }
    }
}
