using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobilePublicLabelUserAddResponse.
    /// </summary>
    public class AlipayMobilePublicLabelUserAddResponse : AopResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        public string Msg { get; set; }
    }
}
