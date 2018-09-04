using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PortfolioShop Data Structure.
    /// </summary>
    [Serializable]
    public class PortfolioShop : AopObject
    {
        /// <summary>
        /// 展示权重；必须大于等于0；排序规则：权重倒叙
        /// </summary>
        [Newtonsoft.Json.JsonProperty("display_weight")]
        public long DisplayWeight { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
