using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsUnderwriteMutualPolicyBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsUnderwriteMutualPolicyBatchqueryModel : AopObject
    {
        /// <summary>
        /// 渠道来源
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 计划ID，宝贝计划(BAOBEI_PLAN)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_no")]
        public string PlanNo { get; set; }

        /// <summary>
        /// 来源，如支付宝客户端(MOBILE_APP)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
