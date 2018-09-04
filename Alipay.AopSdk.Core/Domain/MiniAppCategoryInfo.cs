using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniAppCategoryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniAppCategoryInfo : AopObject
    {
        /// <summary>
        /// 一级类目id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("first_category_id")]
        public string FirstCategoryId { get; set; }

        /// <summary>
        /// 一级类目名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("first_category_name")]
        public string FirstCategoryName { get; set; }

        /// <summary>
        /// 二级类目id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("second_category_id")]
        public string SecondCategoryId { get; set; }

        /// <summary>
        /// 二级类目名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("second_category_name")]
        public string SecondCategoryName { get; set; }
    }
}
