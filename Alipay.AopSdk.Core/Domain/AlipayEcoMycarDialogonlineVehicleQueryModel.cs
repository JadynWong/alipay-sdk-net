using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarDialogonlineVehicleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarDialogonlineVehicleQueryModel : AopObject
    {
        /// <summary>
        /// 车辆ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vi_id")]
        public string ViId { get; set; }
    }
}
