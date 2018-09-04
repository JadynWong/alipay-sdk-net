using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringTablelistQueryResponse.
    /// </summary>
    public class KoubeiCateringTablelistQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回tablelistresult列表
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tableinfo_result")]
        public TableInfoResult TableinfoResult { get; set; }
    }
}
