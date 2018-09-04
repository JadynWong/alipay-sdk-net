using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalHospitalInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalHospitalInfo : AopObject
    {
        /// <summary>
        /// 医院唯一标识，编码开发者生成并保证唯一
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 医院联系电话
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone")]
        public string Phone { get; set; }
    }
}
