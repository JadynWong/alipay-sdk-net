using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenActivity Data Structure.
    /// </summary>
    [Serializable]
    public class OpenActivity : AopObject
    {
        /// <summary>
        /// 活动结束时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_end_date")]
        public string ActivityEndDate { get; set; }

        /// <summary>
        /// 活动id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_start_date")]
        public string ActivityStartDate { get; set; }

        /// <summary>
        /// 活动验证状态  0，未检测  1，未通过  2，已通过
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_status")]
        public string ActivityStatus { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_id")]
        public string StoreId { get; set; }
    }
}
