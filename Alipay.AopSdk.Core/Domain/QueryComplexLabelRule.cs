using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QueryComplexLabelRule Data Structure.
    /// </summary>
    [Serializable]
    public class QueryComplexLabelRule : AopObject
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
        /// 当有多个取值时用英文","分隔，不允许传入下划线"_"、竖线"|"或者空格" "
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
