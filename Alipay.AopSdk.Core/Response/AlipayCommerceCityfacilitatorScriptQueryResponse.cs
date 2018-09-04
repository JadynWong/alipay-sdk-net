using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorScriptQueryResponse.
    /// </summary>
    public class AlipayCommerceCityfacilitatorScriptQueryResponse : AopResponse
    {
        /// <summary>
        /// 脚本内容，智能卡中心自定义的脚本格式内容
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// 脚本更新时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gmt_modified")]
        public string GmtModified { get; set; }
    }
}
