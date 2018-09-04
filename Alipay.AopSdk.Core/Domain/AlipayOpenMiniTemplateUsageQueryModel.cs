using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniTemplateUsageQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniTemplateUsageQueryModel : AopObject
    {
        /// <summary>
        /// 查询的页数，默认第一页
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页的数量，最多查询50个，默认查询10个
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 模板小程序的版本号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_version")]
        public string TemplateVersion { get; set; }
    }
}
