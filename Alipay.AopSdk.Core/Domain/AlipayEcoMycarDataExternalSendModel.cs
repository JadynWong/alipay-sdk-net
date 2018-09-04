using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarDataExternalSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarDataExternalSendModel : AopObject
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
        public string IsTransferUid { get; set; }

        /// <summary>
        /// operate_type
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// send_data
        /// </summary>
        [Newtonsoft.Json.JsonProperty("send_data")]
        public string SendData { get; set; }
    }
}
