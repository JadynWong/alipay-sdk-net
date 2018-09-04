using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IdentityParam Data Structure.
    /// </summary>
    [Serializable]
    public class IdentityParam : AopObject
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 身份类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
