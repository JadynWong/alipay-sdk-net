using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InstanceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InstanceInfo : AopObject
    {
        /// <summary>
        /// 内容
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 券失效时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 券开始生效时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 券id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instance_name")]
        public string InstanceName { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; }
    }
}
