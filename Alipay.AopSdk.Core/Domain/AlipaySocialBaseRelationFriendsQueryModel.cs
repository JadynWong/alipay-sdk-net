using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialBaseRelationFriendsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseRelationFriendsQueryModel : AopObject
    {
        /// <summary>
        /// 获取类型。1=获取双向好友   2=获取双向+单向好友
        /// </summary>
        [Newtonsoft.Json.JsonProperty("get_type")]
        public long GetType { get; set; }

        /// <summary>
        /// 好友列表中是否返回自己， true=返回   false=不返回    默认false
        /// </summary>
        [Newtonsoft.Json.JsonProperty("include_self")]
        public bool IncludeSelf { get; set; }
    }
}
