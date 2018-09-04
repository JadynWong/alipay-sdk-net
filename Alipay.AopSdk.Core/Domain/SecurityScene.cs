using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SecurityScene Data Structure.
    /// </summary>
    [Serializable]
    public class SecurityScene : AopObject
    {
        /// <summary>
        /// 接入渠道
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_channel")]
        public string AccessChannel { get; set; }

        /// <summary>
        /// 事件信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ctu_params")]
        public string CtuParams { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 产品节点
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_node")]
        public string ProductNode { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("security_scene_params")]
        public string SecuritySceneParams { get; set; }

        /// <summary>
        /// 系统名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("system_name")]
        public string SystemName { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_fee")]
        public string TotalFee { get; set; }
    }
}
