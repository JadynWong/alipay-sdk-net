using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingToolFengdieSpaceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingToolFengdieSpaceQueryModel : AopObject
    {
        /// <summary>
        /// 作为当前操作者的空间成员用户名， 值为 origin_user_id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 欲查询的空间 ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("space_id")]
        public string SpaceId { get; set; }
    }
}
