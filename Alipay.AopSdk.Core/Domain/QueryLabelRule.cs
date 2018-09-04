using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QueryLabelRule Data Structure.
    /// </summary>
    [Serializable]
    public class QueryLabelRule : AopObject
    {
        /// <summary>
        /// 标签id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("label_id")]
        public string LabelId { get; set; }

        /// <summary>
        /// 标签名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("label_name")]
        public string LabelName { get; set; }

        /// <summary>
        /// 标签值，多值会用英文逗号分隔
        /// </summary>
        [Newtonsoft.Json.JsonProperty("label_value")]
        public string LabelValue { get; set; }

        /// <summary>
        /// 运算符
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator")]
        public string Operator { get; set; }
    }
}
