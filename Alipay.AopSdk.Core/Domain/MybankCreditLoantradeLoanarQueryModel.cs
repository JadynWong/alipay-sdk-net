using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoantradeLoanarQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoantradeLoanarQueryModel : AopObject
    {
        /// <summary>
        /// 客户的角色编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("iproleid")]
        public string Iproleid { get; set; }

        /// <summary>
        /// 合约编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("loanarno")]
        public string Loanarno { get; set; }
    }
}
