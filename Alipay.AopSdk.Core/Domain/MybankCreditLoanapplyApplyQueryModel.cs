using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoanapplyApplyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoanapplyApplyQueryModel : AopObject
    {
        /// <summary>
        /// 证件号码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 扩展查询参数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_params")]
        public string ExtParams { get; set; }

        /// <summary>
        /// 客户姓名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 子申请单编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subapply_no")]
        public string SubapplyNo { get; set; }
    }
}
