using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZolozIdentificationUserWebInitializeResponse.
    /// </summary>
    public class ZolozIdentificationUserWebInitializeResponse : AopResponse
    {
        /// <summary>
        /// 扩展结果
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extern_info")]
        public string ExternInfo { get; set; }

        /// <summary>
        /// 刷脸认证的唯一标识
        /// </summary>
        [Newtonsoft.Json.JsonProperty("zim_id")]
        public string ZimId { get; set; }
    }
}
