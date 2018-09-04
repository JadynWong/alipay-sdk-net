using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicLabelUserCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicLabelUserCreateModel : AopObject
    {
        /// <summary>
        /// 要绑定的标签Id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("label_id")]
        public long LabelId { get; set; }

        /// <summary>
        /// 支付宝用户id，2088开头长度为16位的字符串
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
