using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAirXfgDsgModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAirXfgDsgModifyModel : AopObject
    {
        /// <summary>
        /// 用户年龄
        /// </summary>
        [Newtonsoft.Json.JsonProperty("age")]
        public string Age { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nam")]
        public string Nam { get; set; }

        /// <summary>
        /// 男
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sex")]
        public string Sex { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("xbw")]
        public string Xbw { get; set; }
    }
}
