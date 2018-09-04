using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdAmlriskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdAmlriskQueryModel : AopObject
    {
        /// <summary>
        /// 办公地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_address")]
        public string BusinessAddress { get; set; }

        /// <summary>
        /// 标识该次反洗钱风险分析事件请求的id，商户应保证此id唯一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("event_id")]
        public string EventId { get; set; }

        /// <summary>
        /// 与商户相关个体的信息列表，可以有0个到多个。
        /// </summary>
        [XmlArray("individual_list")]
        [XmlArrayItem("individual_info")]
        public List<IndividualInfo> IndividualList { get; set; }

        /// <summary>
        /// 公司名称、类型、性质
        /// </summary>
        [Newtonsoft.Json.JsonProperty("legal_name")]
        public string LegalName { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 该商户准入申请的id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 公司注册地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("registered_address")]
        public string RegisteredAddress { get; set; }

        /// <summary>
        /// 公司注册号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("registration_number")]
        public string RegistrationNumber { get; set; }
    }
}
