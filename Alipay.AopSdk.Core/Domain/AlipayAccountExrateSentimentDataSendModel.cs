using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAccountExrateSentimentDataSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountExrateSentimentDataSendModel : AopObject
    {
        /// <summary>
        /// 国家制裁提交数据内容
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        public string Content { get; set; }
    }
}
