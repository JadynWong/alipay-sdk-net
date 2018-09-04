using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppQrcodeCreateResponse.
    /// </summary>
    public class AlipayOpenAppQrcodeCreateResponse : AopResponse
    {
        /// <summary>
        /// 二维码图片链接地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qr_code_url")]
        public string QrCodeUrl { get; set; }
    }
}
