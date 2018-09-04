using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceDeployorderResultSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceDeployorderResultSendModel : AopObject
    {
        /// <summary>
        /// 部署单记录id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 处理结果
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        public string Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success")]
        public bool Success { get; set; }
    }
}
