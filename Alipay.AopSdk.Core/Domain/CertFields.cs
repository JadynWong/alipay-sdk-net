using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CertFields Data Structure.
    /// </summary>
    [Serializable]
    public class CertFields : AopObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        [Newtonsoft.Json.JsonProperty("birth")]
        public string Birth { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("certno")]
        public string Certno { get; set; }

        /// <summary>
        /// 有效期
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expires")]
        public string Expires { get; set; }

        /// <summary>
        /// 有效期结束日期
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expiresend")]
        public string Expiresend { get; set; }

        /// <summary>
        /// 有效期开始时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expiresstart")]
        public string Expiresstart { get; set; }

        /// <summary>
        /// 签发机关
        /// </summary>
        [Newtonsoft.Json.JsonProperty("issuingauthority")]
        public string Issuingauthority { get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("number")]
        public string Number { get; set; }

        /// <summary>
        /// 民族
        /// </summary>
        [Newtonsoft.Json.JsonProperty("race")]
        public string Race { get; set; }

        /// <summary>
        /// 换证次数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("renewalnum")]
        public string Renewalnum { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sex")]
        public string Sex { get; set; }
    }
}
