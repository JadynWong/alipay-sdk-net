using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppProdmodeChargeoffinstQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppProdmodeChargeoffinstQueryModel : AopObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_type")]
        public string BizType { get; set; }
    }
}
