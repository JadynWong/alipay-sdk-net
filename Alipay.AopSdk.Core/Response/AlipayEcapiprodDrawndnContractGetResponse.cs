using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcapiprodDrawndnContractGetResponse.
    /// </summary>
    public class AlipayEcapiprodDrawndnContractGetResponse : AopResponse
    {
        /// <summary>
        /// 合同的内容文本 String 合同的内容文本，为HTML格式
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_content")]
        public string ContractContent { get; set; }

        /// <summary>
        /// 合同编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 唯一标识这次请求
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_id")]
        public string RequestId { get; set; }
    }
}
