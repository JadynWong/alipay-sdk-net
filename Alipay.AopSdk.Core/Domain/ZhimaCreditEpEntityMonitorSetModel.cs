using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpEntityMonitorSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpEntityMonitorSetModel : AopObject
    {
        /// <summary>
        /// 联系人列表
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact_list")]
        public string ContactList { get; set; }

        /// <summary>
        /// 方案ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("solution_id")]
        public string SolutionId { get; set; }
    }
}
