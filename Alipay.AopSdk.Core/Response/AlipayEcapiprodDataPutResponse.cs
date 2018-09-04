using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcapiprodDataPutResponse.
    /// </summary>
    public class AlipayEcapiprodDataPutResponse : AopResponse
    {
        /// <summary>
        /// 数据版本
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data_version")]
        public string DataVersion { get; set; }
    }
}
