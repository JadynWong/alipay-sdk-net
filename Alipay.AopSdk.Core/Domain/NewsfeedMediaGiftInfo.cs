using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NewsfeedMediaGiftInfo Data Structure.
    /// </summary>
    [Serializable]
    public class NewsfeedMediaGiftInfo : AopObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        public string Action { get; set; }

        /// <summary>
        /// 安卓的高度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adr_height")]
        public string AdrHeight { get; set; }

        /// <summary>
        /// 安卓缩略图
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adr_thumb")]
        public string AdrThumb { get; set; }

        /// <summary>
        /// 安卓宽度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adr_width")]
        public string AdrWidth { get; set; }

        /// <summary>
        /// ios高度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ios_height")]
        public string IosHeight { get; set; }

        /// <summary>
        /// ios缩略图
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ios_thumb")]
        public string IosThumb { get; set; }

        /// <summary>
        /// ios宽度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ios_width")]
        public string IosWidth { get; set; }

        /// <summary>
        /// 大图
        /// </summary>
        [Newtonsoft.Json.JsonProperty("theme")]
        public string Theme { get; set; }

        /// <summary>
        /// 红包类型all、f、m
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; }
    }
}
