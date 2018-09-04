using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiRetailItemQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailItemQueryModel : AopObject
    {
        /// <summary>
        /// 城市编码，6位国际码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city_id")]
        public string CityId { get; set; }

        /// <summary>
        /// 支付宝商品ID，即展示的券
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_id")]
        public string ItemId { get; set; }
    }
}
