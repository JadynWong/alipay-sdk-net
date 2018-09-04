using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingToolIsvMerchantQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingToolIsvMerchantQueryModel : AopObject
    {
        /// <summary>
        /// 页码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        public string PageSize { get; set; }
    }
}
