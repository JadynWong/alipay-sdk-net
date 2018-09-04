using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAuthZhimaorgIdentityApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAuthZhimaorgIdentityApplyModel : AopObject
    {
        /// <summary>
        /// 营业执照号码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// NATIONAL_LEGAL:营业执照号码  NATIONAL_LEGAL_MERGE:三证合一号码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }
    }
}
