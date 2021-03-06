using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAssetPointOrderQueryResponse.
    /// </summary>
    public class AlipayAssetPointOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝集分宝发放流水号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 发放时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 支付宝集分宝发放者用户ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dispatch_user_id")]
        public string DispatchUserId { get; set; }

        /// <summary>
        /// 向用户展示集分宝发放备注
        /// </summary>
        [Newtonsoft.Json.JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// isv提供的发放号订单号，由数字和字母组成，最大长度为32为，需要保证每笔发放的唯一性，支付宝会对该参数做唯一性控制。如果使用同样的订单号，支付宝将返回订单号已经存在的错误
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 集分宝发放流水状态，I表示处理中，S表示成功，F表示失败
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 发放集分宝的数量
        /// </summary>
        [Newtonsoft.Json.JsonProperty("point_count")]
        public long PointCount { get; set; }

        /// <summary>
        /// 支付宝集分宝接收者用户ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receive_user_id")]
        public string ReceiveUserId { get; set; }
    }
}
