using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenPublicAdvertCreateResponse.
    /// </summary>
    public class AlipayOpenPublicAdvertCreateResponse : AopResponse
    {
        /// <summary>
        /// 广告位id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advert_id")]
        public string AdvertId { get; set; }
    }
}
