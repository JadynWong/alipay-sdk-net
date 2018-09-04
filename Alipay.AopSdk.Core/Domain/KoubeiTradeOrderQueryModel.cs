using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiTradeOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiTradeOrderQueryModel : AopObject
    {
        /// <summary>
        /// 口碑订单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_no")]
        public string OrderNo { get; set; }
    }
}
