using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossCsDatacollectSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossCsDatacollectSendModel : AopObject
    {
        /// <summary>
        /// 上数提交数据内容
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        public string Content { get; set; }
    }
}
