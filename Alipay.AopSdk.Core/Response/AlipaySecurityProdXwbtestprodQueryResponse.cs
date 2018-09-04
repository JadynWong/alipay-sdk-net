using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdXwbtestprodQueryResponse.
    /// </summary>
    public class AlipaySecurityProdXwbtestprodQueryResponse : AopResponse
    {
        /// <summary>
        /// 11000
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_a")]
        public string OutA { get; set; }

        /// <summary>
        /// xxxx
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_b")]
        public long OutB { get; set; }
    }
}
