using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAccountFinriskInstriskmonitorKeywordsBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountFinriskInstriskmonitorKeywordsBatchqueryModel : AopObject
    {
        /// <summary>
        /// 查询机构关键词
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        public string Content { get; set; }
    }
}
