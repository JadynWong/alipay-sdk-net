using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdArrangementOfflineQueryResponse.
    /// </summary>
    public class AlipayBossProdArrangementOfflineQueryResponse : AopResponse
    {
        /// <summary>
        /// 商户的签约状态
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign_status")]
        public string SignStatus { get; set; }
    }
}
