using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZolozIdentificationUserWebQueryResponse.
    /// </summary>
    public class ZolozIdentificationUserWebQueryResponse : AopResponse
    {
        /// <summary>
        /// 扩展结果
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extern_info")]
        public string ExternInfo { get; set; }
    }
}
