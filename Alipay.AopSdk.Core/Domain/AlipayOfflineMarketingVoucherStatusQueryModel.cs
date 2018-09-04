using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketingVoucherStatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketingVoucherStatusQueryModel : AopObject
    {
        /// <summary>
        /// 外部流水号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 券模板id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("voucher_id")]
        public string VoucherId { get; set; }
    }
}
