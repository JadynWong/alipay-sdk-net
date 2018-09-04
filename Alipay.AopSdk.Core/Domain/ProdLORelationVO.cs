using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProdLORelationVO Data Structure.
    /// </summary>
    [Serializable]
    public class ProdLORelationVO : AopObject
    {
        /// <summary>
        /// 区域编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lo_code")]
        public string LoCode { get; set; }

        /// <summary>
        /// 区域类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lo_type")]
        public string LoType { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 产品版本
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prod_version")]
        public string ProdVersion { get; set; }
    }
}
