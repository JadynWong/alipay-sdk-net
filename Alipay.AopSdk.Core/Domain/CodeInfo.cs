using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CodeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CodeInfo : AopObject
    {
        /// <summary>
        /// 跳转URL，扫码关注服务窗后会直接跳转到此URL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goto_url")]
        public string GotoUrl { get; set; }

        /// <summary>
        /// 场景信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene")]
        public Scene Scene { get; set; }
    }
}
