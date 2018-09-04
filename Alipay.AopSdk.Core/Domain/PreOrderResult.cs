using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PreOrderResult Data Structure.
    /// </summary>
    [Serializable]
    public class PreOrderResult : AopObject
    {
        /// <summary>
        /// 应用唯一标识
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// 商户订单号,64个字符以内、只能包含字母、数字、下划线；需保证在商户端不重复
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 校验是否成功
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success")]
        public bool Success { get; set; }
    }
}
