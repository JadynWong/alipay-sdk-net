using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialBaseChatGmemberConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseChatGmemberConfirmModel : AopObject
    {
        /// <summary>
        /// 业务类型，申请接入时和我们申请，用于统计和限流
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 用户所在的群id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 要判断的用户id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
