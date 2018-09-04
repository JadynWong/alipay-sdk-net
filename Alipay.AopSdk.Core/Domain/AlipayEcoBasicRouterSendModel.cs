using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoBasicRouterSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoBasicRouterSendModel : AopObject
    {
        /// <summary>
        /// 路由数据
        /// </summary>
        [Newtonsoft.Json.JsonProperty("input")]
        public string Input { get; set; }

        /// <summary>
        /// 路由任务名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("interface_name")]
        public string InterfaceName { get; set; }

        /// <summary>
        /// 本次调用唯一id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trace_id")]
        public string TraceId { get; set; }
    }
}
