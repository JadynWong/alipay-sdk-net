using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExtBrand Data Structure.
    /// </summary>
    [Serializable]
    public class ExtBrand : AopObject
    {
        /// <summary>
        /// 品牌编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_code")]
        public string BrandCode { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }
    }
}
