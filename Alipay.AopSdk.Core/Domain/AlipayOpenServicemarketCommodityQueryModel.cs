using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketCommodityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenServicemarketCommodityQueryModel : AopObject
    {
        /// <summary>
        /// 服务插件ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commodity_id")]
        public string CommodityId { get; set; }

        /// <summary>
        /// 服务创建者ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
