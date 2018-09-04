using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingEnterinfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingEnterinfoSyncModel : AopObject
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("car_number")]
        public string CarNumber { get; set; }

        /// <summary>
        /// 车辆入场的时间，格式"YYYY-MM-DD HH:mm:ss"，24小时制
        /// </summary>
        [Newtonsoft.Json.JsonProperty("in_time")]
        public string InTime { get; set; }

        /// <summary>
        /// 支付宝停车场ID ，系统唯一
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parking_id")]
        public string ParkingId { get; set; }
    }
}
