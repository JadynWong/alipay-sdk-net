using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaymentAbilityPostbackResponse Data Structure.
    /// </summary>
    [Serializable]
    public class PaymentAbilityPostbackResponse : AopObject
    {
        /// <summary>
        /// 错误的订单信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error_order")]
        public string ErrorOrder { get; set; }

        /// <summary>
        /// 成功的订单列表,逗号分隔
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_ids")]
        public string OrderIds { get; set; }
    }
}
