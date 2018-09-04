using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignDiscountWhitelistQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignDiscountWhitelistQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 活动id.白名单,","隔开，最多100个
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_white_list")]
        public string UserWhiteList { get; set; }
    }
}
