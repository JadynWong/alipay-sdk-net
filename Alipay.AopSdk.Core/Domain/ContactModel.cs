using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContactModel Data Structure.
    /// </summary>
    [Serializable]
    public class ContactModel : AopObject
    {
        /// <summary>
        /// 联系人邮箱
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 联系人手机号码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 联系人名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact_name")]
        public string ContactName { get; set; }
    }
}
