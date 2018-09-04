using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZolozIdentificationCustomerCertifyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZolozIdentificationCustomerCertifyQueryModel : AopObject
    {
        /// <summary>
        /// 业务单据号，用于核对和排查
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// zimId，用于查询认证结果
        /// </summary>
        [Newtonsoft.Json.JsonProperty("zim_id")]
        public string ZimId { get; set; }
    }
}
