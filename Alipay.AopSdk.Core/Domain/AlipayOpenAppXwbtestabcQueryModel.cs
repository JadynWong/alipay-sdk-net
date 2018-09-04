using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppXwbtestabcQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppXwbtestabcQueryModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("testabc")]
        public string Testabc { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("xwb")]
        public string Xwb { get; set; }
    }
}
