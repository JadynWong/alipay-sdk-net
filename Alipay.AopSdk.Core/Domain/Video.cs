using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Video Data Structure.
    /// </summary>
    [Serializable]
    public class Video : AopObject
    {
        /// <summary>
        /// 调用alipay.offline.material.image.upload接口将视频上传到素材中心后，生成的ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location")]
        public string Location { get; set; }

        /// <summary>
        /// 视频名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }
    }
}
