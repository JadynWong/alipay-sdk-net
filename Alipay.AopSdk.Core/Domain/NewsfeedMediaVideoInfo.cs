using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NewsfeedMediaVideoInfo Data Structure.
    /// </summary>
    [Serializable]
    public class NewsfeedMediaVideoInfo : AopObject
    {
        /// <summary>
        /// 高度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("height")]
        public string Height { get; set; }

        /// <summary>
        /// 视频缩略图的ID（支持djangoId）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("img_id")]
        public string ImgId { get; set; }

        /// <summary>
        /// 视频的id（支持djangoId）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video_id")]
        public string VideoId { get; set; }

        /// <summary>
        /// 宽度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("width")]
        public string Width { get; set; }
    }
}
