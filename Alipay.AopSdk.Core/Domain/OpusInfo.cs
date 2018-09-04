using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpusInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OpusInfo : AopObject
    {
        /// <summary>
        /// 展示权重；必须大于等于0；排序规则：权重倒叙;默认值为0
        /// </summary>
        [Newtonsoft.Json.JsonProperty("display_weight")]
        public string DisplayWeight { get; set; }

        /// <summary>
        /// 外部作品id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_opus_id")]
        public string ExternalOpusId { get; set; }

        /// <summary>
        /// 素材id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_id")]
        public string MediaId { get; set; }

        /// <summary>
        /// 头图素材type；  枚举类型：PICTURE/VIDEO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_type")]
        public string MediaType { get; set; }

        /// <summary>
        /// 素材url
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_url")]
        public string MediaUrl { get; set; }

        /// <summary>
        /// 作品id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("opus_id")]
        public string OpusId { get; set; }

        /// <summary>
        /// 素材标题
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        public string Title { get; set; }
    }
}
