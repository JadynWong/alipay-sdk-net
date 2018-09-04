using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdSubmerchantModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdSubmerchantModifyModel : AopObject
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
        /// 受理商户城市编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 受理商户联系人名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 受理商户区县编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 受理商户编号，与sub_merchant_id二选一必传
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 受理商户身份证编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id_card")]
        public string IdCard { get; set; }

        /// <summary>
        /// 受理商户省份编码
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

        /// <summary>
        /// 本次修改受理商户的支付宝识别号，同请求传入的sub_merchant_id字段，与external_id二选一必传
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_merchant_id")]
        public string SubMerchantId { get; set; }
    }
}
