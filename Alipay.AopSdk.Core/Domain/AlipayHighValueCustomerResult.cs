using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayHighValueCustomerResult Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayHighValueCustomerResult : AopObject
    {
        /// <summary>
        /// Z0-Z7
        /// </summary>
        [Newtonsoft.Json.JsonProperty("level")]
        public string Level { get; set; }
    }
}
