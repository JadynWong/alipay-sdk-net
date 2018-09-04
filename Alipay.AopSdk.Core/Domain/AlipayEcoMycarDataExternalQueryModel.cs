using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarDataExternalQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarDataExternalQueryModel : AopObject
    {
        /// <summary>
        /// external_system_name
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_system_name")]
        public string ExternalSystemName { get; set; }

        /// <summary>
        /// is_transfer_uid
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_transfer_uid")]
        public bool IsTransferUid { get; set; }

        /// <summary>
        /// operate_type
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// query_condition
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query_condition")]
        public string QueryCondition { get; set; }
    }
}
