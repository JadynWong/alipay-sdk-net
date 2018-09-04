using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AttachmentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AttachmentInfo : AopObject
    {
        /// <summary>
        /// 支付宝返回的图片在文件存储平台的标识
        /// </summary>
        [Newtonsoft.Json.JsonProperty("atta_url")]
        public string AttaUrl { get; set; }

        /// <summary>
        /// 图片名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 附件类型,PROMO_PIC:营销物料照
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; }
    }
}
