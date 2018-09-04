using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarDataserviceViolationinfoShareResponse.
    /// </summary>
    public class AlipayEcoMycarDataserviceViolationinfoShareResponse : AopResponse
    {
        /// <summary>
        /// 车架号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("body_num")]
        public string BodyNum { get; set; }

        /// <summary>
        /// 发动机号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("engine_num")]
        public string EngineNum { get; set; }

        /// <summary>
        /// 车辆id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vehicle_id")]
        public string VehicleId { get; set; }

        /// <summary>
        /// 车牌
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vi_number")]
        public string ViNumber { get; set; }
    }
}
