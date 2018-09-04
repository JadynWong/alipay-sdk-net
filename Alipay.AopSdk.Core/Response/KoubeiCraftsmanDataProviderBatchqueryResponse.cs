using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCraftsmanDataProviderBatchqueryResponse.
    /// </summary>
    public class KoubeiCraftsmanDataProviderBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// craftsmans:手艺人信息
        /// </summary>
        [XmlArray("craftsmans")]
        [XmlArrayItem("craftsman_open_model")]
        public List<CraftsmanOpenModel> Craftsmans { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("current_page_no")]
        public long CurrentPageNo { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 门店下共手艺人数目
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_craftsmans")]
        public long TotalCraftsmans { get; set; }

        /// <summary>
        /// 总页码数目
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_page_no")]
        public long TotalPageNo { get; set; }
    }
}
