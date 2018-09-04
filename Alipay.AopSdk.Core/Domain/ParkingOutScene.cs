using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ParkingOutScene Data Structure.
    /// </summary>
    [Serializable]
    public class ParkingOutScene : AopObject
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("car_number")]
        public string CarNumber { get; set; }

        /// <summary>
        /// 停车费用
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fee")]
        public string Fee { get; set; }

        /// <summary>
        /// 出场时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_time")]
        public string OutTime { get; set; }

        /// <summary>
        /// 停车场id
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
