using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InventoryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InventoryInfo : AopObject
    {
        /// <summary>
        /// 资产数量
        /// </summary>
        [Newtonsoft.Json.JsonProperty("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 资产类型id编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sku_id")]
        public string SkuId { get; set; }
    }
}
