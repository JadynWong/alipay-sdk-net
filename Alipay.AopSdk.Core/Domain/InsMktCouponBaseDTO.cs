using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsMktCouponBaseDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsMktCouponBaseDTO : AopObject
    {
        /// <summary>
        /// 权益Id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_id")]
        public string CouponId { get; set; }

        /// <summary>
        /// 权益类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_type")]
        public string CouponType { get; set; }

        /// <summary>
        /// 权益值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_value")]
        public string CouponValue { get; set; }
    }
}
