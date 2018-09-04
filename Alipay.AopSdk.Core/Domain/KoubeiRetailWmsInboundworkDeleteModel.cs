using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiRetailWmsInboundworkDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsInboundworkDeleteModel : AopObject
    {
        /// <summary>
        /// 入库作业id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inbound_work_id")]
        public string InboundWorkId { get; set; }

        /// <summary>
        /// 操作者上下文
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operate_context")]
        public OperateContext OperateContext { get; set; }
    }
}
