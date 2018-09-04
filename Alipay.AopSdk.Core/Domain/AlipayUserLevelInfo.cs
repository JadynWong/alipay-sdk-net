using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserLevelInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserLevelInfo : AopObject
    {
        /// <summary>
        /// 支付宝用户登陆账号；邮箱优先，手机号次之
        /// </summary>
        [Newtonsoft.Json.JsonProperty("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户等级：可选5、4、3、2、1、0；等级5最高，1最低，0标示无法判断
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_level")]
        public string UserLevel { get; set; }
    }
}
