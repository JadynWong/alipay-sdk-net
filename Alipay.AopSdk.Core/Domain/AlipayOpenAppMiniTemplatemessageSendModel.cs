using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppMiniTemplatemessageSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppMiniTemplatemessageSendModel : AopObject
    {
        /// <summary>
        /// 开发者需要发送模板消息中的自定义部分来替换模板的占位符
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public string Data { get; set; }

        /// <summary>
        /// 用户发生的交易行为的交易号，或者用户在小程序产生表单提交的表单号，用于信息发送的校验
        /// </summary>
        [Newtonsoft.Json.JsonProperty("form_id")]
        public string FormId { get; set; }

        /// <summary>
        /// 小程序的跳转页面，用于消息中心用户点击之后详细跳转的小程序页面
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        public string Page { get; set; }

        /// <summary>
        /// 发送消息的支付宝账号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("to_user_id")]
        public string ToUserId { get; set; }

        /// <summary>
        /// 用户申请的模板id号，固定的模板id会发送固定的消息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_template_id")]
        public string UserTemplateId { get; set; }
    }
}
