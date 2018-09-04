using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiTradeItemorderBuyResponse.
    /// </summary>
    public class KoubeiTradeItemorderBuyResponse : AopResponse
    {
        /// <summary>
        /// 收银单id，唤收银台时传入，该参数为请求级别参数，如果二次支付，需要重新获取
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cashier_order_id")]
        public string CashierOrderId { get; set; }

        /// <summary>
        /// 口碑订单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 支付宝交易号，唤收银台时入参
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_no")]
        public string TradeNo { get; set; }
    }
}
