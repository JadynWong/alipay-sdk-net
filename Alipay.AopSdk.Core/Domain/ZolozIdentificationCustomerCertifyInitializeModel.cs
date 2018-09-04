using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZolozIdentificationCustomerCertifyInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZolozIdentificationCustomerCertifyInitializeModel : AopObject
    {
        /// <summary>
        /// 商户请求的唯一标志，该标识作为对账的关键信息，商户要保证其唯一性
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 实人信息：姓名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 实人信息：证件号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 实人信息：证件类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 用人脸引导页是否显示
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_welcome_page")]
        public bool HasWelcomePage { get; set; }

        /// <summary>
        /// metainfo环境参数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("metainfo")]
        public string Metainfo { get; set; }

        /// <summary>
        /// 通过terminal_pos确定端内或端外模式
        /// </summary>
        [Newtonsoft.Json.JsonProperty("terminal_pos")]
        public string TerminalPos { get; set; }

        /// <summary>
        /// 商户的用户id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
