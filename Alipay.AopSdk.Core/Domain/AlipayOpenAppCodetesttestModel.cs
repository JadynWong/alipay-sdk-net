using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppCodetesttestModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppCodetesttestModel : AopObject
    {
        /// <summary>
        /// 测试参数1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("testparam")]
        public string Testparam { get; set; }

        /// <summary>
        /// 测试测试
        /// </summary>
        [Newtonsoft.Json.JsonProperty("testtestparam")]
        public string Testtestparam { get; set; }
    }
}
