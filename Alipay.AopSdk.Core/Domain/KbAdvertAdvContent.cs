using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbAdvertAdvContent Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertAdvContent : AopObject
    {
        /// <summary>
        /// 二维码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("codec")]
        public string Codec { get; set; }

        /// <summary>
        /// 访问地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("link_url")]
        public string LinkUrl { get; set; }
    }
}
