using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataAiserviceJunengLoanQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataAiserviceJunengLoanQueryModel : AopObject
    {
        /// <summary>
        /// 额外的信息，以 json 字符串的方式组织
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extension_info")]
        public string ExtensionInfo { get; set; }

        /// <summary>
        /// 借款人身份证号的md5
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hashed_cert_no")]
        public string HashedCertNo { get; set; }

        /// <summary>
        /// 机构代码，区别调用的外部机构
        /// </summary>
        [Newtonsoft.Json.JsonProperty("institution_uuid")]
        public string InstitutionUuid { get; set; }

        /// <summary>
        /// 单次请求的 uuid
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_uuid")]
        public string RequestUuid { get; set; }

        /// <summary>
        /// 用户属性，包含隐私保护数据和原始数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_feature")]
        public string UserFeature { get; set; }
    }
}
