using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherTemplateDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingVoucherTemplateDeleteModel : AopObject
    {
        /// <summary>
        /// 券模板ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        public string TemplateId { get; set; }
    }
}
