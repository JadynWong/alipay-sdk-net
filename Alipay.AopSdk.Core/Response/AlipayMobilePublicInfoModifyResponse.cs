using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobilePublicInfoModifyResponse.
    /// </summary>
    public class AlipayMobilePublicInfoModifyResponse : AopResponse
    {
        /// <summary>
        /// 服务窗审核状态描述，如果审核驳回则有相关的驳回理由
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_desc")]
        public string AuditDesc { get; set; }

        /// <summary>
        /// 服务窗审核状态，对于系统商而言，只有三个状态，AUDITING：审核中，AUDIT_FAILED：审核驳回，AUDIT_SUCCESS：审核通过。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_status")]
        public string AuditStatus { get; set; }
    }
}
