using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdXwbtestprodQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdXwbtestprodQueryModel : AopObject
    {
        /// <summary>
        /// 省份编码，国标码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// wert
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qwe_dfgfd")]
        public string QweDfgfd { get; set; }
    }
}
