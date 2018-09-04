using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SiteInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SiteInfo : AopObject
    {
        /// <summary>
        /// 测试账号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account")]
        public string Account { get; set; }

        /// <summary>
        /// 测试密码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("site_name")]
        public string SiteName { get; set; }

        /// <summary>
        /// 网站：01  APP  : 02  服务窗:03  公众号:04  其他:05  支付宝小程序:06
        /// </summary>
        [Newtonsoft.Json.JsonProperty("site_type")]
        public string SiteType { get; set; }

        /// <summary>
        /// 站点地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("site_url")]
        public string SiteUrl { get; set; }
    }
}
