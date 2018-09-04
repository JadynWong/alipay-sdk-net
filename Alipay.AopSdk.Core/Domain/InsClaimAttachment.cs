using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsClaimAttachment Data Structure.
    /// </summary>
    [Serializable]
    public class InsClaimAttachment : AopObject
    {
        /// <summary>
        /// 材料描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 附件对应的路径
        /// </summary>
        [Newtonsoft.Json.JsonProperty("path")]
        public string Path { get; set; }

        /// <summary>
        /// 审核理由
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 材料审核状态
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 附件类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; }
    }
}
