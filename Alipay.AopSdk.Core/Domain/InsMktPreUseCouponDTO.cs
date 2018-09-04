using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsMktPreUseCouponDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsMktPreUseCouponDTO : AopObject
    {
        /// <summary>
        /// 资产Id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 权益id
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

        /// <summary>
        /// 是否支持预核销
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pre_use")]
        public bool PreUse { get; set; }

        /// <summary>
        /// 预核销失败原因
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
