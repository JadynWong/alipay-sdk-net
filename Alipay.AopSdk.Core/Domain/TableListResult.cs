using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TableListResult Data Structure.
    /// </summary>
    [Serializable]
    public class TableListResult : AopObject
    {
        /// <summary>
        /// 桌名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("table_name")]
        public string TableName { get; set; }

        /// <summary>
        /// 桌号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("table_num")]
        public string TableNum { get; set; }
    }
}
