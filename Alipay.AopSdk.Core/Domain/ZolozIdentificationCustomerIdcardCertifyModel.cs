using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZolozIdentificationCustomerIdcardCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZolozIdentificationCustomerIdcardCertifyModel : AopObject
    {
        /// <summary>
        /// 业务唯一id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 当使用手填信息审核接口对营业执照进行审核时，填写该字段信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_license_cert")]
        public BusinessLicenseCertFileds BusinessLicenseCert { get; set; }

        /// <summary>
        /// 当使用手填信息审核接口对身份证进行审核时，填写该字段信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cert")]
        public CertFields Cert { get; set; }

        /// <summary>
        /// 上传证件图片信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("idcard_img")]
        public IdCardImg IdcardImg { get; set; }

        /// <summary>
        /// 用户uid
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operater_id")]
        public string OperaterId { get; set; }
    }
}
