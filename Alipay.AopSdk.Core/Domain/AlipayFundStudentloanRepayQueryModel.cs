using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundStudentloanRepayQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundStudentloanRepayQueryModel : AopObject
    {
        /// <summary>
        /// 还款学生的身份证号码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 还款学生的支付宝账号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logon_id")]
        public string LogonId { get; set; }
    }
}
