using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrBusinesslicenseQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCognitiveOcrBusinesslicenseQueryModel : AopObject
    {
        /// <summary>
        /// 营业执照图片base64加密后内容
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_content")]
        public string ImageContent { get; set; }
    }
}
