using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingMallTradeBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingMallTradeBindModel : AopObject
    {
        /// <summary>
        /// 用户的授权动作：auth授权，unAuth取消授权
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        public string Action { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
