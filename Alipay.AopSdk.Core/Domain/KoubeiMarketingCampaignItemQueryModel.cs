using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignItemQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignItemQueryModel : AopObject
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 操作人id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作员类型，MER=商户
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator_type")]
        public string OperatorType { get; set; }
    }
}
