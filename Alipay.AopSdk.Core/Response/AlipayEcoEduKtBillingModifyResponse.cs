using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoEduKtBillingModifyResponse.
    /// </summary>
    public class AlipayEcoEduKtBillingModifyResponse : AopResponse
    {
        /// <summary>
        /// 如果成功，返回Y
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; }
    }
}
