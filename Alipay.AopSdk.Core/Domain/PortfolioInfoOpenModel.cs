using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PortfolioInfoOpenModel Data Structure.
    /// </summary>
    [Serializable]
    public class PortfolioInfoOpenModel : AopObject
    {
        /// <summary>
        /// 头图素材id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cover_image_id")]
        public string CoverImageId { get; set; }

        /// <summary>
        /// 头图素材type；  枚举（PICTURE/VIDEO）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cover_image_type")]
        public string CoverImageType { get; set; }

        /// <summary>
        /// 头图链接
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cover_image_url")]
        public string CoverImageUrl { get; set; }

        /// <summary>
        /// 作品集id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("portfolio_id")]
        public string PortfolioId { get; set; }

        /// <summary>
        /// 作品集标题
        /// </summary>
        [Newtonsoft.Json.JsonProperty("portfolio_title")]
        public string PortfolioTitle { get; set; }
    }
}
