using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenPublicGroupCreateResponse.
    /// </summary>
    public class AlipayOpenPublicGroupCreateResponse : AopResponse
    {
        /// <summary>
        /// 分组id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_id")]
        public string GroupId { get; set; }
    }
}
