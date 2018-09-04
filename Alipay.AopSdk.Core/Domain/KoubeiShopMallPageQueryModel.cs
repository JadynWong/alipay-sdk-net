using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiShopMallPageQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiShopMallPageQueryModel : AopObject
    {
        /// <summary>
        /// 商圈id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mall_id")]
        public string MallId { get; set; }
    }
}
