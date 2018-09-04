using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BizParamKeyValue Data Structure.
    /// </summary>
    [Serializable]
    public class BizParamKeyValue : AopObject
    {
        /// <summary>
        /// 参数名key
        /// </summary>
        [Newtonsoft.Json.JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// 参数值value
        /// </summary>
        [Newtonsoft.Json.JsonProperty("value")]
        public string Value { get; set; }
    }
}
