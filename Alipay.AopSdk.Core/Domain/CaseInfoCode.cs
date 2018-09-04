using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CaseInfoCode Data Structure.
    /// </summary>
    [Serializable]
    public class CaseInfoCode : AopObject
    {
        /// <summary>
        /// 情报代码，具体见《案件情报类型代码V1》
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info_code")]
        public string InfoCode { get; set; }

        /// <summary>
        /// 情报描述信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info_code_desc")]
        public string InfoCodeDesc { get; set; }
    }
}
