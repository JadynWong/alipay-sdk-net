using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BPOpenApiInstance Data Structure.
    /// </summary>
    [Serializable]
    public class BPOpenApiInstance : AopObject
    {
        /// <summary>
        /// 业务上下文，JSON格式
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_context")]
        public string BizContext { get; set; }

        /// <summary>
        /// 业务ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 创建人域账号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 流程实例描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 创建到完成的毫秒数，未完结为0
        /// </summary>
        [Newtonsoft.Json.JsonProperty("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 完结时间,未完结时为空
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 2088账号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 最后更新人域账号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("modify_user")]
        public string ModifyUser { get; set; }

        /// <summary>
        /// 流程配置名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 父流程实例ID。用于描述父子流程
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parent_id")]
        public string ParentId { get; set; }

        /// <summary>
        /// 父流程实例所处的节点
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parent_node")]
        public string ParentNode { get; set; }

        /// <summary>
        /// 优先级
        /// </summary>
        [Newtonsoft.Json.JsonProperty("priority")]
        public long Priority { get; set; }

        /// <summary>
        /// 全局唯一ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("puid")]
        public string Puid { get; set; }

        /// <summary>
        /// 前置流程ID。用于描述流程串联
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 前置流程从哪个节点发起的本流程
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source_node_name")]
        public string SourceNodeName { get; set; }

        /// <summary>
        /// 流程实例状态:CREATED,PROCESSING,COMPLETED,CANCELED
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// 包含的任务列表
        /// </summary>
        [XmlArray("tasks")]
        [XmlArrayItem("b_p_open_api_task")]
        public List<BPOpenApiTask> Tasks { get; set; }
    }
}
