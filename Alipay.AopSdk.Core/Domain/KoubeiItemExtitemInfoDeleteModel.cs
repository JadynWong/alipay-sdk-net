using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiItemExtitemInfoDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiItemExtitemInfoDeleteModel : AopObject
    {
        /// <summary>
        /// 商品编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_id")]
        public string GoodsId { get; set; }
    }
}
