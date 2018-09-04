using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcardEduPublicBindResponse.
    /// </summary>
    public class AlipayEcardEduPublicBindResponse : AopResponse
    {
        /// <summary>
        /// 机构编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agent_code")]
        public string AgentCode { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_code")]
        public string ReturnCode { get; set; }
    }
}
