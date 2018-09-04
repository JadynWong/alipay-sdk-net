using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenPublicXwbtestabcdBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicXwbtestabcdBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 1111
        /// </summary>
        [Newtonsoft.Json.JsonProperty("b")]
        public string B { get; set; }
    }
}
