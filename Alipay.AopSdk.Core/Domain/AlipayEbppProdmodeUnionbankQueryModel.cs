using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppProdmodeUnionbankQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppProdmodeUnionbankQueryModel : AopObject
    {
        /// <summary>
        /// 银联编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_code")]
        public string BankCode { get; set; }
    }
}
