using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarDataserviceMaintainvehicleShareModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarDataserviceMaintainvehicleShareModel : AopObject
    {
        /// <summary>
        /// 车辆ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vid")]
        public string Vid { get; set; }
    }
}
