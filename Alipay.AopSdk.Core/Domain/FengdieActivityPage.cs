using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FengdieActivityPage Data Structure.
    /// </summary>
    [Serializable]
    public class FengdieActivityPage : AopObject
    {
        /// <summary>
        /// H5页面唯一id，创建H5应用时自动生成
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// H5页面名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// H5页面schema数据
        /// </summary>
        [XmlArray("schema")]
        [XmlArrayItem("fengdie_activity_schema_data")]
        public List<FengdieActivitySchemaData> Schema { get; set; }

        /// <summary>
        /// H5页面预览图
        /// </summary>
        [Newtonsoft.Json.JsonProperty("snapshot")]
        public string Snapshot { get; set; }

        /// <summary>
        /// H5页面中文标题
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// H5页面访问地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        public string Url { get; set; }
    }
}
