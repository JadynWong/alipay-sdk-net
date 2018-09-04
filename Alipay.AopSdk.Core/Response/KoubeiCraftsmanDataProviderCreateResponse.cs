using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCraftsmanDataProviderCreateResponse.
    /// </summary>
    public class KoubeiCraftsmanDataProviderCreateResponse : AopResponse
    {
        /// <summary>
        /// 手艺人id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("craftsman_id")]
        public string CraftsmanId { get; set; }
    }
}
