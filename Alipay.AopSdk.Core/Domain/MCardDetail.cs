using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MCardDetail Data Structure.
    /// </summary>
    [Serializable]
    public class MCardDetail : AopObject
    {
        /// <summary>
        /// 储值卡可用余额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 储值卡名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 储值卡支付金额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_amount")]
        public string PayAmount { get; set; }
    }
}
