using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceItaskProcessDetailCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceItaskProcessDetailCreateModel : AopObject
    {
        /// <summary>
        /// 接口服务端名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 附件地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attachment")]
        public string Attachment { get; set; }

        /// <summary>
        /// 接口客户端名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exapp_name")]
        public string ExappName { get; set; }

        /// <summary>
        /// 外部工单创建人ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("excreator_id")]
        public string ExcreatorId { get; set; }

        /// <summary>
        /// 外部工单创建人名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("excreator_name")]
        public string ExcreatorName { get; set; }

        /// <summary>
        /// 外部工单创建人部门ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exsystem_department_id")]
        public string ExsystemDepartmentId { get; set; }

        /// <summary>
        /// BU名称（xspace填写对应的租户名称）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exsystem_department_name")]
        public string ExsystemDepartmentName { get; set; }

        /// <summary>
        /// 外部工单业务扩展字段列表，业务属性信息都放置在此字段。最多10个字段。
        /// </summary>
        [XmlArray("extend_field_infos")]
        [XmlArrayItem("extend_field_info")]
        public List<ExtendFieldInfo> ExtendFieldInfos { get; set; }

        /// <summary>
        /// 工单流程编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("process_no")]
        public string ProcessNo { get; set; }

        /// <summary>
        /// 工单流程编号_服务端提供给消费端流程模板code
        /// </summary>
        [Newtonsoft.Json.JsonProperty("process_template_code")]
        public string ProcessTemplateCode { get; set; }
    }
}
