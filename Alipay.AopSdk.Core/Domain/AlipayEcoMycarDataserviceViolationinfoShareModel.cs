using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarDataserviceViolationinfoShareModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarDataserviceViolationinfoShareModel : AopObject
    {
        /// <summary>
        /// 支付宝app_id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// 车辆id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vehicle_id")]
        public string VehicleId { get; set; }
    }
}
