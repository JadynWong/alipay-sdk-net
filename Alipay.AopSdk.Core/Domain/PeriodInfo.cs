using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PeriodInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PeriodInfo : AopObject
    {
        /// <summary>
        /// 单位
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dimension")]
        public string Dimension { get; set; }

        /// <summary>
        /// 周期值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("value")]
        public long Value { get; set; }
    }
}
