using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsClaimReport Data Structure.
    /// </summary>
    [Serializable]
    public class InsClaimReport : AopObject
    {
        /// <summary>
        /// 出险地点
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accident_address")]
        public string AccidentAddress { get; set; }

        /// <summary>
        /// 出险事故描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accident_desc")]
        public string AccidentDesc { get; set; }

        /// <summary>
        /// 出险时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accident_time")]
        public string AccidentTime { get; set; }

        /// <summary>
        /// 案件附件列表
        /// </summary>
        [XmlArray("attachments")]
        [XmlArrayItem("ins_claim_attachment")]
        public List<InsClaimAttachment> Attachments { get; set; }

        /// <summary>
        /// 业务字段
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 报案号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("claim_report_no")]
        public string ClaimReportNo { get; set; }

        /// <summary>
        /// 赔案信息
        /// </summary>
        [XmlArray("claims")]
        [XmlArrayItem("ins_claim")]
        public List<InsClaim> Claims { get; set; }

        /// <summary>
        /// 案件进度列表
        /// </summary>
        [XmlArray("progress")]
        [XmlArrayItem("ins_claim_report_progress")]
        public List<InsClaimReportProgress> Progress { get; set; }

        /// <summary>
        /// 当status 值为不予受理:REJECTED时候返回
        /// </summary>
        [Newtonsoft.Json.JsonProperty("report_reject_reason")]
        public string ReportRejectReason { get; set; }

        /// <summary>
        /// 报案人
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reporter")]
        public InsPerson Reporter { get; set; }

        /// <summary>
        /// 案件状态
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; }
    }
}
