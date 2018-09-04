using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobileRecommendGetResponse.
    /// </summary>
    public class AlipayMobileRecommendGetResponse : AopResponse
    {
        /// <summary>
        /// 推荐结果的扩展信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 推荐结果集合, json数组对象, 每个元素至少包含entity_id的属性,其他属性由推荐方案决定。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("items")]
        public string Items { get; set; }

        /// <summary>
        /// 本次推荐的唯一标识
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recommend_id")]
        public string RecommendId { get; set; }
    }
}
