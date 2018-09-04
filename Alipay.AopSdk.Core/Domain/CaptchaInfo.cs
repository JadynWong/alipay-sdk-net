using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CaptchaInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CaptchaInfo : AopObject
    {
        /// <summary>
        /// 图片特殊描述信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("captcha_desc")]
        public string CaptchaDesc { get; set; }

        /// <summary>
        /// 图片内容，base64编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_content")]
        public string ImageContent { get; set; }

        /// <summary>
        /// 图片类型，jpeg|bmp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_type")]
        public string ImageType { get; set; }
    }
}
