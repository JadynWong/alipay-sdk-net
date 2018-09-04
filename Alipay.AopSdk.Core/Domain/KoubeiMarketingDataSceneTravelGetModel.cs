using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingDataSceneTravelGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataSceneTravelGetModel : AopObject
    {
        /// <summary>
        /// 出行营销场景业务参数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_info")]
        public TravelScene BizInfo { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 代表了一次请求，作为业务幂等性控制
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 场景类型，固定值：TRAVEL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
