using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsScenePolicySurrenderApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsScenePolicySurrenderApplyModel : AopObject
    {
        /// <summary>
        /// 退保扩展参数 ;标准json格式
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 蚂蚁保险平台生成的保单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("policy_no")]
        public string PolicyNo { get; set; }
    }
}
