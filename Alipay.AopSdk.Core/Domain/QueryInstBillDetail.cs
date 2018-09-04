using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QueryInstBillDetail Data Structure.
    /// </summary>
    [Serializable]
    public class QueryInstBillDetail : AopObject
    {
        /// <summary>
        /// 明细key
        /// </summary>
        [Newtonsoft.Json.JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// 明细描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 明细对应值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("value")]
        public string Value { get; set; }
    }
}
