using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromoItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PromoItemInfo : AopObject
    {
        /// <summary>
        /// 商品购买限制
        /// </summary>
        [Newtonsoft.Json.JsonProperty("constraint_info")]
        public ConstraintInfo ConstraintInfo { get; set; }

        /// <summary>
        /// 商品ID，用于领取时使用
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 商品售卖结束时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sale_end_time")]
        public string SaleEndTime { get; set; }

        /// <summary>
        /// 商品售卖的开始时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sale_start_time")]
        public string SaleStartTime { get; set; }

        /// <summary>
        /// 剩余库存
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_inventory")]
        public string TotalInventory { get; set; }

        /// <summary>
        /// 券信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("voucher")]
        public Voucher Voucher { get; set; }
    }
}
