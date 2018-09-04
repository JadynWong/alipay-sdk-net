using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantModel Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantModel : AopObject
    {
        /// <summary>
        /// 商户别名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alias_name")]
        public string AliasName { get; set; }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact_number")]
        public string ContactNumber { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商户或者isv的pid
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pid")]
        public string Pid { get; set; }
    }
}
