using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingExitinfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingExitinfoSyncModel : AopObject
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("car_number")]
        public string CarNumber { get; set; }

        /// <summary>
        /// 车辆离场时间，格式"YYYY-MM-DD HH:mm:ss"，24小时制
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_time")]
        public string OutTime { get; set; }

        /// <summary>
        /// 支付宝停车场ID，系统唯一
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parking_id")]
        public string ParkingId { get; set; }
    }
}
