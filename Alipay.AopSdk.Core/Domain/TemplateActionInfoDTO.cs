using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TemplateActionInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateActionInfoDTO : AopObject
    {
        /// <summary>
        /// 行动点业务CODE，商户自定义
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 行动点展示文案
        /// </summary>
        [Newtonsoft.Json.JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// 行动点跳转链接
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        public string Url { get; set; }
    }
}
