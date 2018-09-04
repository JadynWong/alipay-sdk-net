using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsMktCouponCmpgnBaseDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsMktCouponCmpgnBaseDTO : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// 权益类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_type")]
        public string CouponType { get; set; }

        /// <summary>
        /// 权益盖帽值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_upper_value")]
        public string CouponUpperValue { get; set; }

        /// <summary>
        /// 权益值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_value")]
        public string CouponValue { get; set; }
    }
}
