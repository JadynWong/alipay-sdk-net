using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaMerchantOrderRentCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantOrderRentCancelModel : AopObject
    {
        /// <summary>
        /// 信用借还订单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 信用借还的产品码:w1010100000000002858
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_code")]
        public string ProductCode { get; set; }
    }
}
