using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiItemExtitemInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiItemExtitemInfoQueryModel : AopObject
    {
        /// <summary>
        /// 商品编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_id")]
        public string GoodsId { get; set; }
    }
}
