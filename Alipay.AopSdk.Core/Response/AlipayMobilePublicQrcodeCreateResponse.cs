using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobilePublicQrcodeCreateResponse.
    /// </summary>
    public class AlipayMobilePublicQrcodeCreateResponse : AopResponse
    {
        /// <summary>
        /// 返回结果码，如200，标识成功
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_img")]
        public string CodeImg { get; set; }

        /// <summary>
        /// 码过期时间，单位：秒
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_second")]
        public long ExpireSecond { get; set; }

        /// <summary>
        /// 结果吗描述信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        public string Msg { get; set; }
    }
}
