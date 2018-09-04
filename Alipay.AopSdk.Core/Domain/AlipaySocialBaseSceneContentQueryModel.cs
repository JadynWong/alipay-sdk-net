using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialBaseSceneContentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseSceneContentQueryModel : AopObject
    {
        /// <summary>
        /// 城市id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city_id")]
        public string CityId { get; set; }

        /// <summary>
        /// 内容中台提供的运营后台配置场景id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 返回文章列表的个数，目前最多10条
        /// </summary>
        [Newtonsoft.Json.JsonProperty("top_size")]
        public long TopSize { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
