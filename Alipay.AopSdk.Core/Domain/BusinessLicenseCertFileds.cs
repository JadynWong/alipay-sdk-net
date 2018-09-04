using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessLicenseCertFileds Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessLicenseCertFileds : AopObject
    {
        /// <summary>
        /// 社会信用代码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creditcode")]
        public string Creditcode { get; set; }

        /// <summary>
        /// 公司名字
        /// </summary>
        [Newtonsoft.Json.JsonProperty("entname")]
        public string Entname { get; set; }
    }
}
