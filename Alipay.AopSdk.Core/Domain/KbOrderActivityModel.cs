using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbOrderActivityModel Data Structure.
    /// </summary>
    [Serializable]
    public class KbOrderActivityModel : AopObject
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_id")]
        public string ItemId { get; set; }
    }
}
