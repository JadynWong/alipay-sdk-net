using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialBaseChatGnameModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseChatGnameModifyModel : AopObject
    {
        /// <summary>
        /// 群id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 群名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_name")]
        public string GroupName { get; set; }
    }
}
