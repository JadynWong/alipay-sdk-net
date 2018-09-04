using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingToolPointsQueryResponse.
    /// </summary>
    public class KoubeiMarketingToolPointsQueryResponse : AopResponse
    {
        /// <summary>
        /// 可用集点
        /// </summary>
        [Newtonsoft.Json.JsonProperty("available_points")]
        public string AvailablePoints { get; set; }

        /// <summary>
        /// 冻结集点
        /// </summary>
        [Newtonsoft.Json.JsonProperty("freezed_points")]
        public string FreezedPoints { get; set; }

        /// <summary>
        /// 累计集点
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_points")]
        public string TotalPoints { get; set; }
    }
}
