using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdSubmerchantCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdSubmerchantCreateModel : AopObject
    {
        /// <summary>
        /// 受理商户详细经营地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// 受理商户简称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alias_name")]
        public string AliasName { get; set; }

        /// <summary>
        /// 受理商户营业执照编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_license")]
        public string BusinessLicense { get; set; }

        /// <summary>
        /// 受理商户经营类目，参考开放平台口碑开放行业入驻要求
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 受理商户所在城市编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 受理商户联系人邮箱
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 受理商户联系人手机号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 受理商户联系人名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 受理商户联系人电话
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 受理商户所在区县编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 受理商户编号，由受理机构定义，需要保证在受理机构下唯一
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 受理商户身份证编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id_card")]
        public string IdCard { get; set; }

        /// <summary>
        /// 受理商户备注信息，可填写额外信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 受理商户名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 受理商户所在省份编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 受理商户客服电话
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_phone")]
        public string ServicePhone { get; set; }

        /// <summary>
        /// 受理商户来源机构标识，填写受理机构在支付宝的pid
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source")]
        public string Source { get; set; }
    }
}
