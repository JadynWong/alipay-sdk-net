using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayZdatafrontDatatransferedSendResponse.
    /// </summary>
    public class AlipayZdatafrontDatatransferedSendResponse : AopResponse
    {
        /// <summary>
        /// 表示数据传输是否成功
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success")]
        public string Success { get; set; }
    }
}
