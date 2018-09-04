using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiServindustryPortfolioShopBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiServindustryPortfolioShopBatchqueryModel : AopObject
    {
        /// <summary>
        /// 插件id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commodity_id")]
        public string CommodityId { get; set; }

        /// <summary>
        /// 当前页码；页码必须大于等于1；最大值：100
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页大小;默认值：20；最大值：100
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
