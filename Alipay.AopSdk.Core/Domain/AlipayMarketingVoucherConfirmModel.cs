using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingVoucherConfirmModel : AopObject
    {
        /// <summary>
        /// 用于决定在用户确认领券后是否重定向。可枚举：true表示需要重定向，false表示不需要重定向，不区分大小写
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_redirect")]
        public bool NeedRedirect { get; set; }

        /// <summary>
        /// 外部业务单号。用作幂等控制。同一个template_id、user_id、out_biz_no返回相同的发券码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 重定向地址，用于接收支付宝返回的领取码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("redirect_uri")]
        public string RedirectUri { get; set; }

        /// <summary>
        /// 券模板ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 指定用户确认页面的主题名称。目前提供5套主题，分别为：red, blue, yellow, green, orange
        /// </summary>
        [Newtonsoft.Json.JsonProperty("theme")]
        public string Theme { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
