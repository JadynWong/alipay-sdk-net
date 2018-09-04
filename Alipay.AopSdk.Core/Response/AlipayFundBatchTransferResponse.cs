using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundBatchTransferResponse.
    /// </summary>
    public class AlipayFundBatchTransferResponse : AopResponse
    {
        /// <summary>
        /// 商户请求的批次流水号，同请求中的"batch_no"。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 支付宝系统内部批次请求id。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_trans_id")]
        public string BatchTransId { get; set; }
    }
}
