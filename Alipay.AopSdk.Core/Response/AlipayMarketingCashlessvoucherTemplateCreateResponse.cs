using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCashlessvoucherTemplateCreateResponse.
    /// </summary>
    public class AlipayMarketingCashlessvoucherTemplateCreateResponse : AopResponse
    {
        /// <summary>
        /// 模板ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        public string TemplateId { get; set; }
    }
}
