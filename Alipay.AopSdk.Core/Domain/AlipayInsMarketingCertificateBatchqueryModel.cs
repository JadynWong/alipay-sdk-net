using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsMarketingCertificateBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsMarketingCertificateBatchqueryModel : AopObject
    {
        /// <summary>
        /// 32
        /// </summary>
        [Newtonsoft.Json.JsonProperty("certificate_no")]
        public string CertificateNo { get; set; }

        /// <summary>
        /// 凭证类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("certificate_type")]
        public string CertificateType { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("current_page_no")]
        public long CurrentPageNo { get; set; }

        /// <summary>
        /// 生效时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effect_time")]
        public string EffectTime { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 是否失效
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_enabled")]
        public string IsEnabled { get; set; }

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

        /// <summary>
        /// 每页记录数量
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 凭证状态
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        public long Status { get; set; }
    }
}
