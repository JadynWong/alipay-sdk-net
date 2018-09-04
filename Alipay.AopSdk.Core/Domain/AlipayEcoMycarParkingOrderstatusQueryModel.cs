using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingOrderstatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingOrderstatusQueryModel : AopObject
    {
        /// <summary>
        /// 如果商户订单号为空，停车场id和车牌号不能为空，商户订单号优先查询
        /// </summary>
        [Newtonsoft.Json.JsonProperty("car_number")]
        public string CarNumber { get; set; }

        /// <summary>
        /// 如果商户订单号为空，停车场id和车牌号不能为空，商户订单号优先查询
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parking_id")]
        public string ParkingId { get; set; }

        /// <summary>
        /// 查询订单时间（不传值为当日时间），格式"yyyy-MM-dd “
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sel_time")]
        public string SelTime { get; set; }

        /// <summary>
        /// 车主平台交易号，不能跟停车场编号和车牌号同时为空
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_no")]
        public string TransactionNo { get; set; }
    }
}
