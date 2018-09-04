using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbdishAreaFreeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishAreaFreeInfo : AopObject
    {
        /// <summary>
        /// 餐区id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("area_id")]
        public string AreaId { get; set; }

        /// <summary>
        /// 份数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count")]
        public string Count { get; set; }

        /// <summary>
        /// 口碑菜品id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// sku_id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dish_sku_id")]
        public string DishSkuId { get; set; }

        /// <summary>
        /// open 启动 stop 停用
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; }
    }
}
