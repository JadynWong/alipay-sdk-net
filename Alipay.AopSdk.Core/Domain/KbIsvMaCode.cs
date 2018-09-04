using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbIsvMaCode Data Structure.
    /// </summary>
    [Serializable]
    public class KbIsvMaCode : AopObject
    {
        /// <summary>
        /// 凭证码值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 码的可核销份数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("num")]
        public string Num { get; set; }
    }
}
