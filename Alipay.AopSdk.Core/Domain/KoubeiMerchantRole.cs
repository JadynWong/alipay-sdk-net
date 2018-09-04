using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMerchantRole Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantRole : AopObject
    {
        /// <summary>
        /// 员工数量
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator_num")]
        public string OperatorNum { get; set; }

        /// <summary>
        /// 权限数量
        /// </summary>
        [Newtonsoft.Json.JsonProperty("permission_num")]
        public string PermissionNum { get; set; }

        /// <summary>
        /// 角色标识码，如财务
        /// </summary>
        [Newtonsoft.Json.JsonProperty("role_code")]
        public string RoleCode { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("role_id")]
        public string RoleId { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("role_name")]
        public string RoleName { get; set; }
    }
}
