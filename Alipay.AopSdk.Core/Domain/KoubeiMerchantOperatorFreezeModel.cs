using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMerchantOperatorFreezeModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantOperatorFreezeModel : AopObject
    {
        /// <summary>
        /// 操作码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 操作员ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator_id")]
        public string OperatorId { get; set; }
    }
}
