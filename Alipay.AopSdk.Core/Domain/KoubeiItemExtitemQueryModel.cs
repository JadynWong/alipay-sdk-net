using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiItemExtitemQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiItemExtitemQueryModel : AopObject
    {
        /// <summary>
        /// 商品编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_code")]
        public string ItemCode { get; set; }
    }
}
