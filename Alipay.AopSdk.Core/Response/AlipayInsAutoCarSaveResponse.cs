using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsAutoCarSaveResponse.
    /// </summary>
    public class AlipayInsAutoCarSaveResponse : AopResponse
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("car_no")]
        public string CarNo { get; set; }
    }
}
