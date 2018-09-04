using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CodeNOList Data Structure.
    /// </summary>
    [Serializable]
    public class CodeNOList : AopObject
    {
        /// <summary>
        /// 金额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 对应TP活动码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_no")]
        public string CodeNo { get; set; }

        /// <summary>
        /// 如果ticket_type为油券，则该字段1:石化，2:石油
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_type")]
        public string SubType { get; set; }

        /// <summary>
        /// 券类型,1:油券
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ticket_type")]
        public string TicketType { get; set; }

        /// <summary>
        /// 有效期
        /// </summary>
        [Newtonsoft.Json.JsonProperty("valid_date")]
        public string ValidDate { get; set; }
    }
}
