using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobileCodeQueryResponse.
    /// </summary>
    public class AlipayMobileCodeQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务关联ID。比如订单号,userId，业务连接等
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_linked_id")]
        public string BizLinkedId { get; set; }

        /// <summary>
        /// 类似产品名称，根据该值决定码存储类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 码值的状态，  init:初始  normal:正常  pause:暂停  stop:停止
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_status")]
        public string CodeStatus { get; set; }

        /// <summary>
        /// 业务自定义json字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("context_str")]
        public string ContextStr { get; set; }

        /// <summary>
        /// 动态生成图片地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dynamic_img_url")]
        public string DynamicImgUrl { get; set; }

        /// <summary>
        /// 编码失效时间(yyyy-MM-dd hh:mm:ss)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 如果是true，则扫一扫下发跳转地址直接取自BizLinkedId  否则，从路由信息里取跳转地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_direct")]
        public string IsDirect { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 业务用到的码值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qr_code")]
        public string QrCode { get; set; }

        /// <summary>
        /// 原始码值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qr_token")]
        public string QrToken { get; set; }

        /// <summary>
        /// 发码来源，业务自定
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 编码启动时间(yyyy-MM-dd hh:mm:ss)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
