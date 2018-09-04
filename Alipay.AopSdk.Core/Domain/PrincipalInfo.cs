using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrincipalInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PrincipalInfo : AopObject
    {
        /// <summary>
        /// 用户手机号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mobile_no")]
        public string MobileNo { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator_cert_no")]
        public string OperatorCertNo { get; set; }

        /// <summary>
        /// 证件类型，例如身份证，护照等
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator_cert_type")]
        public string OperatorCertType { get; set; }

        /// <summary>
        /// 用户主体信息的扩展参数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("params")]
        public string Params { get; set; }

        /// <summary>
        /// 租户信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 业务方传入的用户标识
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_name")]
        public string UserName { get; set; }
    }
}
