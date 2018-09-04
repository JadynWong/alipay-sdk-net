using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingExchangevoucherUseResponse.
    /// </summary>
    public class AlipayMarketingExchangevoucherUseResponse : AopResponse
    {
        /// <summary>
        /// 被核销的券ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("voucher_id")]
        public string VoucherId { get; set; }
    }
}
