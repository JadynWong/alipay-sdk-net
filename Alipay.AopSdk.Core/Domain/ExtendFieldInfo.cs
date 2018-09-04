using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExtendFieldInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExtendFieldInfo : AopObject
    {
        /// <summary>
        /// 字段名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("field_name")]
        public string FieldName { get; set; }

        /// <summary>
        /// 字段值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("field_value")]
        public string FieldValue { get; set; }
    }
}
