using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HoloGraphicContactInfo Data Structure.
    /// </summary>
    [Serializable]
    public class HoloGraphicContactInfo : AopObject
    {
        /// <summary>
        /// 主叫通话频次
        /// </summary>
        [Newtonsoft.Json.JsonProperty("call_frequency")]
        public long CallFrequency { get; set; }

        /// <summary>
        /// 主叫通话时长
        /// </summary>
        [Newtonsoft.Json.JsonProperty("call_time")]
        public long CallTime { get; set; }

        /// <summary>
        /// 被叫通话频次
        /// </summary>
        [Newtonsoft.Json.JsonProperty("called_frequency")]
        public long CalledFrequency { get; set; }

        /// <summary>
        /// 被叫通话时长
        /// </summary>
        [Newtonsoft.Json.JsonProperty("called_time")]
        public long CalledTime { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 通话频次
        /// </summary>
        [Newtonsoft.Json.JsonProperty("talk_frequency")]
        public long TalkFrequency { get; set; }

        /// <summary>
        /// 通话时长
        /// </summary>
        [Newtonsoft.Json.JsonProperty("talk_time")]
        public long TalkTime { get; set; }
    }
}
