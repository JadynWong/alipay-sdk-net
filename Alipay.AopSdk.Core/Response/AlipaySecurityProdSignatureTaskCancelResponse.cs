using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdSignatureTaskCancelResponse.
    /// </summary>
    public class AlipaySecurityProdSignatureTaskCancelResponse : AopResponse
    {
        /// <summary>
        /// 是否更新成功
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success")]
        public bool Success { get; set; }
    }
}
