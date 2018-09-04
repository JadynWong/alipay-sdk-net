using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StaffInfo Data Structure.
    /// </summary>
    [Serializable]
    public class StaffInfo : AopObject
    {
        /// <summary>
        /// 支付宝登录账号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 用户uid
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
