using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMerchantOperatorRoleCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantOperatorRoleCreateModel : AopObject
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

        /// <summary>
        /// 角色名称，修改时必填
        /// </summary>
        [Newtonsoft.Json.JsonProperty("role_name")]
        public string RoleName { get; set; }
    }
}
