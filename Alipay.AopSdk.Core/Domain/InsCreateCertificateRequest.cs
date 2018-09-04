using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsCreateCertificateRequest Data Structure.
    /// </summary>
    [Serializable]
    public class InsCreateCertificateRequest : AopObject
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 保险凭证类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("certificate_type")]
        public string CertificateType { get; set; }

        /// <summary>
        /// 生效时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effect_time")]
        public string EffectTime { get; set; }

        /// <summary>
        /// 失效时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 面值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("face_value")]
        public string FaceValue { get; set; }

        /// <summary>
        /// 电子保单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ins_policy_no")]
        public string InsPolicyNo { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单来源
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_source")]
        public string OrderSource { get; set; }

        /// <summary>
        /// 外部业务单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 拥有人uid
        /// </summary>
        [Newtonsoft.Json.JsonProperty("owner_uid")]
        public string OwnerUid { get; set; }
    }
}
