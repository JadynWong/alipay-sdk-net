using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSmsgDataSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSmsgDataSetModel : AopObject
    {
        /// <summary>
        /// 测试
        /// </summary>
        [Newtonsoft.Json.JsonProperty("paramone")]
        public string Paramone { get; set; }

        /// <summary>
        /// 测试参数2
        /// </summary>
        [Newtonsoft.Json.JsonProperty("paramtwo")]
        public string Paramtwo { get; set; }
    }
}
