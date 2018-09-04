using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveBillInferenceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCognitiveBillInferenceQueryModel : AopObject
    {
        /// <summary>
        /// 图片大小
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_content")]
        public string ImageContent { get; set; }
    }
}
