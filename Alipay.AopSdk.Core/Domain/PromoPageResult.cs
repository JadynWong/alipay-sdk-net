using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromoPageResult Data Structure.
    /// </summary>
    [Serializable]
    public class PromoPageResult : AopObject
    {
        /// <summary>
        /// 页码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页多少条
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 总共有多少页
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_pages")]
        public long TotalPages { get; set; }
    }
}
