using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineMarketingVoucherModifyResponse.
    /// </summary>
    public class AlipayOfflineMarketingVoucherModifyResponse : AopResponse
    {
        /// <summary>
        /// 券id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("voucher_id")]
        public string VoucherId { get; set; }

        /// <summary>
        /// 券模板状态,EFFECTIVE=生效，INVALID=失效
        /// </summary>
        [Newtonsoft.Json.JsonProperty("voucher_status")]
        public string VoucherStatus { get; set; }
    }
}
