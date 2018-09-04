using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DepartmentLabel Data Structure.
    /// </summary>
    [Serializable]
    public class DepartmentLabel : AopObject
    {
        /// <summary>
        /// 部门标签码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 部门标签id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("label_id")]
        public string LabelId { get; set; }

        /// <summary>
        /// 部门标签名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }
    }
}
