using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserCertifyStudentinfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCertifyStudentinfoSyncModel : AopObject
    {
        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 教育层次
        /// </summary>
        [XmlElement("education_level")]
        public string EducationLevel { get; set; }

        /// <summary>
        /// 入学日期
        /// </summary>
        [XmlElement("entry_date")]
        public string EntryDate { get; set; }

        /// <summary>
        /// 预期毕业日期
        /// </summary>
        [XmlElement("graduation_date")]
        public string GraduationDate { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [XmlElement("school_name")]
        public string SchoolName { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
