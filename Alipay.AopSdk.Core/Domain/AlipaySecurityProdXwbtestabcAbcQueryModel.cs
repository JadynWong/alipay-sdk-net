using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdXwbtestabcAbcQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdXwbtestabcAbcQueryModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("xwb")]
        public string Xwb { get; set; }
    }
}
