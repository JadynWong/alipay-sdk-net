using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpEntityMonitorUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpEntityMonitorUploadModel : AopObject
    {
        /// <summary>
        /// 监控实体列表（实体名，实体代码）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("entity_list")]
        public string EntityList { get; set; }

        /// <summary>
        /// 监控实体类别
        /// </summary>
        [Newtonsoft.Json.JsonProperty("entity_type")]
        public string EntityType { get; set; }

        /// <summary>
        /// 监控方案ID,可空
        /// </summary>
        [Newtonsoft.Json.JsonProperty("solution_id")]
        public string SolutionId { get; set; }

        /// <summary>
        /// 芝麻商户2688 ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("zhima_pid")]
        public string ZhimaPid { get; set; }
    }
}
