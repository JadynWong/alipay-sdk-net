using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerCertificationCertifyResponse.
    /// </summary>
    public class ZhimaCustomerCertificationCertifyResponse : AopResponse
    {
        /// <summary>
        /// 一次认证的唯一标识，在商户调用认证初始化接口的时候获取，认证完成返回的biz_no和请求的一致
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 认证不通过的原因
        /// </summary>
        [Newtonsoft.Json.JsonProperty("failed_reason")]
        public string FailedReason { get; set; }

        /// <summary>
        /// 认证是否通过,通过为true，不通过为false
        /// </summary>
        [Newtonsoft.Json.JsonProperty("passed")]
        public string Passed { get; set; }
    }
}
