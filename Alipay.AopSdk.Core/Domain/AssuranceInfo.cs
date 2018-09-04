using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssuranceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AssuranceInfo : AopObject
    {
        /// <summary>
        /// 服务保障的描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 服务保障的标题
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        public string Title { get; set; }
    }
}
