using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NewsfeedLabelInfo Data Structure.
    /// </summary>
    [Serializable]
    public class NewsfeedLabelInfo : AopObject
    {
        /// <summary>
        /// 根据主谓宾的格式生成动态的标题，此字段为谓语
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        public string Action { get; set; }

        /// <summary>
        /// label行的跳转链接
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scheme")]
        public string Scheme { get; set; }

        /// <summary>
        /// 根据主谓宾的格式生成动态的标题，此字段为宾语
        /// </summary>
        [Newtonsoft.Json.JsonProperty("target")]
        public string Target { get; set; }
    }
}
