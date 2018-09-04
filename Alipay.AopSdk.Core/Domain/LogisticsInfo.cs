using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LogisticsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticsInfo : AopObject
    {
        /// <summary>
        /// 物流公司code
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 物流公司名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logistics_name")]
        public string LogisticsName { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logistics_no")]
        public string LogisticsNo { get; set; }
    }
}
