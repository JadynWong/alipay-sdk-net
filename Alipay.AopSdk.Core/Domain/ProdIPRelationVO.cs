using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProdIPRelationVO Data Structure.
    /// </summary>
    [Serializable]
    public class ProdIPRelationVO : AopObject
    {
        /// <summary>
        /// 参与者别名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ip_alias_name")]
        public string IpAliasName { get; set; }

        /// <summary>
        /// 参与者所属平台
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ip_belong_platform")]
        public string IpBelongPlatform { get; set; }

        /// <summary>
        /// 参与者编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ip_code")]
        public string IpCode { get; set; }

        /// <summary>
        /// 参与者名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ip_name")]
        public string IpName { get; set; }

        /// <summary>
        /// 参与者子类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ip_sub_type")]
        public string IpSubType { get; set; }

        /// <summary>
        /// 参与者类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ip_type")]
        public string IpType { get; set; }

        /// <summary>
        /// 产品编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 产品版本
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prod_version")]
        public string ProdVersion { get; set; }

        /// <summary>
        /// 参与者平台Id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("role_id")]
        public string RoleId { get; set; }
    }
}
