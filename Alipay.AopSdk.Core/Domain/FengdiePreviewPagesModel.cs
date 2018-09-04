using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FengdiePreviewPagesModel Data Structure.
    /// </summary>
    [Serializable]
    public class FengdiePreviewPagesModel : AopObject
    {
        /// <summary>
        /// 站点页面别名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// 页面预览地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        public string Url { get; set; }
    }
}
