using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CraftsmanSubAssessment Data Structure.
    /// </summary>
    [Serializable]
    public class CraftsmanSubAssessment : AopObject
    {
        /// <summary>
        /// 子评分
        /// </summary>
        [Newtonsoft.Json.JsonProperty("score")]
        public long Score { get; set; }

        /// <summary>
        /// 子评分项名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        public string Title { get; set; }
    }
}
