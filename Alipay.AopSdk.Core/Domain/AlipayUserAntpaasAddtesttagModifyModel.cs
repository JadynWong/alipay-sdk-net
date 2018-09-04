using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAntpaasAddtesttagModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAntpaasAddtesttagModifyModel : AopObject
    {
        /// <summary>
        /// 支付宝账户id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_no")]
        public string AccountNo { get; set; }
    }
}
