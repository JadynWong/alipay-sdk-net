using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdFacepayUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdFacepayUploadModel : AopObject
    {
        /// <summary>
        /// 用户输入的邀请码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("check_code")]
        public string CheckCode { get; set; }

        /// <summary>
        /// Base64编码的人脸图片
        /// </summary>
        [Newtonsoft.Json.JsonProperty("face_image")]
        public string FaceImage { get; set; }

        /// <summary>
        /// 商户门店编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_id")]
        public string StoreId { get; set; }
    }
}
