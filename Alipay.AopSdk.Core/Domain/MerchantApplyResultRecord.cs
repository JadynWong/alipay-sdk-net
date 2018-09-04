using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantApplyResultRecord Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantApplyResultRecord : AopObject
    {
        /// <summary>
        /// 签约产品名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prod_name")]
        public string ProdName { get; set; }

        /// <summary>
        /// 如审核失败，表示该字段引发的审核失败
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prop_input_key")]
        public string PropInputKey { get; set; }

        /// <summary>
        /// 认证、产品签约审核失败原因
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result_msg")]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 认证审核、产品签约审核状态
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result_status")]
        public string ResultStatus { get; set; }

        /// <summary>
        /// 详情类型，CETIFY为认证，PROD为产品签约，COMMENT为认证审核批注
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result_type")]
        public string ResultType { get; set; }
    }
}
