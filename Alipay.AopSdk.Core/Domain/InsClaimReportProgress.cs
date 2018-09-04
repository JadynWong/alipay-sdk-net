using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsClaimReportProgress Data Structure.
    /// </summary>
    [Serializable]
    public class InsClaimReportProgress : AopObject
    {
        /// <summary>
        /// 案件更新内容
        /// </summary>
        [Newtonsoft.Json.JsonProperty("progress_update_content")]
        public string ProgressUpdateContent { get; set; }

        /// <summary>
        /// 案件更新进度时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("progress_update_time")]
        public string ProgressUpdateTime { get; set; }

        /// <summary>
        /// 进度状态
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; }
    }
}
