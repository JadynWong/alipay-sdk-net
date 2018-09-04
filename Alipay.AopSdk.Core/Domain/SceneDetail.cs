using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SceneDetail Data Structure.
    /// </summary>
    [Serializable]
    public class SceneDetail : AopObject
    {
        /// <summary>
        /// 场景描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 场景id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 场景配置的图片
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_image")]
        public string SceneImage { get; set; }

        /// <summary>
        /// 小蚂答场景标题
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        public string Title { get; set; }
    }
}
