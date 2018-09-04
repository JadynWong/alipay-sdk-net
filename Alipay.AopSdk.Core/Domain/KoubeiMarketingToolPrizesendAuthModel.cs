using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingToolPrizesendAuthModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingToolPrizesendAuthModel : AopObject
    {
        /// <summary>
        /// 奖品ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 外部流水号，保证业务幂等性
        /// </summary>
        [Newtonsoft.Json.JsonProperty("req_id")]
        public string ReqId { get; set; }

        /// <summary>
        /// 发奖用户ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
