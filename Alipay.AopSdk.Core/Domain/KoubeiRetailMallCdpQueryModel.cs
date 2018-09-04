using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiRetailMallCdpQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailMallCdpQueryModel : AopObject
    {
        /// <summary>
        /// 商圈id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mall_id")]
        public string MallId { get; set; }
    }
}
