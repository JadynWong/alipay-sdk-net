using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiItemTaobaoIndexQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiItemTaobaoIndexQueryModel : AopObject
    {
        /// <summary>
        /// 城市编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city_id")]
        public string CityId { get; set; }

        /// <summary>
        /// 扩展信息，json格式
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 场景码,TAO_BIG_BUY:淘抢购大牌抢购;JU_BIG_BUY:聚划算大牌抢购
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
