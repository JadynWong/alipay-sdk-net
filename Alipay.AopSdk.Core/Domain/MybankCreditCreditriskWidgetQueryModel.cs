using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditCreditriskWidgetQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditCreditriskWidgetQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝userid
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alipay_user_id")]
        public string AlipayUserId { get; set; }
    }
}
