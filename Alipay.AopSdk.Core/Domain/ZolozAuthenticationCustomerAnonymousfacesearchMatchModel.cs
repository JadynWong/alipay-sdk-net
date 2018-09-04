using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZolozAuthenticationCustomerAnonymousfacesearchMatchModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZolozAuthenticationCustomerAnonymousfacesearchMatchModel : AopObject
    {
        /// <summary>
        /// 地域编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("areacode")]
        public string Areacode { get; set; }

        /// <summary>
        /// 活体照片的二进制内容，然后做base64编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authimg")]
        public string Authimg { get; set; }

        /// <summary>
        /// 业务量规模
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bizscale")]
        public string Bizscale { get; set; }

        /// <summary>
        /// 商户品牌
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brandcode")]
        public string Brandcode { get; set; }

        /// <summary>
        /// 商户机具唯一编码，关键参数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("devicenum")]
        public string Devicenum { get; set; }

        /// <summary>
        /// 群组
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group")]
        public string Group { get; set; }

        /// <summary>
        /// 门店编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("storecode")]
        public string Storecode { get; set; }

        /// <summary>
        /// 有效期天数，如7天、30天、365天
        /// </summary>
        [Newtonsoft.Json.JsonProperty("validtimes")]
        public string Validtimes { get; set; }
    }
}
