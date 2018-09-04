using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobilePublicMenuQueryResponse.
    /// </summary>
    public class AlipayMobilePublicMenuQueryResponse : AopResponse
    {
        /// <summary>
        /// 所有菜单列表json串
        /// </summary>
        [Newtonsoft.Json.JsonProperty("all_menu_list")]
        public string AllMenuList { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        public string Msg { get; set; }
    }
}
