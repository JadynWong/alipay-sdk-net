using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbadvertChannelTypeResponse Data Structure.
    /// </summary>
    [Serializable]
    public class KbadvertChannelTypeResponse : AopObject
    {
        /// <summary>
        /// 渠道描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 排序，暂时无用
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order")]
        public string Order { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; }
    }
}
