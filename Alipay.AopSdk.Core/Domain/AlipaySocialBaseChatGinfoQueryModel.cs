using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialBaseChatGinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseChatGinfoQueryModel : AopObject
    {
        /// <summary>
        /// 群id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_id")]
        public string GroupId { get; set; }
    }
}
