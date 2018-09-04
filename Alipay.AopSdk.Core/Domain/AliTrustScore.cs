using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AliTrustScore Data Structure.
    /// </summary>
    [Serializable]
    public class AliTrustScore : AopObject
    {
        /// <summary>
        /// 芝麻分
        /// </summary>
        [Newtonsoft.Json.JsonProperty("score")]
        public long Score { get; set; }
    }
}
