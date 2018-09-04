using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenXwbtesttomsgapiSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenXwbtesttomsgapiSyncModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("xwb")]
        public string Xwb { get; set; }
    }
}
