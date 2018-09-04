using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardCreditInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CardCreditInfo : AopObject
    {
        /// <summary>
        /// 是否允许超扣
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allowoverpay")]
        public string Allowoverpay { get; set; }

        /// <summary>
        /// 超扣额度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creditquota")]
        public string Creditquota { get; set; }
    }
}
