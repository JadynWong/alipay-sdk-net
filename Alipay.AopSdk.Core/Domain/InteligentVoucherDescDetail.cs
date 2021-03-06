using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InteligentVoucherDescDetail Data Structure.
    /// </summary>
    [Serializable]
    public class InteligentVoucherDescDetail : AopObject
    {
        /// <summary>
        /// 具体描述信息列表
        /// </summary>
        [Newtonsoft.Json.JsonProperty("details")]
        public string Details { get; set; }

        /// <summary>
        /// 图片描述信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("images")]
        public string Images { get; set; }

        /// <summary>
        /// 券说明的标题
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 券外部详情描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        public string Url { get; set; }
    }
}
