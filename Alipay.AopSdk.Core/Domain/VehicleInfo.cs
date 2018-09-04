using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VehicleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VehicleInfo : AopObject
    {
        /// <summary>
        /// 保险公司ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("company_id")]
        public string CompanyId { get; set; }

        /// <summary>
        /// 保险公司对应的精友码（转码）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vehicle_code")]
        public string VehicleCode { get; set; }
    }
}
