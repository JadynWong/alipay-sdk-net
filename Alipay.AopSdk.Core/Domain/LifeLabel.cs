using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LifeLabel Data Structure.
    /// </summary>
    [Serializable]
    public class LifeLabel : AopObject
    {
        /// <summary>
        /// 该标签支持的业务列表，menu表示个性化菜单，extension表示个性化扩展区，message表示消息触达
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz")]
        public string Biz { get; set; }

        /// <summary>
        /// 标签类目
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// 标签值数据类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 标签英文代码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("label_code")]
        public string LabelCode { get; set; }

        /// <summary>
        /// 标签id，唯一标识一个标签
        /// </summary>
        [Newtonsoft.Json.JsonProperty("label_id")]
        public string LabelId { get; set; }

        /// <summary>
        /// 标签名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("label_name")]
        public string LabelName { get; set; }

        /// <summary>
        /// 该标签支持的运算符
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 每个取值的业务含义
        /// </summary>
        [XmlArray("options")]
        [XmlArrayItem("option")]
        public List<Option> Options { get; set; }

        /// <summary>
        /// 标签类型，目前分为common（通用标签）、custom（生活号自定义标签）、cloud（云实验室标签）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; }
    }
}
