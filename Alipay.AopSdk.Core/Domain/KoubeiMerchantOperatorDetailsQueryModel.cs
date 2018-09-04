using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMerchantOperatorDetailsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantOperatorDetailsQueryModel : AopObject
    {
        /// <summary>
        /// 授权码
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
