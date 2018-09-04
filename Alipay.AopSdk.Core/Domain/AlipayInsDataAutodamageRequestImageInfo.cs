using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsDataAutodamageRequestImageInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsDataAutodamageRequestImageInfo : AopObject
    {
        /// <summary>
        /// 图像文件名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_name")]
        public string ImageName { get; set; }

        /// <summary>
        /// 图像文件在存储上的路径
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_path")]
        public string ImagePath { get; set; }
    }
}
