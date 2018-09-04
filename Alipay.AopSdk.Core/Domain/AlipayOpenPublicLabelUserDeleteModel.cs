using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicLabelUserDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicLabelUserDeleteModel : AopObject
    {
        /// <summary>
        /// 标签id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("label_id")]
        public string LabelId { get; set; }

        /// <summary>
        /// 支付宝用户的userid，2088开头长度为16位的字符串
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
