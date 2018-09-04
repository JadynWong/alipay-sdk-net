using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsDataDsbRequestImageInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsDataDsbRequestImageInfo : AopObject
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
