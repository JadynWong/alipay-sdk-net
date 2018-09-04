using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MaintainOrderStatusExtParams Data Structure.
    /// </summary>
    [Serializable]
    public class MaintainOrderStatusExtParams : AopObject
    {
        /// <summary>
        /// 编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 快递发货商
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logistics_company")]
        public string LogisticsCompany { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logistics_no")]
        public string LogisticsNo { get; set; }

        /// <summary>
        /// 4S订单状态
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_status_txt")]
        public string OrderStatusTxt { get; set; }

        /// <summary>
        /// 收货地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receiver_addr")]
        public string ReceiverAddr { get; set; }

        /// <summary>
        /// 发货地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sender_addr")]
        public string SenderAddr { get; set; }
    }
}
