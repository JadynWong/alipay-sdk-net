using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingDataMallDiscountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataMallDiscountQueryModel : AopObject
    {
        /// <summary>
        /// 商圈id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mall_id")]
        public string MallId { get; set; }
    }
}
