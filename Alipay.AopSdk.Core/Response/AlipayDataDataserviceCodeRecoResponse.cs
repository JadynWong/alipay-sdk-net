using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceCodeRecoResponse.
    /// </summary>
    public class AlipayDataDataserviceCodeRecoResponse : AopResponse
    {
        /// <summary>
        /// 识别结果
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        public AlipayCodeRecoResult Result { get; set; }
    }
}
