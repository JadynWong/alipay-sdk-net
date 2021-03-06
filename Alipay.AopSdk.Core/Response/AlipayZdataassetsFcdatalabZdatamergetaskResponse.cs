using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayZdataassetsFcdatalabZdatamergetaskResponse.
    /// </summary>
    public class AlipayZdataassetsFcdatalabZdatamergetaskResponse : AopResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        public string Result { get; set; }
    }
}
