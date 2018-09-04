using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BeaconTemplate Data Structure.
    /// </summary>
    [Serializable]
    public class BeaconTemplate : AopObject
    {
        /// <summary>
        /// 模板参数信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("context")]
        public string Context { get; set; }

        /// <summary>
        /// 模板ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("templateid")]
        public string Templateid { get; set; }
    }
}
