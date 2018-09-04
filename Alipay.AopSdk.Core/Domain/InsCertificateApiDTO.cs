using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsCertificateApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsCertificateApiDTO : AopObject
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 保险凭证号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("certificate_no")]
        public string CertificateNo { get; set; }

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
        /// 机构保单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ins_policy_no")]
        public string InsPolicyNo { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 订单号
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

        /// <summary>
        /// 保险凭证状态
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        public long Status { get; set; }

        /// <summary>
        /// 使用时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("use_time")]
        public string UseTime { get; set; }

        /// <summary>
        /// 使用人uid
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_uid")]
        public string UserUid { get; set; }
    }
}
