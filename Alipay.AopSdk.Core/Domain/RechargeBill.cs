using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RechargeBill Data Structure.
    /// </summary>
    [Serializable]
    public class RechargeBill : AopObject
    {
        /// <summary>
        /// 用户充值金额，单位为元
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 充值时间：YYYY-MM-DD hh:mm:ss
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deposit_time")]
        public string DepositTime { get; set; }

        /// <summary>
        /// Transfer：待圈存  Success：圈存成功  Fail：圈存失败
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_no")]
        public string TradeNo { get; set; }
    }
}
