using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneApplicationIssueConfirmResponse.
    /// </summary>
    public class AlipayInsSceneApplicationIssueConfirmResponse : AopResponse
    {
        /// <summary>
        /// 投保订单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("application_no")]
        public string ApplicationNo { get; set; }
    }
}
