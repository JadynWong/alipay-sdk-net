using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiTradeTicketTicketcodeSendResponse.
    /// </summary>
    public class KoubeiTradeTicketTicketcodeSendResponse : AopResponse
    {
        /// <summary>
        /// 该字段用于描述本次返回中的业务属性，现有：BIZ_ALREADY_SUCCESS（幂等业务码）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 请求id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_id")]
        public string RequestId { get; set; }
    }
}
