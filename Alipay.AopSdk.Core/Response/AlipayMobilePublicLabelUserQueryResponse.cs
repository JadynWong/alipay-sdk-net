using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobilePublicLabelUserQueryResponse.
    /// </summary>
    public class AlipayMobilePublicLabelUserQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 标签编号，英文逗号分隔。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("label_ids")]
        public string LabelIds { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        public string Msg { get; set; }
    }
}
