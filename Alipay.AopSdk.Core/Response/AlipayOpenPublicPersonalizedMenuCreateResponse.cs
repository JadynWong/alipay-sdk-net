using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenPublicPersonalizedMenuCreateResponse.
    /// </summary>
    public class AlipayOpenPublicPersonalizedMenuCreateResponse : AopResponse
    {
        /// <summary>
        /// 该套个性化菜单key
        /// </summary>
        [Newtonsoft.Json.JsonProperty("menu_key")]
        public string MenuKey { get; set; }
    }
}
