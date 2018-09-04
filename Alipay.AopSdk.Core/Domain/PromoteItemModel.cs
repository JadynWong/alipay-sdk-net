using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromoteItemModel Data Structure.
    /// </summary>
    [Serializable]
    public class PromoteItemModel : AopObject
    {
        /// <summary>
        /// 品牌名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("voucher_name")]
        public string VoucherName { get; set; }
    }
}
