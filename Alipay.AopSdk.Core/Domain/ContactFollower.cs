using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContactFollower Data Structure.
    /// </summary>
    [Serializable]
    public class ContactFollower : AopObject
    {
        /// <summary>
        /// 支付宝头像
        /// </summary>
        [Newtonsoft.Json.JsonProperty("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// 默认头像
        /// </summary>
        [Newtonsoft.Json.JsonProperty("default_avatar")]
        public string DefaultAvatar { get; set; }

        /// <summary>
        /// false
        /// </summary>
        [Newtonsoft.Json.JsonProperty("each_record_flag")]
        public string EachRecordFlag { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
