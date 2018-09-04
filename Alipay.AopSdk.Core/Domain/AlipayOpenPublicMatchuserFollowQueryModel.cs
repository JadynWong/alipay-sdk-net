using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicMatchuserFollowQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicMatchuserFollowQueryModel : AopObject
    {
        /// <summary>
        /// 身份证号码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("identity_card")]
        public string IdentityCard { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mobile_no")]
        public string MobileNo { get; set; }

        /// <summary>
        /// 支付宝用户id，2088开头的16位长度字符串
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
