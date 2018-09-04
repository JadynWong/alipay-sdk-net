using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineMarketShopSummaryBatchqueryResponse.
    /// </summary>
    public class AlipayOfflineMarketShopSummaryBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("current_page_no")]
        public string CurrentPageNo { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 支付宝门店摘要信息列表
        /// </summary>
        [XmlArray("shop_summary_infos")]
        [XmlArrayItem("shop_summary_query_response")]
        public List<ShopSummaryQueryResponse> ShopSummaryInfos { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_items")]
        public string TotalItems { get; set; }

        /// <summary>
        /// 总页码数目
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_page_no")]
        public string TotalPageNo { get; set; }
    }
}
