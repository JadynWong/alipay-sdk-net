using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicFollowCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicFollowCreateModel : AopObject
    {
        /// <summary>
        /// 来源，目前只有"tmall"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
