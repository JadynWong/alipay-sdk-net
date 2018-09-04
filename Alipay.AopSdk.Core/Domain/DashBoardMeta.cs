using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DashBoardMeta Data Structure.
    /// </summary>
    [Serializable]
    public class DashBoardMeta : AopObject
    {
        /// <summary>
        /// 授权状态，值为true或者false
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_status")]
        public bool AuthStatus { get; set; }

        /// <summary>
        /// 仪表盘创建时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 仪表盘ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dashboard_id")]
        public string DashboardId { get; set; }

        /// <summary>
        /// 仪表盘名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dashboard_name")]
        public string DashboardName { get; set; }
    }
}
