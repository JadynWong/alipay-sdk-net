using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogAftsCertIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogAftsCertIdentifyModel : AopObject
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
        /// 车牌号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plate_number")]
        public string PlateNumber { get; set; }

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
        /// 左上角x
        /// </summary>
        [Newtonsoft.Json.JsonProperty("x")]
        public long X { get; set; }

        /// <summary>
        /// 左上角y
        /// </summary>
        [Newtonsoft.Json.JsonProperty("y")]
        public long Y { get; set; }
    }
}
