using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingDataEquitySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingDataEquitySyncModel : AopObject
    {
        /// <summary>
        /// biz_time
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// equity_code
        /// </summary>
        [Newtonsoft.Json.JsonProperty("equity_code")]
        public string EquityCode { get; set; }

        /// <summary>
        /// equity_from
        /// </summary>
        [Newtonsoft.Json.JsonProperty("equity_from")]
        public string EquityFrom { get; set; }

        /// <summary>
        /// equity_id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("equity_id")]
        public string EquityId { get; set; }

        /// <summary>
        /// equity_info
        /// </summary>
        [Newtonsoft.Json.JsonProperty("equity_info")]
        public EquityInfo EquityInfo { get; set; }

        /// <summary>
        /// original_biz_no
        /// </summary>
        [Newtonsoft.Json.JsonProperty("original_biz_no")]
        public string OriginalBizNo { get; set; }

        /// <summary>
        /// original_biz_type
        /// </summary>
        [Newtonsoft.Json.JsonProperty("original_biz_type")]
        public string OriginalBizType { get; set; }

        /// <summary>
        /// out_biz_no
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付宝userid
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
