using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsDataDsbEstimateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsDataDsbEstimateQueryModel : AopObject
    {
        /// <summary>
        /// 定损单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("estimate_no")]
        public string EstimateNo { get; set; }

        /// <summary>
        /// 车架号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("frame_no")]
        public string FrameNo { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("license_no")]
        public string LicenseNo { get; set; }
    }
}
