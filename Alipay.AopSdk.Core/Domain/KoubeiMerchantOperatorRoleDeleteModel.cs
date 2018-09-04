using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMerchantOperatorRoleDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantOperatorRoleDeleteModel : AopObject
    {
        /// <summary>
        /// 操作员ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("role_id")]
        public string RoleId { get; set; }
    }
}
