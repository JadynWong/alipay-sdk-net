using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbAdvertMissionResponse Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertMissionResponse : AopObject
    {
        /// <summary>
        /// 任务领取时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gmt_claimed")]
        public string GmtClaimed { get; set; }

        /// <summary>
        /// 任务结束时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 任务开始时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mission_id")]
        public string MissionId { get; set; }

        /// <summary>
        /// 推广状态  EFFECTIVE-有效  INVALID-无效
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promote_status")]
        public string PromoteStatus { get; set; }

        /// <summary>
        /// 任务标的列表
        /// </summary>
        [XmlArray("subjects")]
        [XmlArrayItem("kb_advert_subject_response")]
        public List<KbAdvertSubjectResponse> Subjects { get; set; }
    }
}
