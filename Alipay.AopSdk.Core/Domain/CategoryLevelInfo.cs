using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CategoryLevelInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CategoryLevelInfo : AopObject
    {
        /// <summary>
        /// 品类编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 品类级别
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_level")]
        public long CategoryLevel { get; set; }

        /// <summary>
        /// 品类名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_name")]
        public string CategoryName { get; set; }
    }
}
