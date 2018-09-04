using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobileShakeUserQueryResponse.
    /// </summary>
    public class AlipayMobileShakeUserQueryResponse : AopResponse
    {
        /// <summary>
        /// 对应的业务信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bizdata")]
        public string Bizdata { get; set; }

        /// <summary>
        /// 支付宝用户登录账户，可能是email或者手机号码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 对应的核销数据
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pass_id")]
        public string PassId { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
