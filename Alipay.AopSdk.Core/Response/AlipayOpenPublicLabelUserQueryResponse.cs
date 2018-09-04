using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenPublicLabelUserQueryResponse.
    /// </summary>
    public class AlipayOpenPublicLabelUserQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户标签id列表，以英文逗号分隔
        /// </summary>
        [Newtonsoft.Json.JsonProperty("label_ids")]
        public string LabelIds { get; set; }
    }
}
