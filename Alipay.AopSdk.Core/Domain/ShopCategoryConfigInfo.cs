using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopCategoryConfigInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopCategoryConfigInfo : AopObject
    {
        /// <summary>
        /// 类目ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 是否是叶子节点
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_leaf")]
        public string IsLeaf { get; set; }

        /// <summary>
        /// 类目层级
        /// </summary>
        [Newtonsoft.Json.JsonProperty("level")]
        public string Level { get; set; }

        /// <summary>
        /// 类目层级路径
        /// </summary>
        [Newtonsoft.Json.JsonProperty("link")]
        public string Link { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nm")]
        public string Nm { get; set; }
    }
}
