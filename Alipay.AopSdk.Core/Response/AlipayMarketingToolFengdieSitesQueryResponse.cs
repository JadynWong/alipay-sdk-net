using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieSitesQueryResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieSitesQueryResponse : AopResponse
    {
        /// <summary>
        /// 站点查询返回值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public FengdieSitesQueryRespModel Data { get; set; }
    }
}
