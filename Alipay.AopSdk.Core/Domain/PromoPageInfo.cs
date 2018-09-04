using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromoPageInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PromoPageInfo : AopObject
    {
        /// <summary>
        /// 页码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        public long PageSize { get; set; }
    }
}
