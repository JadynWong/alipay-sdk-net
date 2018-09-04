using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SimpleMockModel Data Structure.
    /// </summary>
    [Serializable]
    public class SimpleMockModel : AopObject
    {
        /// <summary>
        /// 11
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count_items")]
        public long CountItems { get; set; }

        /// <summary>
        /// 111
        /// </summary>
        [Newtonsoft.Json.JsonProperty("happen_time")]
        public string HappenTime { get; set; }

        /// <summary>
        /// 1.2f
        /// </summary>
        [Newtonsoft.Json.JsonProperty("price_num")]
        public string PriceNum { get; set; }

        /// <summary>
        /// false
        /// </summary>
        [Newtonsoft.Json.JsonProperty("right")]
        public bool Right { get; set; }

        /// <summary>
        /// trade_no
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_no")]
        public string TradeNo { get; set; }
    }
}
