using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobileStdPublicFollowListResponse.
    /// </summary>
    public class AlipayMobileStdPublicFollowListResponse : AopResponse
    {
        /// <summary>
        /// 当前组的值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count")]
        public string Count { get; set; }

        /// <summary>
        /// 用户数据
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        public Data Data { get; set; }

        /// <summary>
        /// 与nextUserId对应，标准Alipay UserId
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_alipay_user_id")]
        public string NextAlipayUserId { get; set; }

        /// <summary>
        /// 查询分组的userid
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_user_id")]
        public string NextUserId { get; set; }
    }
}
