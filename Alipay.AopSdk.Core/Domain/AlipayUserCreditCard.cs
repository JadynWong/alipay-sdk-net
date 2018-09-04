using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserCreditCard Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCreditCard : AopObject
    {
        /// <summary>
        /// 信用卡卡号，显示前6后2
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 开户行代码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inst_id")]
        public string InstId { get; set; }
    }
}
