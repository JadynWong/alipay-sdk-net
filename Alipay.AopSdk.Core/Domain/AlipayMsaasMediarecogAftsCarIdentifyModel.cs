using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogAftsCarIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogAftsCarIdentifyModel : AopObject
    {
        /// <summary>
        /// 扩展入参
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 高
        /// </summary>
        [Newtonsoft.Json.JsonProperty("h")]
        public long H { get; set; }

        /// <summary>
        /// 用户输入的里程数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kilometres")]
        public long Kilometres { get; set; }

        /// <summary>
        /// 传入资源URL或djangoid或aftsid
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 宽
        /// </summary>
        [Newtonsoft.Json.JsonProperty("w")]
        public long W { get; set; }

        /// <summary>
        /// 引导框左上角x
        /// </summary>
        [Newtonsoft.Json.JsonProperty("x")]
        public long X { get; set; }

        /// <summary>
        /// 引导框左上角y
        /// </summary>
        [Newtonsoft.Json.JsonProperty("y")]
        public long Y { get; set; }
    }
}
