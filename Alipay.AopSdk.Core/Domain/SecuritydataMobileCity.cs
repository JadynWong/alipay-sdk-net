using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SecuritydataMobileCity Data Structure.
    /// </summary>
    [Serializable]
    public class SecuritydataMobileCity : AopObject
    {
        /// <summary>
        /// 城市
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// 手机号前七位
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone_first_7_digits")]
        public string PhoneFirst7Digits { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [Newtonsoft.Json.JsonProperty("province")]
        public string Province { get; set; }
    }
}
