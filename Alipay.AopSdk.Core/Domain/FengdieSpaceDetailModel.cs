using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FengdieSpaceDetailModel Data Structure.
    /// </summary>
    [Serializable]
    public class FengdieSpaceDetailModel : AopObject
    {
        /// <summary>
        /// 空间可用域名列表，云凤蝶站点发布后链接可用采用的域名
        /// </summary>
        [XmlArray("domains")]
        [XmlArrayItem("fengdie_space_domains")]
        public List<FengdieSpaceDomains> Domains { get; set; }

        /// <summary>
        /// 空间创建时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 空间 ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("space_id")]
        public string SpaceId { get; set; }

        /// <summary>
        /// 空间标题
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        public string Title { get; set; }
    }
}
