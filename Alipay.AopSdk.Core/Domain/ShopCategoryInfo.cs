using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopCategoryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopCategoryInfo : AopObject
    {
        /// <summary>
        /// 类目编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 类目层级,目前最多支持1、2、3三级
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_level")]
        public string CategoryLevel { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_name")]
        public string CategoryName { get; set; }
    }
}
