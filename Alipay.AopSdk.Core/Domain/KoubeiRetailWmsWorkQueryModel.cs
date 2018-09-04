using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiRetailWmsWorkQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsWorkQueryModel : AopObject
    {
        /// <summary>
        /// 操作上下文
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 作业id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("work_id")]
        public string WorkId { get; set; }
    }
}
