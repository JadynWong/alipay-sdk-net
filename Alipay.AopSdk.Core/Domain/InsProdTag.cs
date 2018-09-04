using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsProdTag Data Structure.
    /// </summary>
    [Serializable]
    public class InsProdTag : AopObject
    {
        /// <summary>
        /// 业务标记代码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag_code")]
        public string TagCode { get; set; }

        /// <summary>
        /// 业务标记值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag_value")]
        public string TagValue { get; set; }
    }
}
