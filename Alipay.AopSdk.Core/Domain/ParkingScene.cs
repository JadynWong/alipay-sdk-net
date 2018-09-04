using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ParkingScene Data Structure.
    /// </summary>
    [Serializable]
    public class ParkingScene : AopObject
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
        /// 停车场ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parking_id")]
        public string ParkingId { get; set; }

        /// <summary>
        /// 停车场名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parking_name")]
        public string ParkingName { get; set; }
    }
}
