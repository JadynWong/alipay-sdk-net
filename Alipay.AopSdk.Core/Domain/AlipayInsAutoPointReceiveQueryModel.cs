using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsAutoPointReceiveQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsAutoPointReceiveQueryModel : AopObject
    {
        /// <summary>
        /// 车险活动类型编码。  攒油活动：SAVE_OIL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auto_campaign_type")]
        public string AutoCampaignType { get; set; }

        /// <summary>
        /// 车险活动接入场景码。  例如，车险攒油活动接入场景码。  高德导航：gaode_use
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
