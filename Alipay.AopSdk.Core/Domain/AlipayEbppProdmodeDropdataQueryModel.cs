using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppProdmodeDropdataQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppProdmodeDropdataQueryModel : AopObject
    {
        /// <summary>
        /// 参数为：缴费业务类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 参数包含：业务类型、子业务类型、产品模式等
        /// </summary>
        [Newtonsoft.Json.JsonProperty("search_type")]
        public string SearchType { get; set; }
    }
}
