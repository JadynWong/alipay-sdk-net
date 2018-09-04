using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAntpaasUseridGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAntpaasUseridGetModel : AopObject
    {
        /// <summary>
        /// 账户登录号，邮箱或者手机号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logon_id")]
        public string LogonId { get; set; }
    }
}
