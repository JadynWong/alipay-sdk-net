using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppProdmodeTasknodeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppProdmodeTasknodeQueryModel : AopObject
    {
        /// <summary>
        /// 任务编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_id")]
        public string TaskId { get; set; }
    }
}
