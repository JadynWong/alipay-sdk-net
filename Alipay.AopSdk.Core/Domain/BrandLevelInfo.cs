using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BrandLevelInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BrandLevelInfo : AopObject
    {
        /// <summary>
        /// 品牌编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_code")]
        public string BrandCode { get; set; }

        /// <summary>
        /// 当前品牌所属级别
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_level")]
        public long BrandLevel { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_name")]
        public string BrandName { get; set; }
    }
}
