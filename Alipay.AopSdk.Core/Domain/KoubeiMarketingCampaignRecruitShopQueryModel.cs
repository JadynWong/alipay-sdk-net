using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignRecruitShopQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignRecruitShopQueryModel : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 参与的商户Id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invitee")]
        public string Invitee { get; set; }

        /// <summary>
        /// 操作人id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作人类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator_type")]
        public string OperatorType { get; set; }

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
