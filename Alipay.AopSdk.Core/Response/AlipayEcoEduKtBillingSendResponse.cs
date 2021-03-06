using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoEduKtBillingSendResponse.
    /// </summary>
    public class AlipayEcoEduKtBillingSendResponse : AopResponse
    {
        /// <summary>
        /// 支付宝－中小学－教育缴费的账单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_no")]
        public string OrderNo { get; set; }
    }
}
