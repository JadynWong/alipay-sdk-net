using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SignTaskResult Data Structure.
    /// </summary>
    [Serializable]
    public class SignTaskResult : AopObject
    {
        /// <summary>
        /// 业务流水号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 支付宝签约入口地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign_enter_url")]
        public string SignEnterUrl { get; set; }

        /// <summary>
        /// 签名任务流水号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_id")]
        public string TaskId { get; set; }
    }
}
