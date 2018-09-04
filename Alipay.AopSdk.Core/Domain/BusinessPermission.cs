using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessPermission Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessPermission : AopObject
    {
        /// <summary>
        /// 业务隔离字段
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// 权限码名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("permission_code")]
        public string PermissionCode { get; set; }

        /// <summary>
        /// 权限码值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source_permission_code")]
        public string SourcePermissionCode { get; set; }
    }
}
