using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardFundInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CardFundInfo : AopObject
    {
        /// <summary>
        /// 消费资金账户
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fundaccount")]
        public string Fundaccount { get; set; }

        /// <summary>
        /// 消费资金类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fundtype")]
        public string Fundtype { get; set; }
    }
}
