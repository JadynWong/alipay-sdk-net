using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ComplextMockModel Data Structure.
    /// </summary>
    [Serializable]
    public class ComplextMockModel : AopObject
    {
        /// <summary>
        /// biz_model
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_model")]
        public SimpleMockModel BizModel { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_num")]
        public long BizNum { get; set; }

        /// <summary>
        /// 208xxx
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_type")]
        public string BizType { get; set; }
    }
}
