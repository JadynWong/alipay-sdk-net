using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingOrderPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingOrderPayModel : AopObject
    {
        /// <summary>
        /// 代扣返佣的支付宝用户号。  以2088开头的纯16位数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 订单描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("body")]
        public string Body { get; set; }

        /// <summary>
        /// 车牌，需要进行停车缴费代扣的车辆牌照
        /// </summary>
        [Newtonsoft.Json.JsonProperty("car_number")]
        public string CarNumber { get; set; }

        /// <summary>
        /// 车牌颜色
        /// </summary>
        [Newtonsoft.Json.JsonProperty("car_number_color")]
        public string CarNumberColor { get; set; }

        /// <summary>
        /// ISV停车场ID，由ISV定义的停车场标识，系统唯一，parking_id和out_parking_id不能同时为空
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_parking_id")]
        public string OutParkingId { get; set; }

        /// <summary>
        /// 支付宝合作商户网站唯一订单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付宝停车平台ID，由支付宝定义的该停车场标识，系统唯一, parking_id和out_parking_id不能同时为空
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parking_id")]
        public string ParkingId { get; set; }

        /// <summary>
        /// 卖家支付宝用户号  卖家支付宝账号对应的支付宝唯一用户号。  以2088开头的纯16位数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 卖家支付宝账号，可以为email或者手机号。  如果seller_id不为空，则以seller_id的值作为卖家账号，忽略本参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seller_logon_id")]
        public string SellerLogonId { get; set; }

        /// <summary>
        /// 订单标题，描述订单用途
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 订单金额，精确到小数点后两位
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_fee")]
        public string TotalFee { get; set; }
    }
}
