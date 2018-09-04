using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiRetailWmsInboundworkConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsInboundworkConfirmModel : AopObject
    {
        /// <summary>
        /// 入库作业id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inbound_work_id")]
        public string InboundWorkId { get; set; }

        /// <summary>
        /// 操作上下文
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        public string Remark { get; set; }
    }
}
