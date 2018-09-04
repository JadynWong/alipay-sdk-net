using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMemberDataTagQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMemberDataTagQueryModel : AopObject
    {
        /// <summary>
        /// isv的pid
        /// </summary>
        [Newtonsoft.Json.JsonProperty("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
