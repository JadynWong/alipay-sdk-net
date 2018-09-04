using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarMerchantshopCommentBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarMerchantshopCommentBatchqueryModel : AopObject
    {
        /// <summary>
        /// 当前页号（从1开始）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页数量，每页不超过100条。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_id")]
        public long ShopId { get; set; }
    }
}
