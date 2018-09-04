using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiAdvertDataPromotedetailChannelBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiAdvertDataPromotedetailChannelBatchqueryModel : AopObject
    {
        /// <summary>
        /// 广告id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adv_id")]
        public string AdvId { get; set; }

        /// <summary>
        /// 渠道id(不传查所有id)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 结束时间(精确到天)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 每页大小(分页参数)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 开始时间(精确到天)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_date")]
        public string StartDate { get; set; }
    }
}
