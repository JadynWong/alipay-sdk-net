using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsMktCouponDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsMktCouponDTO : AopObject
    {
        /// <summary>
        /// 权益资产Id，如券Id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("asset_id")]
        public string AssetId { get; set; }

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
        /// 500元单品券
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_value")]
        public string CouponValue { get; set; }

        /// <summary>
        /// 是否推荐使用该优惠
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recommend")]
        public bool Recommend { get; set; }

        /// <summary>
        /// 核销结束时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("use_end_time")]
        public string UseEndTime { get; set; }

        /// <summary>
        /// 核销规则
        /// </summary>
        [Newtonsoft.Json.JsonProperty("use_rule")]
        public string UseRule { get; set; }

        /// <summary>
        /// 核销开始时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("use_start_time")]
        public string UseStartTime { get; set; }
    }
}
