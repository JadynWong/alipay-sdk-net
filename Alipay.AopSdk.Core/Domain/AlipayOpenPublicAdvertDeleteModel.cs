using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicAdvertDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicAdvertDeleteModel : AopObject
    {
        /// <summary>
        /// 待删除的广告位id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advert_id")]
        public string AdvertId { get; set; }
    }
}
