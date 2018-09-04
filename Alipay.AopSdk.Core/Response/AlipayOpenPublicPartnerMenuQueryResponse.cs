using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenPublicPartnerMenuQueryResponse.
    /// </summary>
    public class AlipayOpenPublicPartnerMenuQueryResponse : AopResponse
    {
        /// <summary>
        /// 服务窗菜单
        /// </summary>
        [Newtonsoft.Json.JsonProperty("public_menu")]
        public string PublicMenu { get; set; }
    }
}
