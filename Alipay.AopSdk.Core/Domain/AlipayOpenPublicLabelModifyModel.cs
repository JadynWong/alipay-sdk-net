using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicLabelModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicLabelModifyModel : AopObject
    {
        /// <summary>
        /// 要修改的标签id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 要修改成的标签名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }
    }
}
