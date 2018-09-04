using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPromorulecenterRuleAnalyzeResponse.
    /// </summary>
    public class AlipayPromorulecenterRuleAnalyzeResponse : AopResponse
    {
        /// <summary>
        /// 未通过条件描述信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_condition_msg")]
        public string FailConditionMsg { get; set; }

        /// <summary>
        /// 未通过的条件
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_condition_name")]
        public string FailConditionName { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 服务调用是否成功
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success")]
        public string Success { get; set; }

        /// <summary>
        /// 规则是否通过
        /// </summary>
        [Newtonsoft.Json.JsonProperty("triggered")]
        public string Triggered { get; set; }
    }
}
