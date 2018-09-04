using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommonDescInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CommonDescInfo : AopObject
    {
        /// <summary>
        /// 图片URL地址，最大不超过60K，必须使用https
        /// </summary>
        [Newtonsoft.Json.JsonProperty("img")]
        public string Img { get; set; }

        /// <summary>
        /// 文本描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("text")]
        public string Text { get; set; }
    }
}
