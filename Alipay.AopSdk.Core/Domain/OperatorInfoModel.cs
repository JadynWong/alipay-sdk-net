using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OperatorInfoModel Data Structure.
    /// </summary>
    [Serializable]
    public class OperatorInfoModel : AopObject
    {
        /// <summary>
        /// customerId
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cid")]
        public string Cid { get; set; }

        /// <summary>
        /// 邮件
        /// </summary>
        [Newtonsoft.Json.JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// 部门ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("job_id")]
        public string JobId { get; set; }

        /// <summary>
        /// 部门树
        /// </summary>
        [Newtonsoft.Json.JsonProperty("job_tree")]
        public string JobTree { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 操作员姓名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 操作员别名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 操作员ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作员类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator_type")]
        public string OperatorType { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("role_id")]
        public string RoleId { get; set; }

        /// <summary>
        /// 角色名字
        /// </summary>
        [Newtonsoft.Json.JsonProperty("role_name")]
        public string RoleName { get; set; }

        /// <summary>
        /// 门店列表
        /// </summary>
        [XmlArray("shop_ids")]
        [XmlArrayItem("string")]
        public List<string> ShopIds { get; set; }

        /// <summary>
        /// T
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; }
    }
}
