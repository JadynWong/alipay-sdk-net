using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubMerchantEnterOpenModel Data Structure.
    /// </summary>
    [Serializable]
    public class SubMerchantEnterOpenModel : AopObject
    {
        /// <summary>
        /// 商户门店税号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("register_no")]
        public string RegisterNo { get; set; }

        /// <summary>
        /// 商户门店全称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_m_name")]
        public string SubMName { get; set; }

        /// <summary>
        /// 商户门店简称，只能由大写字母、下划线、数字组成，且必须以大写字母开头。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_m_short_name")]
        public string SubMShortName { get; set; }
    }
}
