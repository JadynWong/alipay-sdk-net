using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExtCategory Data Structure.
    /// </summary>
    [Serializable]
    public class ExtCategory : AopObject
    {
        /// <summary>
        /// 品类编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 品类名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 父品类编码。顶级类目此值为0
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parent_id")]
        public string ParentId { get; set; }
    }
}
