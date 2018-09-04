using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenPublicGroupCrowdQueryResponse.
    /// </summary>
    public class AlipayOpenPublicGroupCrowdQueryResponse : AopResponse
    {
        /// <summary>
        /// 分组圈出的人群数量
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count")]
        public string Count { get; set; }
    }
}
