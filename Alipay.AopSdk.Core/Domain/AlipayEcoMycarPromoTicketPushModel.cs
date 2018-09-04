using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarPromoTicketPushModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarPromoTicketPushModel : AopObject
    {
        /// <summary>
        /// 核销流水
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 核销状态，0：成功，1：失败
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apply_status")]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// 对应TP活动码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_no")]
        public string CodeNo { get; set; }

        /// <summary>
        /// 券ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ticket_id")]
        public string TicketId { get; set; }
    }
}
