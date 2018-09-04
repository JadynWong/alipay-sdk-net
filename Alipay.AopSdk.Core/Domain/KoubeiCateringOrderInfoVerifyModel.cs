using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringOrderInfoVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringOrderInfoVerifyModel : AopObject
    {
        /// <summary>
        /// 店铺ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 用户核销码中的核销数值串
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verify_order_id")]
        public string VerifyOrderId { get; set; }
    }
}
