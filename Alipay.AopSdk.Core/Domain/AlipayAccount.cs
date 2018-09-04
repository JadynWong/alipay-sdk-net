using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAccount Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccount : AopObject
    {
        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 可用余额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 不可用余额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("freeze_amount")]
        public string FreezeAmount { get; set; }

        /// <summary>
        /// 余额总额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_amount")]
        public string TotalAmount { get; set; }
    }
}
