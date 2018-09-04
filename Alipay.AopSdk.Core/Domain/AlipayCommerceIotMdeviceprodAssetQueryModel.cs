using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodAssetQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotMdeviceprodAssetQueryModel : AopObject
    {
        /// <summary>
        /// 模板ID（物料系统的item_id）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_id")]
        public string ItemId { get; set; }
    }
}
