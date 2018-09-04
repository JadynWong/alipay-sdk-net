using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignCashListQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignCashListQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动列表
        /// </summary>
        [XmlArray("camp_list")]
        [XmlArrayItem("cash_campaign_info")]
        public List<CashCampaignInfo> CampList { get; set; }

        /// <summary>
        /// 分页的页码,起始从1开始
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_index")]
        public string PageIndex { get; set; }

        /// <summary>
        /// 分页每页大小
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 活动总个数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_size")]
        public string TotalSize { get; set; }
    }
}
