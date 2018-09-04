using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerCertificationQueryResponse.
    /// </summary>
    public class ZhimaCustomerCertificationQueryResponse : AopResponse
    {
        /// <summary>
        /// 认证的主体属性信息，一般的认证场景都是返回空
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attribute_info")]
        public string AttributeInfo { get; set; }

        /// <summary>
        /// 包含了认证过程中的认证材料和过程记录
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_statuses")]
        public string ChannelStatuses { get; set; }

        /// <summary>
        /// 认证不通过的原因
        /// </summary>
        [Newtonsoft.Json.JsonProperty("failed_reason")]
        public string FailedReason { get; set; }

        /// <summary>
        /// 认证的主体信息，一般的认证场景返回为空
        /// </summary>
        [Newtonsoft.Json.JsonProperty("identity_info")]
        public string IdentityInfo { get; set; }

        /// <summary>
        /// 认证是否通过,通过为true，不通过为false
        /// </summary>
        [Newtonsoft.Json.JsonProperty("passed")]
        public string Passed { get; set; }
    }
}
