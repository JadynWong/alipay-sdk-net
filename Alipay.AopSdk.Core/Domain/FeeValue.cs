using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FeeValue Data Structure.
    /// </summary>
    [Serializable]
    public class FeeValue : AopObject
    {
        /// <summary>
        /// 保底费率
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bottom_cent")]
        public string BottomCent { get; set; }

        /// <summary>
        /// 币种（如人民币是156）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// 固定费额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fix_cent")]
        public string FixCent { get; set; }

        /// <summary>
        /// 最小费率
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lower")]
        public string Lower { get; set; }

        /// <summary>
        /// 费率比例单位。  ONE("RO", "ONE", "一", "一"),  ONE_HUNDREDTH("RP", "ONE_HUNDREDTH", "百分之一", "百分之一"),  ONE_THOUSANDTH("RM", "ONE_THOUSANDTH", "千分之一", "千分之一"),  ONE_TEN_THOUSANDTH("RT", "ONE_TEN_THOUSANDTH", "万分之一", "万分之一");
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rate_unit")]
        public string RateUnit { get; set; }

        /// <summary>
        /// 费率值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rate_value")]
        public string RateValue { get; set; }

        /// <summary>
        /// 封顶费额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("top_cent")]
        public string TopCent { get; set; }

        /// <summary>
        /// 最大费率
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upper")]
        public string Upper { get; set; }
    }
}
