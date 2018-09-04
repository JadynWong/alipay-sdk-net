using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMerchantOperatorRoleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantOperatorRoleQueryModel : AopObject
    {
        /// <summary>
        /// 当前操作员ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 角色ID,若传入刚查对应角色ID的信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("role_id")]
        public string RoleId { get; set; }
    }
}
