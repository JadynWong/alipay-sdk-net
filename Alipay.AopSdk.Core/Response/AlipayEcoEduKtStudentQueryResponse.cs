using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoEduKtStudentQueryResponse.
    /// </summary>
    public class AlipayEcoEduKtStudentQueryResponse : AopResponse
    {
        /// <summary>
        /// 学生姓名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("child_name")]
        public string ChildName { get; set; }

        /// <summary>
        /// 班级名字
        /// </summary>
        [Newtonsoft.Json.JsonProperty("class_name")]
        public string ClassName { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("school_name")]
        public string SchoolName { get; set; }

        /// <summary>
        /// 学生编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("student_code")]
        public string StudentCode { get; set; }

        /// <summary>
        /// 学生身份证
        /// </summary>
        [Newtonsoft.Json.JsonProperty("student_identify")]
        public string StudentIdentify { get; set; }

        /// <summary>
        /// 家长信息
        /// </summary>
        [XmlArray("users")]
        [XmlArrayItem("user_details")]
        public List<UserDetails> Users { get; set; }
    }
}
