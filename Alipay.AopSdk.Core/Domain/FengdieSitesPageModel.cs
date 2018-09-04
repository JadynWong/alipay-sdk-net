using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FengdieSitesPageModel Data Structure.
    /// </summary>
    [Serializable]
    public class FengdieSitesPageModel : AopObject
    {
        /// <summary>
        /// 站点页面别名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// 活动页面 schema 数据
        /// </summary>
        [XmlArray("schema")]
        [XmlArrayItem("fengdie_activity_schema_model")]
        public List<FengdieActivitySchemaModel> Schema { get; set; }

        /// <summary>
        /// H5页面预览图
        /// </summary>
        [Newtonsoft.Json.JsonProperty("snapshot")]
        public string Snapshot { get; set; }

        /// <summary>
        /// 页面访问地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        public string Url { get; set; }
    }
}
