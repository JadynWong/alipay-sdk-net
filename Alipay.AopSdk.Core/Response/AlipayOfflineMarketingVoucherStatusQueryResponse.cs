using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineMarketingVoucherStatusQueryResponse.
    /// </summary>
    public class AlipayOfflineMarketingVoucherStatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 券模板id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("voucher_id")]
        public string VoucherId { get; set; }

        /// <summary>
        /// 券模板状态。EFFECTIVE=生效，INVALID=失效。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("voucher_status")]
        public string VoucherStatus { get; set; }
    }
}
