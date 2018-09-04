using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppRechargeNotifySendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppRechargeNotifySendModel : AopObject
    {
        /// <summary>
        /// 充值面额或者优惠面额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("face_price")]
        public string FacePrice { get; set; }

        /// <summary>
        /// 充值时间或者话费券有效时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gmt_charge")]
        public string GmtCharge { get; set; }

        /// <summary>
        /// 充值的手机号码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 阿里通信通知类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_type")]
        public string NotifyType { get; set; }

        /// <summary>
        /// 外部用户id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 充值交易号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
