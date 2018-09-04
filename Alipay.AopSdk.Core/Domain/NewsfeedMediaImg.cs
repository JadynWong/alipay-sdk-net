using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NewsfeedMediaImg Data Structure.
    /// </summary>
    [Serializable]
    public class NewsfeedMediaImg : AopObject
    {
        /// <summary>
        /// 图片高度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("height")]
        public string Height { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("src")]
        public string Src { get; set; }

        /// <summary>
        /// 图片宽度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("width")]
        public string Width { get; set; }
    }
}
