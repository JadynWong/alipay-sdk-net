using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignOpenDeliveryDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignOpenDeliveryDeleteModel : AopObject
    {
        /// <summary>
        /// 要删除店铺页投放内容的类型。目前支持的类型有：1. gift_card
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_type")]
        public string DeliveryType { get; set; }

        /// <summary>
        /// 商户的PID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 要删除内容投放的门店ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
