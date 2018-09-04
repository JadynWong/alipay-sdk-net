using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiShopMallMemberIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiShopMallMemberIdentifyModel : AopObject
    {
        /// <summary>
        /// 商圈ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mall_id")]
        public string MallId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
