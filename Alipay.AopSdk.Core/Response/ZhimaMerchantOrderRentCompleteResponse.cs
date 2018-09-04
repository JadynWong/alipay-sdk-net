using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantOrderRentCompleteResponse.
    /// </summary>
    public class ZhimaMerchantOrderRentCompleteResponse : AopResponse
    {
        /// <summary>
        /// 资金流水号，用于商户与支付宝进行对账
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alipay_fund_order_no")]
        public string AlipayFundOrderNo { get; set; }

        /// <summary>
        /// 信用借还的订单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 借用人支付宝userId.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
