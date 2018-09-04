using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoCplifeRepairStatusUpdateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCplifeRepairStatusUpdateModel : AopObject
    {
        /// <summary>
        /// 报修单状态明细
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_details")]
        public string BizDetails { get; set; }

        /// <summary>
        /// 当前报修单状态
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_state")]
        public string BizState { get; set; }

        /// <summary>
        /// 报修单ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("req_id")]
        public string ReqId { get; set; }
    }
}
