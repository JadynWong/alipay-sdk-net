using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdXwbtestabcAbcQueryResponse.
    /// </summary>
    public class AlipaySecurityProdXwbtestabcAbcQueryResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("xwb")]
        public string Xwb { get; set; }
    }
}
