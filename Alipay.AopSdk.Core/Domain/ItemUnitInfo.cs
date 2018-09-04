using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemUnitInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemUnitInfo : AopObject
    {
        /// <summary>
        /// 商品详情-商品套餐内容-菜品数量
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 商品详情-商品套餐内容-菜品价格。字符串，单位元，两位小数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品详情-商品套餐内容-菜品规格
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spec")]
        public string Spec { get; set; }

        /// <summary>
        /// 商品详情-商品套餐内容-菜品名称。不得超过15个中文字符
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 商品详情-商品套餐内容-菜品数量单位
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unit")]
        public string Unit { get; set; }
    }
}
