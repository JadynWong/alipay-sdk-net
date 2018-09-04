using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingDataSceneParkingoutUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataSceneParkingoutUploadModel : AopObject
    {
        /// <summary>
        /// 停车出库场景业务参数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_info")]
        public ParkingOutScene BizInfo { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 外部请求号，确保唯一，用于幂等控制
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 场景类型
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
