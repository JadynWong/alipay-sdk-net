using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromoteDetailChannelModel Data Structure.
    /// </summary>
    [Serializable]
    public class PromoteDetailChannelModel : AopObject
    {
        /// <summary>
        /// 渠道id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_name")]
        public string ChannelName { get; set; }

        /// <summary>
        /// 查询时间段内的推广数据
        /// </summary>
        [Newtonsoft.Json.JsonProperty("part_promote_data")]
        public PromoteDataModel PartPromoteData { get; set; }

        /// <summary>
        /// 总推广数据
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_promote_data")]
        public PromoteDataModel TotalPromoteData { get; set; }
    }
}
