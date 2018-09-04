using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingAdvertisingQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingAdvertisingQueryModel : AopObject
    {
        /// <summary>
        /// 广告Id，唯一标识一条广告
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ad_id")]
        public string AdId { get; set; }
    }
}
