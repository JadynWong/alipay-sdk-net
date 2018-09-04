using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbAdvertContentShortLink Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertContentShortLink : AopObject
    {
        /// <summary>
        /// 链接地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        public string Url { get; set; }
    }
}
