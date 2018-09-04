using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LoginForm Data Structure.
    /// </summary>
    [Serializable]
    public class LoginForm : AopObject
    {
        /// <summary>
        /// 图片验证码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("captcha")]
        public string Captcha { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id_card_no")]
        public string IdCardNo { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone_no")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 查询密码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query_password")]
        public string QueryPassword { get; set; }

        /// <summary>
        /// 服务密码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_password")]
        public string ServicePassword { get; set; }

        /// <summary>
        /// 短信验证码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sms_code")]
        public string SmsCode { get; set; }

        /// <summary>
        /// 吉林电信短信验证码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sms_code_jldx")]
        public string SmsCodeJldx { get; set; }
    }
}
